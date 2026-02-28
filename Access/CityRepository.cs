using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SchedulingApp.Models;

namespace SchedulingApp.Access
{
    public static class CityRepository
    {
        public static List<CityInfo> GetAllCities()
        {
            const string sql =
                @"SELECT ci.cityId, ci.city, co.country
                  FROM city ci
                  JOIN country co ON ci.countryId = co.countryId
                  ORDER BY co.country, ci.city;";

            var cities = new List<CityInfo>();

            using (MySqlCommand cmd = new MySqlCommand(sql, DatabaseConnection.conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int cityId = reader.GetInt32("cityId");
                    string city = reader.GetString("city");
                    string country = reader.GetString("country");

                    cities.Add(new CityInfo
                    {
                        CityId = cityId,
                        DisplayName = city + " (" + country + ")"
                    });
                }
            }

            return cities;
        }
    }
}
