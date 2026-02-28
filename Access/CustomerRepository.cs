using MySql.Data.MySqlClient;
using SchedulingApp.Access;
using SchedulingApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp.Access
{
    public static class CustomerRepository
    {
        public static List<Customer> GetAllCustomers()
        {
            const string sql =
                @"SELECT
                    cu.customerId,
                    cu.customerName,
                    a.address,
                    a.phone,
                    ci.city,
                    co.country
                  FROM customer cu
                  JOIN address a ON cu.addressId = a.addressId
                  JOIN city ci ON a.cityId = ci.cityId
                  JOIN country co ON ci.countryId = co.countryId
                  ORDER BY cu.customerId;";

            List<Customer> customers = new List<Customer>();

            if (DatabaseConnection.conn == null)
                throw new InvalidOperationException("DatabaseConnection.conn is null.");

            if (DatabaseConnection.conn.State != ConnectionState.Open)
                DatabaseConnection.conn.Open();

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustomerId = reader.GetInt32("customerId"),
                            CustomerName = reader.GetString("customerName"),
                            Address = reader.GetString("address"),
                            Phone = reader.GetString("phone"),
                            City = reader.GetString("city"),
                            Country = reader.GetString("country")
                        });
                    }
                }
            }

            return customers;
        }

        public static List<CustomerLookup> GetCustomerLookup()
        {
            const string sql = @"SELECT customerId, customerName FROM customer ORDER BY customerName;";

            var list = new List<CustomerLookup>();

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new CustomerLookup
                    {
                        CustomerId = reader.GetInt32("customerId"),
                        CustomerName = reader.GetString("customerName")
                    });
                }
            }

            return list;
        }

        public static void AddCustomer(
            string customerName,
            string address,
            string phone,
            string postalCode,
            int cityId,
            string username)
        {
            MySqlTransaction tx = null;

            try
            {
                tx = DatabaseConnection.conn.BeginTransaction();

                const string insertAddressSql =
                    @"INSERT INTO address
              (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)
              VALUES
              (@address, '', @cityId, @postalCode, @phone, NOW(), @user, NOW(), @user);";

                int newAddressId;

                using (MySqlCommand cmd = new MySqlCommand(insertAddressSql, DatabaseConnection.conn, tx))
                {
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@cityId", cityId);
                    cmd.Parameters.AddWithValue("@postalCode", postalCode);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@user", username);

                    cmd.ExecuteNonQuery();
                    newAddressId = Convert.ToInt32(cmd.LastInsertedId);
                }

                const string insertCustomerSql =
                    @"INSERT INTO customer
              (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
              VALUES
              (@name, @addressId, 1, NOW(), @user, NOW(), @user);";

                using (MySqlCommand cmd = new MySqlCommand(insertCustomerSql, DatabaseConnection.conn, tx))
                {
                    cmd.Parameters.AddWithValue("@name", customerName);
                    cmd.Parameters.AddWithValue("@addressId", newAddressId);
                    cmd.Parameters.AddWithValue("@user", username);

                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch
            {
                if (tx != null) tx.Rollback();
                throw;
            }
        }

        public static void UpdateCustomer(
            int customerId,
            string customerName,
            string address,
            string phone,
            string postalCode,
            int cityId,
            string username)
        {
            MySqlTransaction tx = null;

            try
            {
                tx = DatabaseConnection.conn.BeginTransaction();

                // Updating address
                const string updateAddressSql =
                    @"UPDATE address a
              JOIN customer c ON a.addressId = c.addressId
              SET a.address = @address,
                  a.phone = @phone,
                  a.postalCode = @postal,
                  a.cityId = @cityId,
                  a.lastUpdate = NOW(),
                  a.lastUpdateBy = @user
              WHERE c.customerId = @customerId;";

                using (MySqlCommand cmd = new MySqlCommand(updateAddressSql, DatabaseConnection.conn, tx))
                {
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@postal", postalCode);
                    cmd.Parameters.AddWithValue("@cityId", cityId);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    cmd.ExecuteNonQuery();
                }

                // Updating customer
                const string updateCustomerSql =
                    @"UPDATE customer
              SET customerName = @name,
                  lastUpdate = NOW(),
                  lastUpdateBy = @user
              WHERE customerId = @customerId;";

                using (MySqlCommand cmd = new MySqlCommand(updateCustomerSql, DatabaseConnection.conn, tx))
                {
                    cmd.Parameters.AddWithValue("@name", customerName);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch
            {
                if (tx != null) tx.Rollback();
                throw;
            }
        }

        public static void DeleteCustomer(int customerId)
        {
            const string sql = "DELETE FROM customer WHERE customerId = @id;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@id", customerId);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool CustomerHasAppointments(int customerId)
        {
            const string sql = @"SELECT COUNT(*) FROM appointment WHERE customerId = @id;";

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            {
                cmd.Parameters.AddWithValue("@id", customerId);
                object result = cmd.ExecuteScalar();
                int count = (result == null) ? 0 : Convert.ToInt32(result);
                return count > 0;
            }
        }

    }
}

