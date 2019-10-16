using TryWinRoulette.DataModel.Interface;
using TryWinRoulette.DataModel.Model.Bet.OutsideBet;

namespace TryWinRoulette.DataModel.Component
{
    internal class BetFactory : IBetFactory
    {
        public IBet CreateRedBlack(bool isRed)
        {
            return new RedBlack(isRed);
        }
    }
}