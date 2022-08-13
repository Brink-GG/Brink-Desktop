using BrinkDesktop.Services;
using BrinkDesktop.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrinkDesktop
{
    public partial class App : Application
    {

        public App() {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
