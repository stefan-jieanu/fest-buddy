using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FestCompanion.ViewModels;
using FestCompanion.Models;

namespace FestCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StageDetailPage : ContentPage
    {
        public StageDetailPage()
        {
            InitializeComponent();
            BindingContext = new StageDetailViewModel();
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