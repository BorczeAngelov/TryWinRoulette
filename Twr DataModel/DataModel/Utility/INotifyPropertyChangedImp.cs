using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TryWinRoulette.Engine.DataModel.Utility
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
