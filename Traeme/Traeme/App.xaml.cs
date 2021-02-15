using System;
using Traeme.Services;
using Traeme.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Traeme
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
