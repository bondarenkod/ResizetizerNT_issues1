using ResizetizerNT_svg_log_issue.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ResizetizerNT_svg_log_issue.Views
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