using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Base
{
    using Views;
    public partial class App : Application
    {
        #region Contructors
        public App()
        {
            InitializeComponent();

            this.MainPage = new LoginPage();
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
