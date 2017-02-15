using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ApplicationBase.Base
{
    public class AViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void SetAndRaisePropertyChanged<T>(ref T oldValue, T newValue, [CallerMemberName]string propertyName = "")
        {
            if (!oldValue.Equals(newValue))
            {
                oldValue = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
