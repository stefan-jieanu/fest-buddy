using FestCompanion.Models;
using System;
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
            foreach (Stage stage in TempUserStorage.stages)
            {
                if (stage.Text == value)
                {
                    Description = stage.Description;
                    Photo = new Uri(stage.Photo);
                    break;
                }
            }
        }
    }
}
