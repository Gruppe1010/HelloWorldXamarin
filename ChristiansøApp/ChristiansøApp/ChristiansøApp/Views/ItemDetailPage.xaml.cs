using ChristiansøApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ChristiansøApp.Views
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