using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
        DataContext = _viewModel;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\aaa.json";
            if (!File.Exists(path))
            {
                List<Que> que = new List<Que>();
                serdes.Ser<List<Que>>(que, path);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wind = new Window1();
            wind.Show();
            wind.Red.IsEnabled = false;
            Close();
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _1.IsEnabled = true;
        }

        private void CheckPassword()
        {
            if (_1.Text == "Треш")
            {
                OpenNewWindow();
            }
        }
        private void OpenNewWindow()
        {
            Window1 wind = new Window1();
            wind.Show();
            Close();
        }

        private void _1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_1.Text != "")
            {
                CheckPassword();
            }
        }
    }
}
