using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Base.ViewModels
{
    using Models;
    using Services;
    using Xamarin.Forms;

    class BasesViewModel : BaseViewModel
    {
        
        #region Attributes
        private ObservableCollection<Base> bases;
        private bool isRefreshing;
        private string filter;
        #endregion

        #region Services
        private ApiService apiService;
        #endregion
        #region Properties
        public ObservableCollection<Base> Bases
        {
            get { return bases; }
            set { SetValue(ref bases, value); }
        }

        #endregion

        #region Contructors
        public BasesViewModel() {
            this.apiService = new ApiService();
            this.LoadBases();
        }
        #endregion

        #region Methods
        public async void LoadBases()
        {

            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess) {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   connection.Message,
                   "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }


            var response = await this.apiService.GetList<Base>(
                "http://restcountries.eu",
                "/rest",
                "/v2/all");
            if (!response.IsSuccess) {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Menssage,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
            var list = (List<Base>)response.Result;
            this.Bases = new  ObservableCollection<Base>(list);
        }
        #endregion


    }
}
