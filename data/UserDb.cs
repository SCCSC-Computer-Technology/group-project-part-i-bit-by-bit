using System.Data.SqlClient;

namespace _3Sports.Sport_Services
{
    public class UserDb
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Adich\\Desktop\\3Sports\\Services\\Users.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
