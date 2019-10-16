using System.ComponentModel;
using TryWinRoulette.Engine.Interactor;
using TryWinRoulette.Engine.Interface;

namespace Twr_Windows_UI
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Interactor _interactor;
        private readonly IBetFactory _betFactory;

        private IRouletteRolls _rouletteRolls;
        private IBasicStatistics _basicStatistics;

        public MainWindowVM()
        {
            _interactor = new Interactor();
            _betFactory = _interactor.CreateBetFactory();
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
            RouletteRolls = _interactor.GenerateRolls(maxNumber, RollsToBeGenerated);
        }

        internal void GenerateBasicStatistics()
        {
            BasicStatistics = _interactor.AnaliseRools(RouletteRolls);
            BetDemo();
        }

        private void BetDemo()
        {
            var redBet = _betFactory.CreateRedBlack(isRed: true);
            redBet.Chips = 100;

            IRollTemplate input = RouletteRolls[0];
            var isW = redBet.IsWin(input);
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
