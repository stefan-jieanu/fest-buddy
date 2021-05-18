using FestCompanion.Models;
using FestCompanion.Views;
using FestCompanion.ViewModels;
using System;
using System.Collections;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace FestCompanion.Views
{
    public class Place
    {
        public Xamarin.Forms.GoogleMaps.Position position;
        public Xamarin.Forms.Label label;
    }

    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();

            InitMap();
        }

        private void InitMap()
        {
            var pin = new Pin()
            {
                Position = new Xamarin.Forms.Maps.Position(41.892114, 12.482268),
                Label = "Some Pin!",
            };

            pin.MarkerClicked += (sender, e) =>
            {
                OnPinSelected((Pin)sender);
            };

            // Center the map on Festival Location
            Position centerPosition = new Position(45.756935, 21.229367);
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(centerPosition, Distance.FromKilometers(2)));


            MyMap.Pins.Add(pin);
        }

        async void OnPinSelected(Pin pin)
        {
            if (pin == null)
                return;

            // This will push the StageDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(StageDetailPage)}?{nameof(StageDetailViewModel.Text)}={pin.Label}");
        }
    }
}