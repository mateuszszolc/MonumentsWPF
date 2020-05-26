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
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Data;
using System.IO;


namespace WpfApp11
{
    /// <summary>
    /// Logika interakcji dla klasy MonumentDescription.xaml
    /// </summary>
    public partial class MonumentDescription : Window
    {      
        SQLiteConnection conn = new SqliteDataAccess().GetConnection();
        MonumentFeatures monumentFeatures;
        
       public string MonumentComboBoxValue { get; set; }

        public MonumentDescription(string value)
        {           
            InitializeComponent();
            this.MonumentComboBoxValue = value;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                SqliteDataReadOperations.ReadMonumentFeatures(conn, MonumentComboBoxValue, ref monumentFeatures);


                string Path = monumentFeatures.imagePath;

                Image image = new Image();
                image.Height = 300;
                image.Width = 320;
                BitmapImage src = new BitmapImage();
                src.BeginInit();
                src.UriSource = new Uri(Path, UriKind.Absolute);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.EndInit();
                MonumentImage.Source = src;

                MonumentTextBox.Text = monumentFeatures.description;
            }
            catch(UriFormatException)
            {
                MessageBox.Show("Nie udało się załadowac danych!");
                this.Close();
            }
            catch(System.IO.IOException)
            {
                MessageBox.Show("Nie udało się załadować obrazu!");
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(monumentFeatures.googleMapsLink);
        }

        private void MonumentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
