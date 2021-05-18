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
            //var pin = new Pin()
            //{
            //    Position = new Xamarin.Forms.Maps.Position(45.756935, 21.229367),
            //    Label = "Some Pin!",
            //};

            //pin.MarkerClicked += (sender, e) =>
            //{
            //    OnPinSelected((Pin)sender);
            //};

            // Center the map on Festival Location
            Position centerPosition = new Position(45.778457, 21.265486);
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(centerPosition, Distance.FromKilometers(2)));
            
            // Set the pins according to stage locations
            foreach (Stage stage in FestData.stages)
            {
                var pin = new Pin()
                {
                    Position = new Position(Convert.ToDouble(stage.Lat), Convert.ToDouble(stage.Lng)),
                    Label = stage.Text
                };

                pin.MarkerClicked += (sender, e) =>
                {
                    OnPinSelected((Pin)sender);
                };

                MyMap.Pins.Add(pin);
            }
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