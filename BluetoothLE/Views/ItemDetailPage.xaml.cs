using BluetoothLE.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BluetoothLE.Views
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