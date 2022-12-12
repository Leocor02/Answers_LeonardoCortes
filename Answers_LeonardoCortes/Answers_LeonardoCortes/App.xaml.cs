using Answers_LeonardoCortes.Services;
using Answers_LeonardoCortes.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Answers_LeonardoCortes
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new NavigationPage(new WelcomePage());
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
