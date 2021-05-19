using FestCompanion.Models;
using FestCompanion.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FestCompanion.ViewModels
{
    public class FavoritesViewModel : BaseViewModel
    {
        public List<Concert> Concerts { get; private set; }

        public FavoritesViewModel()
        {
            Title = "Favorites";
            Concerts = FestData.favorites;
        }
    }
}