using FestCompanion.Services;
using FestCompanion.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FestCompanion.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace FestCompanion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Task.Delay(1000);

            // Populate the data storage with stage info
            Task.Run(async () => { await LoadData(); }).Wait();

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

        private async Task LoadData()
        {
            Concert concert1 = new Concert() { 
                Artist = "Pink Floyd", 
                Description = "Pink Floyd were an English rock band formed in London in 1965. Gaining an early following as one of the first British psychedelic groups, they were distinguished for their extended compositions, sonic experimentation, philosophical lyrics and elaborate live shows.", 
                When = "17, Thursday 20:00-22:00",
                Photo = "https://static.posters.cz/image/750/postere/pink-floyd-dark-side-i30715.jpg",
            };
            Concert concert2 = new Concert() { 
                Artist = "Rolling Stones",
                Description = "The Rolling Stones are an English rock band formed in London in 1962. Diverging from the pop rock of the early-1960s, the Rolling Stones pioneered the gritty, heavier-driven sound that came to define hard rock.", 
                When = "22, Monday 20:00-22:00",
                Photo = "https://thumbs.dreamstime.com/b/rolling-stones-logo-icon-vector-logos-logo-icons-set-social-media-flat-banner-vectors-svg-eps-jpg-jpeg-emblem-wallpaper-background-208332843.jpg",
            };
            Concert concert3 = new Concert() { 
                Artist = "The Beatles", 
                Description = "The Beatles were an English rock band formed in Liverpool in 1960. The group, whose best-known line-up comprised John Lennon, Paul McCartney, George Harrison and Ringo Starr, are regarded as the most influential band of all time.", 
                When = "18, Sunday 20:00-22:00",
                Photo = "https://i.pinimg.com/originals/7b/2a/1e/7b2a1e7ba8798706cf07fb7fdd140408.png",
            };

            Stage stage1 = new Stage()
            {
                Text = "Main stage",
                Description = "Biggest stage at this event. The main events will take place here.",
                Concerts = new Concert[] { concert1, concert2 },
                Photo = "https://business-review.eu/wp-content/uploads/2019/11/untold-fest.jpg",
                Lat = "45.778868",
                Lng = "21.265679"
            };

            Stage stage2 = new Stage()
            {
                Text = "Small stage",
                Description = "This is a more chill stage for people who want to chill",
                Concerts = new Concert[] { concert3 },
                Photo = "https://media.socastsrm.com/wordpress/wp-content/blogs.dir/2311/files/2019/04/SOURCE-SquamishM03.jpg",
                Lat = "45.778045",
                Lng = "21.264810"
            };

            Stage stage3 = new Stage()
            {
                Text = "Toilets",
                Description = "Best place to empty your bladder",
                Concerts = new Concert[] { },
                Photo = "https://affordapotty.com/wp-content/uploads/2019/09/line-of-portable-toilets-1024x604.jpeg",
                Lat = "45.778315",
                Lng = "21.266698"
            };

            //HttpClient client = new HttpClient();
            //Uri uri = new Uri("http://192.168.100.9:3000/");

            //HttpResponseMessage response = await client.GetAsync(uri);
            //if (response.IsSuccessStatusCode)
            //{
            //    stage1.Description = response.Content.ReadAsStringAsync().Result;
            //}

            FestData.stages.Add(stage1);
            FestData.stages.Add(stage2);
            FestData.stages.Add(stage3);
        }
    }
}
