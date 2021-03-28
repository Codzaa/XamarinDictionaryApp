using DictionaryApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DictionaryApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}