using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestCompanion.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FestCompanion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConcertsPage : ContentPage
    {
        public ConcertsPage()
        {
            InitializeComponent();
            BindingContext = new ConcertsViewModel();
        }
    }
}