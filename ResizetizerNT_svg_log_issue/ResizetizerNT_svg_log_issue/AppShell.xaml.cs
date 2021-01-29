using ResizetizerNT_svg_log_issue.ViewModels;
using ResizetizerNT_svg_log_issue.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ResizetizerNT_svg_log_issue
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
