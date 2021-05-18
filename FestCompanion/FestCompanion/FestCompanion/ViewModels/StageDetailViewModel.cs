using FestCompanion.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FestCompanion.ViewModels
{
    [QueryProperty(nameof(Text), nameof(Text))]
    public class StageDetailViewModel : BaseViewModel
    {
        private string text;
        private string description;
        private Uri photo;
        public ObservableCollection<Concert> Concerts { get; private set; }

        public StageDetailViewModel()
        {
            Concerts = new ObservableCollection<Concert>();
        }

        public string Text
        {
            get => text;
            set
            {
                SetProperty(ref text, value);
                LoadInfo(text);
            }
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Uri Photo
        {
            get => photo;
            set => SetProperty(ref photo, value);
        }

        private void LoadInfo(string value)
        {
            foreach (Stage stage in FestData.stages)
            {
                if (stage.Text == value)
                {
                    Description = stage.Description;
                    Photo = new Uri(stage.Photo);

                    // Populate the concert array with concerts which will take place on this stage
                    foreach (Concert concert in stage.Concerts)
                    {
                        Concerts.Add(concert);
                    }
                    break;
                }
            }
        }
    }
}
