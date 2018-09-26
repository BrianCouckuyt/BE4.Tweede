using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Tweede
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Debug.WriteLine($"{DateTime.Now} - App meets world");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine($"{DateTime.Now} - zzZzzZzz");
        }

        protected override void OnResume()
        {
            Debug.WriteLine($"{DateTime.Now} - Wake up");
        }
    }
}
