using System;
using System.Collections.Generic;
using System.Text;

namespace Base.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnProperetyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T backingFlied, T value, [CallerMemberName] string propertyName = null) {
            if (EqualityComparer<T>.Default.Equals(backingFlied, value)) {
                return;
            }
            backingFlied = value;
            OnProperetyChanged(propertyName);
        }
    }
}
