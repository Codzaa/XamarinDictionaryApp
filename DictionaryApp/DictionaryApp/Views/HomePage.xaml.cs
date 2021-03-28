using DictionaryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DictionaryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //When the Page Appears or comes into view
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //
            var vm = BindingContext as HomePageViewModel;
            //
            vm.OnAppearing();
        }
    }
}