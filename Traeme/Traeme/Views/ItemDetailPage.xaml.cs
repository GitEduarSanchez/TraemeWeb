using System.ComponentModel;
using Traeme.ViewModels;
using Xamarin.Forms;

namespace Traeme.Views
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