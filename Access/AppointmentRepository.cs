using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SchedulingApp.Models;

namespace SchedulingApp.Access
{
    public static class AppointmentRepository
    {
        public static bool TryGetUpcomingAppointment(int userId, DateTime utcNow, DateTime utcIn15,
            out int appointmentId, out DateTime startUtc)
        {
            appointmentId = 0;
            startUtc = DateTime.MinValue;

            const string sql =
                @"SELECT appointmentId, start
                  FROM appointment
                  WHERE userId = @userId
                    AND start >= @utcNow
                    AND start <= @utcIn15
                  ORDER BY start
                  LIMIT 1;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@utcNow", utcNow);
                cmd.Parameters.AddWithValue("@utcIn15", utcIn15);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return false;

                    appointmentId = reader.GetInt32("appointmentId");
                    startUtc = reader.GetDateTime("start");
                    return true;
                }
            }
        }

        public static List<Appointment> GetAllAppointments()
        {
            const string sql =
                @"SELECT a.appointmentId, a.customerId, c.customerName, a.type, a.start, a.end, a.userId
                  FROM appointment a
                  JOIN customer c ON a.customerId = c.customerId
                  ORDER BY a.start;";

            List<Appointment> appts = new List<Appointment>();

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime startFromDb = reader.GetDateTime("start");
                    DateTime endFromDb = reader.GetDateTime("end");

                    // specifying that the DateTime from the database is UTC
                    DateTime startUtc = DateTime.SpecifyKind(startFromDb, DateTimeKind.Utc);
                    DateTime endUtc = DateTime.SpecifyKind(endFromDb, DateTimeKind.Utc);

                    appts.Add(new Appointment
                    {
                        AppointmentId = reader.GetInt32("appointmentId"),
                        CustomerId = reader.GetInt32("customerId"),
                        CustomerName = reader.GetString("customerName"),
                        Type = reader.GetString("type"),
                        StartLocal = startUtc.ToLocalTime(),
                        EndLocal = endUtc.ToLocalTime(),
                        UserId = reader.GetInt32("userId")
                    });
                }
            }

            return appts;
        }

        public static void DeleteAppointment(int appointmentId)
        {
            const string sql = "DELETE FROM appointment WHERE appointmentId = @id;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@id", appointmentId);
                cmd.ExecuteNonQuery();
            }
        }

        public static AppointmentEdit GetAppointmentById(int appointmentId)
        {
            const string sql =
                @"SELECT appointmentId, customerId, type, start, end, userId
          FROM appointment
          WHERE appointmentId = @id
          LIMIT 1;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@id", appointmentId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    DateTime startFromDb = reader.GetDateTime("start");
                    DateTime endFromDb = reader.GetDateTime("end");

                    return new AppointmentEdit
                    {
                        AppointmentId = reader.GetInt32("appointmentId"),
                        CustomerId = reader.GetInt32("customerId"),
                        Type = reader.GetString("type"),
                        StartUtc = DateTime.SpecifyKind(startFromDb, DateTimeKind.Utc),
                        EndUtc = DateTime.SpecifyKind(endFromDb, DateTimeKind.Utc),
                        UserId = reader.GetInt32("userId")
                    };
                }
            }
        }

        public static bool HasOverlappingAppointment(int userId, DateTime newStartUtc, DateTime newEndUtc, int? ignoreAppointmentId)
        {
            string sql =
                @"SELECT COUNT(*)
          FROM appointment
          WHERE userId = @userId
            AND start < @newEnd
            AND end > @newStart";

            if (ignoreAppointmentId.HasValue)
                sql += " AND appointmentId <> @ignoreId;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@newStart", newStartUtc);
                cmd.Parameters.AddWithValue("@newEnd", newEndUtc);

                if (ignoreAppointmentId.HasValue)
                    cmd.Parameters.AddWithValue("@ignoreId", ignoreAppointmentId.Value);

                object result = cmd.ExecuteScalar();
                int count = result == null ? 0 : Convert.ToInt32(result);
                return count > 0;
            }
        }

        public static void AddAppointment(int customerId, int userId, string type, DateTime startUtc, DateTime endUtc, string username)
        {
            const string sql =
                @"INSERT INTO appointment
            (customerId, userId, title, description, location, contact, type, url,
             start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
          VALUES
            (@customerId, @userId, '', '', '', '', @type, '',
             @start, @end, NOW(), @user, NOW(), @user);";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@start", startUtc);
                cmd.Parameters.AddWithValue("@end", endUtc);
                cmd.Parameters.AddWithValue("@user", username);

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateAppointment(int appointmentId, int customerId, int userId, string type, DateTime startUtc, DateTime endUtc, string username)
        {
            const string sql =
                @"UPDATE appointment
          SET customerId = @customerId,
              userId = @userId,
              type = @type,
              start = @start,
              end = @end,
              lastUpdate = NOW(),
              lastUpdateBy = @user
          WHERE appointmentId = @id;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@id", appointmentId);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@start", startUtc);
                cmd.Parameters.AddWithValue("@end", endUtc);
                cmd.Parameters.AddWithValue("@user", username);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Appointment> GetAppointmentsForLocalDay(DateTime localDay)
        {
            // localDay is the date user clicked in local time
            DateTime localStart = localDay.Date;
            DateTime localEnd = localStart.AddDays(1);

            DateTime utcStart = DateTime.SpecifyKind(localStart, DateTimeKind.Local).ToUniversalTime();
            DateTime utcEnd = DateTime.SpecifyKind(localEnd, DateTimeKind.Local).ToUniversalTime();

            const string sql =
                @"SELECT a.appointmentId, a.customerId, c.customerName, a.type, a.start, a.end, a.userId
          FROM appointment a
          JOIN customer c ON a.customerId = c.customerId
          WHERE a.start >= @utcStart AND a.start < @utcEnd
          ORDER BY a.start;";

            List<Appointment> appts = new List<Appointment>();

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@utcStart", utcStart);
                cmd.Parameters.AddWithValue("@utcEnd", utcEnd);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime startFromDb = reader.GetDateTime("start");
                        DateTime endFromDb = reader.GetDateTime("end");

                        DateTime startUtc = DateTime.SpecifyKind(startFromDb, DateTimeKind.Utc);
                        DateTime endUtc = DateTime.SpecifyKind(endFromDb, DateTimeKind.Utc);

                        appts.Add(new Appointment
                        {
                            AppointmentId = reader.GetInt32("appointmentId"),
                            CustomerId = reader.GetInt32("customerId"),
                            CustomerName = reader.GetString("customerName"),
                            Type = reader.GetString("type"),
                            StartLocal = startUtc.ToLocalTime(),
                            EndLocal = endUtc.ToLocalTime(),
                            UserId = reader.GetInt32("userId")
                        });
                    }
                }
            }

            return appts;
        }

        public static List<Appointment> GetAllAppointmentsForReports()
        {
            return GetAllAppointments();
        }

        public static List<(string UserName, Appointment Appt)> GetAppointmentsWithUserNames()
        {
            const string sql =
                @"SELECT u.userName, a.appointmentId, a.customerId, c.customerName, a.type, a.start, a.end, a.userId
          FROM appointment a
          JOIN customer c ON a.customerId = c.customerId
          JOIN user u ON a.userId = u.userId
          ORDER BY u.userName, a.start;";

            var list = new List<(string, Appointment)>();

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime startUtc = DateTime.SpecifyKind(reader.GetDateTime("start"), DateTimeKind.Utc);
                    DateTime endUtc = DateTime.SpecifyKind(reader.GetDateTime("end"), DateTimeKind.Utc);

                    var appt = new Appointment
                    {
                        AppointmentId = reader.GetInt32("appointmentId"),
                        CustomerId = reader.GetInt32("customerId"),
                        CustomerName = reader.GetString("customerName"),
                        Type = reader.GetString("type"),
                        StartLocal = startUtc.ToLocalTime(),
                        EndLocal = endUtc.ToLocalTime(),
                        UserId = reader.GetInt32("userId")
                    };

                    list.Add((reader.GetString("userName"), appt));
                }
            }

            return list;
        }

    }
}
