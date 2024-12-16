using MyCosmetics.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyCosmetics.Views
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