using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SchedulingApp.Access
{
    public static class DatabaseConnection
    {
        private static string connectionString =
            "server=localhost;port=3306;database=client_schedule;user=test;password=test;";

        public static MySqlConnection conn =
            new MySqlConnection(connectionString);

        public static void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
