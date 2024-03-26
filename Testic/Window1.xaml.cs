﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Testic
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\aaa.json";
            if (!Pust(path))
            {
                framee.Content = new NoTest();
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            framee.Content = new Test();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            framee.Content = new RedTest();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
        private bool Pust(string path)
        {
            List<Que> dataList = serdes.Des<List<Que>>(path);
            if (dataList == null || dataList.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
