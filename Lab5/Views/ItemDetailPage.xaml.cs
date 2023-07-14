using Lab5.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab5.Views
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