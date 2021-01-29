using ResizetizerNT_svg_log_issue.Services;
using ResizetizerNT_svg_log_issue.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResizetizerNT_svg_log_issue
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
