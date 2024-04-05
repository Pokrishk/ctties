using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Testic.ViewModel.Helpers;

namespace Testic.ViewModel
{
    internal class RedTestViewModel:BindingHelper
    {
        public BindableCommand Command22 { get; set; }
        public BindableCommand Command33 { get; set; }
        public ObservableCollection<Que> quest;
        public RedTestViewModel()
        {
            Command22 = new BindableCommand(_ => Button_Click_1());
            Command33 = new BindableCommand(_ => Button_Click_2());
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\aaa.json";
            quest = serdes.Des<ObservableCollection<Que>>(path);
        }
        public void Button_Click_1()
        {
            quest.Add(new Que("", "", "", "", "", CorrectAnswer.First));
            OnPropertyChanged();
        }

        public void Button_Click_2() 
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktopPath + "\\aaa.json";
            serdes.Ser<ObservableCollection<Que>>(quest, path);
        }
    }
}
