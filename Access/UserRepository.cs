using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Access
{
    public static class UserRepository
    {
        public static bool ValidateLogin(string username, string password)
        {
            const string sql =
                @"SELECT COUNT(*)
                  FROM user
                  WHERE userName = @userName
                    AND password = @password
                    AND active = 1;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userName", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();
                int count = (result == null) ? 0 : System.Convert.ToInt32(result);
                return count > 0;
            }
        }

        public static int GetUserId(string username)
        {
            const string sql =
                @"SELECT userId
                    FROM user
                    WHERE userName = @userName
                    LIMIT 1;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userName", username);

                object result = cmd.ExecuteScalar();
                if (result == null) return 0;

                return Convert.ToInt32(result);
            }
        }

    }
}
