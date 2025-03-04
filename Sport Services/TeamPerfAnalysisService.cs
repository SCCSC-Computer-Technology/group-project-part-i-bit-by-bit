using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _3Sports.Sport_Services
{
    public class TeamPerfAnalysisService
    {
        private DataTable _data;

        public TeamPerfAnalysisService(DataTable data)
        {
            _data = data;
        }

        public Dictionary<string, double> GetTeamPerfStats(string teamName)
        {
            var matches = _data.AsEnumerable().Where(row => row["HomeTeam"].ToString() == teamName || row["AwayTeam"].ToString() == teamName);

            int totalMatches = matches.Count();
            int wins = matches.Count(row => (row["HomeTeam"].ToString() == teamName && Convert.ToInt32(row["FTHG"]) > Convert.ToInt32(row["FTAG"])) ||
                                            (row["AwayTeam"].ToString() == teamName && Convert.ToInt32(row["FTAG"]) > Convert.ToInt32(row["FTHG"])));
            int losses = matches.Count(row => (row["HomeTeam"].ToString() == teamName && Convert.ToInt32(row["FTHG"]) < Convert.ToInt32(row["FTAG"])) ||
                                              (row["AwayTeam"].ToString() == teamName && Convert.ToInt32(row["FTAG"]) < Convert.ToInt32(row["FTHG"])));
            int draws = totalMatches - (wins + losses);

            double winRate = totalMatches > 0 ? (double)wins / totalMatches * 100 : 0;

            return new Dictionary<string, double>
            {
                { "Total Matches", totalMatches },
                { "Wins", wins },
                { "Losses", losses },
                { "Draws", draws },
                { "Win Rate (%)", Math.Round(winRate, 2) }
            };
        }
    }

    // ***************************************************************************************************

    // New Services

    public class MatchPredictionService
    {
        private DataTable _matchData;
        private Random _random;

        public MatchPredictionService(DataTable matchData)
        {
            _matchData = matchData;
            _random = new Random();
        }

        public string PredictMatchOutcome(string team1, string team2)
        {
            int team1Wins = GetTeamWins(team1);
            int team2Wins = GetTeamWins(team2);

            if (team1Wins > team2Wins)
            {
                return $"{team1} has a strong chance of winning!";
            }
            else if (team2Wins > team1Wins)
            {
                return $"{team2} is likely to take the win!";
            }
            else
            {
                return "A Draw might be on the cards!";
            }
        }

        private int GetTeamWins(string team)
        {
            return _matchData.AsEnumerable()
                .Count(row =>
                {
                    string homeTeam = row.Field<string>("HomeTeam");

                    // Convert to integer safely, handling DBNull cases
                    int homeGoals = row["FTHG"] is DBNull ? 0 : Convert.ToInt32(row["FTHG"]);
                    int awayGoals = row["FTAG"] is DBNull ? 0 : Convert.ToInt32(row["FTAG"]);

                    return homeTeam == team && homeGoals > awayGoals;
                });
        }

    }
}
