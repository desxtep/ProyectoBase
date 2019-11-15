

namespace Base.ViewModels
{
    using System;
    using System.Windows.Input;
    class LoginViewModel
    {
        #region Properties
        public String Email {
            get;
            set;
        }

        public String Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get;
            set;
        }
        #endregion

        #region Contructors
        public LoginViewModel(){
            this.IsRemembered = true;
        }
        #endregion
    }
}
