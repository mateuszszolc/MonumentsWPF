using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Controls;
using System.Windows;

namespace WpfApp11
{
    static class SqliteDataInsertOperations
    {
        public static void InsertDataToCountries(SQLiteConnection connection, string country)
        {
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(connection);

            cmd.Parameters.Add(new SQLiteParameter("@country", country));
            cmd.CommandText = @"SELECT (countryName) FROM Countries WHERE countryName = @country;";
            cmd.Connection = connection;

            string ifExist = (string)cmd.ExecuteScalar();

            if (ifExist != country)
            {               
                cmd.CommandText = @"INSERT INTO Countries (countryName) VALUES (@country)";
                cmd.ExecuteNonQuery();                
            }

            connection.Close();
        }

        public static void InsertDataToCities(SQLiteConnection connection, string city, string country)
        {
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(connection);

            cmd.Parameters.Add(new SQLiteParameter("@city", city));
            cmd.Parameters.Add(new SQLiteParameter("@countryId", country));
            cmd.CommandText = @"SELECT (cityName) FROM Cities WHERE cityName = @city";

            string ifExist = (string)cmd.ExecuteScalar();

            if (ifExist != city)
            {                
                cmd.CommandText = @"INSERT INTO Cities (cityName, countryId) VALUES (@city,@countryId)";
                cmd.ExecuteNonQuery();               
            }

            connection.Close();
        }

        public static void InsertDataToMonuments(SQLiteConnection connection, string monument, string city)
        {           
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand(connection);
                cmd.Parameters.Add(new SQLiteParameter("@monument", monument));
                cmd.Parameters.Add(new SQLiteParameter("@city", city));
                cmd.CommandText = @"SELECT (monumentName) FROM Monuments WHERE monumentName = @monument;";

                string ifExist = (string)cmd.ExecuteScalar();

                if (ifExist != monument)
                {
                cmd.CommandText = @"INSERT INTO Monuments (monumentName, cityId) VALUES (@monument,@city);";
                cmd.ExecuteNonQuery();                    
                }

                else
                {
                    MessageBox.Show("Ten zabytek już istnieje w bazie danych!");
                }

            connection.Close();
        }

        public static void InsertDataToMonumentFeatures(SQLiteConnection connection, string monument, string image,
            string description, string google)
        {
           connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(connection);

            cmd.Parameters.Add(new SQLiteParameter("@monument", monument));
            cmd.Parameters.Add(new SQLiteParameter("@image", image));
            cmd.Parameters.Add(new SQLiteParameter("@description", description));
            cmd.Parameters.Add(new SQLiteParameter("@google", google));

            cmd.CommandText = @"SELECT (monumentId) FROM MonumentFeatures WHERE monumentId = @monument;";

            string ifExist = (string)cmd.ExecuteScalar();

            if (ifExist != monument)
            {               
                cmd.CommandText = @"INSERT INTO MonumentFeatures (imagePath, description, googleMapsLink, monumentId) VALUES (@image,@description,@google,@monument);";
                cmd.ExecuteNonQuery();                
            }

            connection.Close();
        }
        
    }
}
