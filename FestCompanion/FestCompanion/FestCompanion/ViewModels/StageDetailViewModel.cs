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

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
    }
}
