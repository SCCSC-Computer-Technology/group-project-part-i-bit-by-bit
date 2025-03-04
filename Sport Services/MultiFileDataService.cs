/** 
 * GROUP PROJECT #1
 * CPT - 206 
 * 
 * MULTI-FILE-DATA-SERVICE
**/

using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Sports.Services
{
    public class MultiFileDataService
    {
        // Stores merged CSV data
        private DataTable _combinedDataTable;

        // List of CSV file URLs
        private readonly List<string> _csvUrls;

        // name of the service for logging purposes
        private string _serviceName;

        // Lock for thread safety
        private readonly object _lock = new object();
        private ConcurrentDictionary<string, (string Content, DateTime LastModified)> _csvCache = new ConcurrentDictionary<string, (string, DateTime)>();

        public MultiFileDataService(List<string> csvUrls, string serviceName = "CSV Data Service")
        {
            _csvUrls = csvUrls ?? throw new ArgumentNullException(nameof(csvUrls), "List of CSV Urls cannot be null.");
            _combinedDataTable = new DataTable();
            _serviceName = serviceName;
        }

        // Load the data from multiple CSV URLs asynchronously, processes it then merges into a dataTable
        public async Task LoadDataAsync(Dictionary<string, string> csvUrlsWithSeasons)
        {
            _combinedDataTable = new DataTable();
            if (csvUrlsWithSeasons == null || !csvUrlsWithSeasons.Any())
            {
                MessageBox.Show($"[{_serviceName}] No CSV URLs provided.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool headerAdded = false;
            HashSet<string> existingColumnNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Ensuring Season column exists to categorize the data
            if (!_combinedDataTable.Columns.Contains("Season"))
            {
                _combinedDataTable.Columns.Add("Season", typeof(string));
            }

            using (HttpClient client = new HttpClient())
            {
                var tasks = csvUrlsWithSeasons.Select(async urlSeasonPair =>
                {
                    string csvUrl = urlSeasonPair.Key;
                    string seasonName = urlSeasonPair.Value;
                    string csvContent;

                    try
                    {
                        // Updated: Implemented the caching to avoid redundant downloads
                        if (_csvCache.ContainsKey(csvUrl))
                        {
                            csvContent = _csvCache[csvUrl].Content;
                        }
                        else
                        {
                            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, csvUrl);
                            HttpResponseMessage response = await client.SendAsync(request);
                            response.EnsureSuccessStatusCode();
                            csvContent = await response.Content.ReadAsStringAsync();
                            _csvCache[csvUrl] = (csvContent, DateTime.Now);
                        }

                        if (string.IsNullOrEmpty(csvContent))
                        {
                            Console.WriteLine($"[{_serviceName}] Empty content received from URL: {csvUrl}");
                            return;
                        }

                        using (var reader = new StringReader(csvContent))
                        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                        {
                            IgnoreBlankLines = true,
                            HeaderValidated = null,
                            MissingFieldFound = null
                        }))
                        {
                            csv.Read();
                            csv.ReadHeader();

                            if (!headerAdded)
                            {
                                foreach (var header in csv.HeaderRecord)
                                {
                                    string uniqueHeader = header;
                                    int duplicateCounter = 1;
                                    while (existingColumnNames.Contains(uniqueHeader))
                                    {
                                        uniqueHeader = $"{header}_{duplicateCounter++}";
                                    }
                                    _combinedDataTable.Columns.Add(uniqueHeader);
                                    existingColumnNames.Add(uniqueHeader);
                                }
                                headerAdded = true;
                            }

                            // Updated: Using ConcurrentBag for thread-safe batch processing
                            ConcurrentBag<DataRow> rowBag = new ConcurrentBag<DataRow>();
                            while (csv.Read())
                            {
                                var record = csv.GetRecord<dynamic>();
                                DataRow dataRow = _combinedDataTable.NewRow();
                                dataRow["Season"] = seasonName;

                                int columnIndex = 1;
                                foreach (var property in (IDictionary<string, object>)record)
                                {
                                    if (_combinedDataTable.Columns.Count > columnIndex)
                                    {
                                        dataRow[columnIndex] = property.Value;
                                        columnIndex++;
                                    }
                                }

                                rowBag.Add(dataRow);
                            }

                            lock (_lock)
                            {
                                foreach (var row in rowBag)
                                {
                                    _combinedDataTable.Rows.Add(row);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[{_serviceName}] Error processing {csvUrl}: {ex.Message}");
                    }
                });

                await Task.WhenAll(tasks);
            }
        }

        // Searches the detaset for a keyword across specified columns.
        public DataTable SearchData(string keyword, string[] searchColumns)
        {
            if (string.IsNullOrWhiteSpace(keyword) || searchColumns == null || searchColumns.Length == 0)
                return _combinedDataTable;

            var filteredRows = _combinedDataTable.AsEnumerable()
                .Where(row => searchColumns.Any(column =>
                    row[column] != DBNull.Value &&
                    row[column].ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0));

            return filteredRows.Any() ? filteredRows.CopyToDataTable() : _combinedDataTable.Clone();
        }

        // Filters the dataset based on a specific column and value.
        public DataTable FilterDataByColumn(string columnName, string value)
        {
            if (string.IsNullOrWhiteSpace(columnName) || string.IsNullOrWhiteSpace(value) || value == "All")
                return _combinedDataTable;

            var filteredRows = _combinedDataTable.AsEnumerable()
                .Where(row => row[columnName].ToString().Equals(value, StringComparison.OrdinalIgnoreCase));

            return filteredRows.Any() ? filteredRows.CopyToDataTable() : _combinedDataTable.Clone();
        }

        // Retrive the unique values from a specified column in sorted order
        public List<string> GetUniqueColumnValues(string columnName)
        {
            if (string.IsNullOrWhiteSpace(columnName) || !_combinedDataTable.Columns.Contains(columnName))
            {
                Console.WriteLine($"[{_serviceName}] Warning: Column '{columnName}' is empty or not found. Returning empty list.");
                return new List<string>();
            }

            return _combinedDataTable.AsEnumerable()
                .Select(row => row.Field<string>(columnName))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(value => value)
                .ToList();
        }

        // And here it returns all the combined data as one dataTable
        public DataTable GetAllData()
        {
            return _combinedDataTable;
        }
    }
}
