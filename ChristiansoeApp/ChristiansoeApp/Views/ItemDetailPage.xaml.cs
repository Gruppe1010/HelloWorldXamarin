using ChristiansoeApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ChristiansoeApp.Views
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