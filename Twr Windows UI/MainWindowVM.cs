using System.ComponentModel;
using TryWinRoulette.DataModel.EntryPoint;
using TryWinRoulette.DataModel.Interface;

namespace Twr_Windows_UI
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Runner _runner;

        private IRouletteRolls _rouletteRolls;
        private IBasicStatistics _basicStatistics;

        public MainWindowVM()
        {
            _runner = new Runner();
        }

        public ulong RollsToBeGenerated { get; set; }

        public IRouletteRolls RouletteRolls
        {
            get => _rouletteRolls;
            private set
            {
                if (_rouletteRolls != value)
                {
                    _rouletteRolls = value;
                    OnPropertyChanged(nameof(RouletteRolls));
                }
            }
        }

        public IBasicStatistics BasicStatistics
        {
            get => _basicStatistics;
            private set
            {
                if (_basicStatistics != value)
                {
                    _basicStatistics = value;
                    OnPropertyChanged(nameof(BasicStatistics));
                }
            }
        }

        internal void GenerateRolls()
        {
            int maxNumber = 36;
            RouletteRolls = _runner.GenerateRolls(maxNumber, RollsToBeGenerated);
        }

        internal void GenerateBasicStatistics()
        {
            BasicStatistics = _runner.AnaliseRools(RouletteRolls);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
