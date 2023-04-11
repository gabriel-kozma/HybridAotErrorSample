using System.ComponentModel;
using Xamarin.Forms;
using HybridAotSample.ViewModels;

namespace HybridAotSample.Views
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
