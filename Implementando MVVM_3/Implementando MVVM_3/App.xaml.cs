using Implementando_MVVM_3.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Implementando_MVVM_3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Menuprincipal());
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
