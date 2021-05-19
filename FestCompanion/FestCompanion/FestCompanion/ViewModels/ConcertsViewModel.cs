using FestCompanion.Models;
using FestCompanion.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FestCompanion.ViewModels
{
    public class ConcertsViewModel : BaseViewModel
    {
        public ObservableCollection<Concert> Concerts { get; private set; }

        public ConcertsViewModel()
        {
            Title = "Concerts";
            Concerts = new ObservableCollection<Concert>();

            foreach (Stage stage in FestData.stages)
            {
                foreach (Concert concert in stage.Concerts)
                {
                    Concerts.Add(concert);
                }
            }
        }
    }
}