using FestCompanion.Services;
using FestCompanion.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FestCompanion.Models;

namespace FestCompanion
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            // Populate the data storage with stage info
            LoadData();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void LoadData()
        {
            Concert concert1 = new Concert() { Artist = "Pink Floyd", Description = "Cool band", When = "17, Thursday 20:00-22:00" };
            Concert concert2 = new Concert() { Artist = "Led Zeppelin", Description = "Das zepppeling", When = "22, Monday 20:00-22:00" };
            Concert concert3 = new Concert() { Artist = "The boyz", Description = "Cam gey csf", When = "18, Sunday 20:00-22:00" };

            Stage stage1 = new Stage()
            {
                Text = "Main stage",
                Description = "Biggest baddest stage ever",
                Concerts = new Concert[] { concert1, concert2 },
                Photo = "https://business-review.eu/wp-content/uploads/2019/11/untold-fest.jpg",
                Lat = "45.778868",
                Lng = "21.265679"
            };

            Stage stage2 = new Stage()
            {
                Text = "Small stage",
                Description = "Smaller stage din pacate",
                Concerts = new Concert[] { concert3 },
                Photo = "https://business-review.eu/wp-content/uploads/2019/11/untold-fest.jpg",
                Lat = "45.778045",
                Lng = "21.264810"
            };

            Stage stage3 = new Stage()
            {
                Text = "Toalete",
                Description = "Unde facem pisu si caca",
                Concerts = new Concert[] { },
                Photo = "https://business-review.eu/wp-content/uploads/2019/11/untold-fest.jpg",
                Lat = "45.778315",
                Lng = "21.266698"
            };

            FestData.stages.Add(stage1);
            FestData.stages.Add(stage2);
            FestData.stages.Add(stage3);
        }
    }
}
