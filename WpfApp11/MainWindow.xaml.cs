using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Data;

namespace WpfApp11
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Country> countries = new List<Country>();
        List<City> cities = new List<City>();
        List<Monument> monuments = new List<Monument>();
        SQLiteConnection conn = new SqliteDataAccess().GetConnection();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Value = MonumentComboBox.SelectedItem.ToString();
                MonumentDescription mDescription = new MonumentDescription(Value);
                mDescription.ShowDialog();
                mDescription.MonumentComboBoxValue = Value;
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Proszę uzupełnić wszystkie dane!");
            }
        }

        private void CountryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CountryComboBox.SelectedIndex != -1)
            {
                CityComboBox.IsEnabled = true;
            }
            else
            {
                CityComboBox.IsEnabled = false;
            }

            CityComboBox.Items.Clear();
            MonumentComboBox.Items.Clear();

            string id = CountryComboBox.SelectedItem.ToString();

            foreach (string name in GetCityById(id))
            {
                CityComboBox.Items.Add(name);
            }

            //CityComboBox.SelectedIndex = 0;
        }

        private void CityComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CityComboBox.SelectedIndex != -1 && CountryComboBox.SelectedIndex != -1)
            {
                MonumentComboBox.IsEnabled = true;
            }
            else
            {
                MonumentComboBox.IsEnabled = false;
            }

            MonumentComboBox.Items.Clear();

            try
            {
                MonumentComboBox.Items.Clear();

                string id = CityComboBox.SelectedItem.ToString();

                foreach (string name in GetMonumentById(id))
                {
                    MonumentComboBox.Items.Add(name);
                }

                //  MonumentComboBox.SelectedIndex = 0;

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Zmieniono dane!");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqliteDataReadOperations.ReadCountries(conn, countries, CountryComboBox);
            SqliteDataReadOperations.ReadCities(conn, cities);
            SqliteDataReadOperations.ReadMonuments(conn, monuments);
        }

        private string[] GetCityById(string id)
        {
            return cities.Where(line => line.countryId == id).Select(l => l.cityName).ToArray();
        }

        private string[] GetMonumentById(string id)
        {
            return monuments.Where(line => line.cityId == id).Select(l => l.monumentName).ToArray();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            AddMonument addMonument = new AddMonument();
            
            addMonument.ShowDialog();
        }

        private void MonumentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
}