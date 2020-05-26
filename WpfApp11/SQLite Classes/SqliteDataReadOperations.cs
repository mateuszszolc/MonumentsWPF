using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp11
{
     static class SqliteDataReadOperations
    {
        public static void ReadCountries(SQLiteConnection connection, List<Country> myList, ComboBox comboBox)
        {
            connection.Open();

            SQLiteCommand cmdCountry = new SQLiteCommand("SELECT * FROM Countries", connection);
            SQLiteDataReader dr = cmdCountry.ExecuteReader();

            while (dr.Read())
            {
                comboBox.Items.Add(dr["countryName"]);
                myList.Add(new Country()
                {
                    countryId = Convert.ToInt32(dr["countryId"]),
                    countryName = dr["countryName"] as string
                });
            }

            connection.Close();
        }

        public static void ReadCities(SQLiteConnection connection, List<City> myList)
        {
            connection.Open();
            SQLiteCommand cmdCity = new SQLiteCommand("SELECT * FROM Cities", connection);

            SQLiteDataReader dr = cmdCity.ExecuteReader();
            while (dr.Read())
            {
                myList.Add(new City()
                {
                    cityId = Convert.ToInt32(dr["cityId"]),
                    cityName = dr["cityName"] as string,
                    countryId = dr["countryId"] as string
                });
            }

            connection.Close();
        }

        public static void ReadMonuments(SQLiteConnection connection, List<Monument> myList)
        {
            connection.Open();
            SQLiteCommand cmdMonument = new SQLiteCommand("SELECT * FROM Monuments", connection);

            SQLiteDataReader dr = cmdMonument.ExecuteReader();
            while (dr.Read())
            {
                myList.Add(new Monument()
                {
                    monumentId = Convert.ToInt32(dr["monumentId"]),
                    monumentName = dr["monumentName"] as string,
                    cityId = dr["cityId"] as string
                });
            }

            connection.Close();
        }

        public static void ReadMonumentFeatures(SQLiteConnection connection, string value,ref  MonumentFeatures features)
        {
            connection.Open();

            SQLiteCommand cmd = new SQLiteCommand(connection);
            cmd.Parameters.Add(new SQLiteParameter("@kombo", value));
            cmd.CommandText = "SELECT * FROM MonumentFeatures WHERE monumentId = @kombo;";

            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                features = new MonumentFeatures()
                {
                    monumentFeatureId = Convert.ToInt32(dr["monumentFeatureId"]),
                    imagePath = dr["imagePath"] as string,
                    description = dr["description"] as string,
                    googleMapsLink = dr["googleMapsLink"] as string,
                    monumentId = dr["monumentId"] as string
                };
            }

            connection.Close();

        }
    }
}
