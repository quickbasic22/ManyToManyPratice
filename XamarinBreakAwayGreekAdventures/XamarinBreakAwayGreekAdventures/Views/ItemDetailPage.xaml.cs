using System.ComponentModel;
using Xamarin.Forms;
using XamarinBreakAwayGreekAdventures.ViewModels;

namespace XamarinBreakAwayGreekAdventures.Views
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