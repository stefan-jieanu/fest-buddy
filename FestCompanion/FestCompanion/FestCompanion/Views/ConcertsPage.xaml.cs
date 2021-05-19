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
    public partial class ConcertsPage : ContentPage
    {
        public ConcertsPage()
        {
            InitializeComponent();
            BindingContext = new ConcertsViewModel();
        }

        void AddToFav(object sender, EventArgs args)
        {
            Button btn = sender as Button;

            foreach (Stage stage in FestData.stages)
            {
                foreach (Concert concert in stage.Concerts)
                {
                    if (btn.Text.CompareTo(concert.Artist) == 0)
                    {
                        if (!FestData.favorites.Contains(concert))
                            FestData.favorites.Add(concert);
                    }
                }
            }
        }
    }
}