using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Testic
{
    public partial class RedTest : Page
    {
        List<Que> que = new List<Que>();
        public RedTest()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\aaa.json";
            que = serdes.Des<List<Que>>(path);
            dataGrid.ItemsSource = que;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Que selectedQue = dataGrid.SelectedItem as Que;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            que.Add(new Que("", "", "", "", "", CorrectAnswer.First));
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = que;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\aaa.json";
            serdes.Ser<List<Que>>(que, path);
        }
    }
}
