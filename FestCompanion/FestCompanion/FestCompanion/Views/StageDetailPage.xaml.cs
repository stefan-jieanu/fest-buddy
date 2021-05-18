using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FestCompanion.ViewModels;

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
    }
}