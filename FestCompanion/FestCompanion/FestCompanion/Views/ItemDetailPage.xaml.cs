using FestCompanion.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FestCompanion.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}