

namespace Base.ViewModels
{
    using Base.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    class LoginViewModel : BaseViewModel
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnable;
        #endregion
        #region Properties
        public String Email
        {
            get { return email; }
            set { SetValue(ref email, value); }
        }

        public String Password
        {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public bool IsRunning
        {
            get { return isRunning; }
            set { SetValue(ref isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return isEnable; }
            set { SetValue(ref isEnable, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }

        }



        private async void Login()
        {
            if (String.IsNullOrEmpty(this.Email))
            {

                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter your email.",
                    "Accept");
                return;
            }
            if (String.IsNullOrEmpty(this.Password))
            {

                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter your password.",
                    "Accept");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;
            if (this.Email != "m" || this.Password != "asdf")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or Password is incorrect",
                    "Accept");
                this.Password = String.Empty;
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                   "Ok",
                   "Ready",
                   "Accept");

            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = String.Empty;
            this.Password = String.Empty;


            MainViewModel.GetInstance().Bases = new BasesViewModel(); 
            await Application.Current.MainPage.Navigation.PushAsync(new BasesPage());
        }
        #endregion

        #region Contructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;
            this.Email = "m";
            this.Password="asdf";

            // http://restcountries.eu/rest/v2/all
        }
        #endregion
    }
}
