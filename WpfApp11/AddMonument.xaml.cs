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
using System.Data.SQLite;
using Microsoft.Win32;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Net;
using System.Windows.Navigation;

namespace WpfApp11
{
    /// <summary>
    /// Logika interakcji dla klasy AddMonument.xaml
    /// </summary>
    public partial class AddMonument : Window
    {
        SQLiteConnection conn = new SqliteDataAccess().GetConnection();
        string TextOfCountryTextBox;
        string TextOfCityTextBox;
        string TextOfMonumentTextBox;
        string TextOfImageTextBox;
        string TextOfGoogleMapsLinkTextBox;
        string TextOfDescriptionTextBox;
        

        public AddMonument()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (CountryTextBox.Text != "" && CityTextBox.Text != "" && MonumentTextBox.Text != "" && ImageTextBox.Text != ""
                    && GoogleMapsLinkTextBox.Text != "" && DescriptionTextBox.Text != "" && LinkExists(TextOfGoogleMapsLinkTextBox))
                {
                    SqliteDataInsertOperations.InsertDataToCountries(conn, TextOfCountryTextBox);
                    SqliteDataInsertOperations.InsertDataToCities(conn, TextOfCityTextBox, TextOfCountryTextBox);
                    SqliteDataInsertOperations.InsertDataToMonuments(conn, TextOfMonumentTextBox, TextOfCityTextBox);
                    SqliteDataInsertOperations.InsertDataToMonumentFeatures(conn, TextOfMonumentTextBox, TextOfImageTextBox, TextOfDescriptionTextBox, TextOfGoogleMapsLinkTextBox);
                    this.Close();
                }

                else if(CountryTextBox.Text != "" && CityTextBox.Text != "" && MonumentTextBox.Text != "" && ImageTextBox.Text != ""
                    && GoogleMapsLinkTextBox.Text != "" && DescriptionTextBox.Text != "" && !LinkExists(TextOfGoogleMapsLinkTextBox))
                {
                    throw new LinkDoesntExsistsException();
                }
                else
                {
                    throw new TextBoxIsEmptyException();
                }
            }

            catch (TextBoxIsEmptyException)
            {
                MessageBox.Show("Proszę uzupełnić wszystkie dane!");
            }
            catch(LinkDoesntExsistsException)
            {
                MessageBox.Show("Podany link do Google Maps nie istnieje!");
            }

            
           

        }
        
        private void CountryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CountryTextBox.Text.StartsWith(" "))
                CountryTextBox.Text = "";

            CountryTextBox.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.CountryTextBox.Text);
            CountryTextBox.Select(CountryTextBox.Text.Length, 0);

            TextOfCountryTextBox = CountryTextBox.Text.Trim();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenImagesPaths();   
        }

        private void OpenImagesPaths()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fileDialog.DefaultExt = ".jpg";
            Nullable<bool> dialogOK = fileDialog.ShowDialog();

            if (dialogOK == true)
            {
                string Filenames = "";

                foreach (string Filename in fileDialog.FileNames)
                {
                    Filenames += ";" + Filename;
                }
                Filenames = Filenames.Substring(1);

                ImageTextBox.Text = Filenames;
            }
        }

        private void CountryTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }          
        }

        private void CityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CityTextBox.Text.StartsWith(" "))
                CityTextBox.Text = "";

            CityTextBox.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.CityTextBox.Text);
            CityTextBox.Select(CityTextBox.Text.Length, 0);

            TextOfCityTextBox = CityTextBox.Text.Trim();
        }

        private void CityTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }

        private void MonumentTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }

        private void MonumentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MonumentTextBox.Text.StartsWith(" "))
                MonumentTextBox.Text = "";

            MonumentTextBox.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.MonumentTextBox.Text);
            MonumentTextBox.Select(MonumentTextBox.Text.Length, 0);

            TextOfMonumentTextBox = MonumentTextBox.Text.Trim();
        }

        private void GoogleMapsLinkTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (GoogleMapsLinkTextBox.Text.StartsWith(" "))
                GoogleMapsLinkTextBox.Text = "";

            TextOfGoogleMapsLinkTextBox = GoogleMapsLinkTextBox.Text.Trim();
        }

        private void DescriptionComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DescriptionTextBox.Text.StartsWith(" "))
                DescriptionTextBox.Text = "";

            TextOfDescriptionTextBox = DescriptionTextBox.Text.Trim();
        }

        private bool LinkExists(string uriName)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }

        private void ImageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextOfImageTextBox = ImageTextBox.Text;
        }
    }
}
