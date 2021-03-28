using DictionaryApp.Models;
using DictionaryApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DictionaryApp.ViewModels
{
    public class TestPageViewModel: INotifyPropertyChanged
    {

        //Constructor
        public Command Btn_Command { get; }
        public TestPageViewModel()
        {
            //
            Btn_Command = new Command(testFunction);
        }
        //
       
        public string tempText;
        public string TempText
        {
            get => tempText;
            set
            {
                if(value == tempText) { return; }
                tempText = value;
                var args = new PropertyChangedEventArgs(nameof(TempText));
                PropertyChanged?.Invoke(this, args);
            }
        }
        const string tempFileName = "words/a.json";
        const string localFileName = "Test2.txt";

        public event PropertyChangedEventHandler PropertyChanged;

        //
        public void OnAppearing()
        {
            //IsBusy = true;
            //SelectedItem = null;
            //putStream input = Assets.Open("my_asset.txt");
            TempText = "Eat Rice";
        }

        public async void testFunction()
        {

            Word hero = await ApiServices.ServiceClientInstance.testFunction();
            TempText = hero.results[0].lexicalEntries[0].entries[0].senses[0].definitions[0];
        }
 
    }


 }

    

