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
    
    public partial class TestPage : ContentPage
    {
        //TestPageViewModel _viewModel;
        public TestPage()
        {
            InitializeComponent();
            //
            //BindingContext = _viewModel = new TestPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //
            var vm = BindingContext as TestPageViewModel;
            //
            vm.OnAppearing();
        }
    }
}