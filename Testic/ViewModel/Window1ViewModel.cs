using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Testic.ViewModel.Helpers;

namespace Testic.ViewModel
{
    internal class Window1ViewModel:BindingHelper
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
        public Window1ViewModel()
        {
            DisplayText = "Выйти";
            Command = new BindableCommand(_ => UpdateText());
        }
        private void UpdateText()
        {
            DisplayText = "Хе-хе";
        }

    }
}
