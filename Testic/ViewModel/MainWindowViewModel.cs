using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.IO;
using Testic.ViewModel.Helpers;

namespace Testic
{
    internal class MainWindowViewModel: BindingHelper
    {
        private string _displayText;
        public string DisplayText
        {
            get { return _displayText; }
            set
            {
                _displayText = value;
                OnPropertyChanged();
            }
        }

        public BindableCommand Command { get; set; }
        public MainWindowViewModel()
        {
            DisplayText = "";
            Command = new BindableCommand(_ => UpdateText());
        }
        private void UpdateText()
        {
            DisplayText = "Типо прикол рял";
        }

    }
}
