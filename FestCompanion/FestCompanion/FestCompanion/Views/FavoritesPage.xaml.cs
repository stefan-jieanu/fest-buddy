using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestCompanion.ViewModels;
using FestCompanion.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FestCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritesPage : ContentPage
    {
        public FavoritesPage()
        {
            InitializeComponent();
            BindingContext = new FavoritesViewModel();
        }

        void RemoveFromFav(object sender, EventArgs args)
        {
            Button btn = sender as Button;

            foreach (Concert concert in FestData.favorites)
            {
                if (btn.Text.CompareTo(concert.Artist) == 0)
                {
                    if (FestData.favorites.Contains(concert))
                    {
                        FestData.favorites.Remove(concert);
                        break;
                    }
                }
            }
        }
    }
}