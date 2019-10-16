using TryWinRoulette.Engine.Interface;
using TryWinRoulette.Engine.DataModel.Bet.OutsideBet;

namespace TryWinRoulette.Engine.Component
{
    internal class BetFactory : IBetFactory
    {
        public IBet CreateRedBlack(bool isRed)
        {
            return new RedBlack(isRed);
        }
    }
}