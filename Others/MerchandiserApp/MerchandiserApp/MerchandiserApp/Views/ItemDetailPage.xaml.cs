using MerchandiserApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MerchandiserApp.Views
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