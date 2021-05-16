using FlordeDestino.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FlordeDestino.Views
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