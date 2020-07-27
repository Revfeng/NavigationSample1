using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Text;

namespace NavigateTest.ViewModels
{
    public class Page2ViewModel : INotifyPropertyChanged
    {
        public Page2ViewModel()
        {
            for (int i = 0; i < 10000; i++)
            {
                displayNames.Add("Leo");
            }
        }

        private ObservableCollection<string> displayNames = new ObservableCollection<string>();
        public ObservableCollection<string> DisplayNames
        {
            get { return displayNames; }
            set
            {
                if (value == displayNames) return;
                displayNames = value;
                OnPropertyChanged(nameof(displayNames));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
