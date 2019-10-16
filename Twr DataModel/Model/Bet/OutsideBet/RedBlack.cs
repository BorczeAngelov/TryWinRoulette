using TryWinRoulette.DataModel.Interface;
using TryWinRoulette.DataModel.Model.Utility;

namespace TryWinRoulette.DataModel.Model.Bet.OutsideBet
{
    class RedBlack : INotifyPropertyChangedImp, IBet
    {
        private readonly bool isRed;
        private int _chips;

        public RedBlack(bool isRed)
        {
            this.isRed = isRed;
        }

        public int Chips
        {
            get => _chips;
            set
            {
                if (_chips != value)
                {
                    _chips = value;
                    OnPropertyChanged();
                }
            }
        }

        public int PossibleReturn => PossibleReturn + Chips;

        public int PossibleProfit => Chips;

        public bool IsWin(IRollTemplate input)
        {
            return input.Color == RollColor.Red;
        }
    }
}
