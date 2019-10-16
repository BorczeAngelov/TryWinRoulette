using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TryWinRoulette.DataModel.Model.Utility
{
    internal class INotifyPropertyChangedImp : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
