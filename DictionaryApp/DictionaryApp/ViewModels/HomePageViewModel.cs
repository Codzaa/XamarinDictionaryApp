using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DictionaryApp.ViewModels
{
    public class HomePageViewModel:INotifyPropertyChanged
    {

        //Interface Needed for InotifyPropertyChanged to work
        public event PropertyChangedEventHandler PropertyChanged;

        //Constructor
        public HomePageViewModel()
        {

        }

       
    }
}
