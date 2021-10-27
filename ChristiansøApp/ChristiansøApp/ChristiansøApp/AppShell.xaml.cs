using ChristiansøApp.ViewModels;
using ChristiansøApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ChristiansøApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
