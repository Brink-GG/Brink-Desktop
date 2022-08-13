using BrinkDesktop.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BrinkDesktop.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage() {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}