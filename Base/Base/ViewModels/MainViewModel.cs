using System;
using System.Collections.Generic;
using System.Text;

namespace Base.ViewModels
{
    class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login {
            get;
            set;
        }

        public BasesViewModel Bases
        {
            get;
            set;
        }
        #endregion

        #region Contructors
        public  MainViewModel() {
            this.Login = new LoginViewModel(); 
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance() {
            if (instance== null) {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
