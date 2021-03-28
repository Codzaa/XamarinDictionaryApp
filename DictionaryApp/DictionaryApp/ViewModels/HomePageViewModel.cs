using DictionaryApp.Models;
using DictionaryApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DictionaryApp.ViewModels
{
    public class HomePageViewModel:INotifyPropertyChanged
    {

        //Interface Needed for InotifyPropertyChanged to work
        public event PropertyChangedEventHandler PropertyChanged;

        //Command for Search Button
        public Command BtnSearch_Command { get; }

        //Constructor
        public HomePageViewModel()
        {
            BtnSearch_Command = new Command(SearchForWordAsync);
        }

        public string wordDef;
        public string WordDef
        {
            get => wordDef;
            set
            {
                if(value == wordDef) { return; }
                wordDef = value;
                var args = new PropertyChangedEventArgs(nameof(WordDef));
                PropertyChanged?.Invoke(this, args);
            }
        }
        //
        public string wordToSearch;
        public string WordToSearch
        {
            get => wordToSearch;
            set
            {
                if(value == wordToSearch) { return; }
                wordToSearch = value;
                var args = new PropertyChangedEventArgs(nameof(WordToSearch));
                PropertyChanged?.Invoke(this, args);
            }
        }
        //
        public bool actIndy = false;
        public bool ActivityIndy
        {
            get => actIndy;
            set
            {
                if(value == actIndy) { return; }
                actIndy = value;
                var args = new PropertyChangedEventArgs(nameof(ActivityIndy));
                PropertyChanged?.Invoke(this, args);
            }
        }
        //
        public string searchText;
        public string SearchText
        {
            get => searchText;
            set
            {
                if(value == searchText) { return; }
                searchText = value;
                var args = new PropertyChangedEventArgs(nameof(SearchText));
                PropertyChanged?.Invoke(this, args);
            }
        }


        //When the Home Page Comes into View
        public void OnAppearing()
        {
            SearchText = "Search";
        }

        //
        public async void SearchForWordAsync()
        {
            if(WordToSearch== null)
            {
                return;
            }
            SearchText = "loading..";
            ActivityIndy = true;
            if(WordToSearch != null) {
                //
                try
                {
                    Word wordObj = await ApiServices.ServiceClientInstance.SearchForWordAsync(WordToSearch);
                    WordDef = "DEFINITION: " + wordObj.results[0].lexicalEntries[0].entries[0].senses[0].definitions[0];
                }
                catch(Exception e)
                {
                    WordDef = "Word not found";
                }
                ActivityIndy = false;
                SearchText = "Search";
    
            }
      
            
        }


    }
}
