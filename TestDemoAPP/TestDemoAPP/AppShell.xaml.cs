using System;
using System.Collections.Generic;
using TestDemoAPP.ViewModels;
using TestDemoAPP.Views;
using Xamarin.Forms;

namespace TestDemoAPP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DemoTestPage), typeof(DemoTestPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//DemoTestPage");
        }
    }
}
