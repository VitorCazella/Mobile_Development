using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FreeTesting.Services;
using FreeTesting.Views;

namespace FreeTesting
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
            Console.WriteLine("App ready!");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("A mimir");
        }

        protected override void OnResume()
        {
            Console.WriteLine("And we are back!");
        }
    }
}
