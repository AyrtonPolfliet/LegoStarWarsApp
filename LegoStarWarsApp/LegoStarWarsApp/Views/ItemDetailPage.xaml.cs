using LegoStarWarsApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LegoStarWarsApp.Views
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