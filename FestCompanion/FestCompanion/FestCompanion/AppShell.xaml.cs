using FestCompanion.ViewModels;
using FestCompanion.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FestCompanion
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(StageDetailPage), typeof(StageDetailPage));
        }

    }
}
