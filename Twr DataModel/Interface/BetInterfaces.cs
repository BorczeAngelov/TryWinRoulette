using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryWinRoulette.Engine.Interface;

namespace TryWinRoulette.Engine.Interface
{
    public interface IBetFactory
    {
        IBet CreateRedBlack(bool isRed);
    }

    public interface ICompleteBet : ICollection<IBet>
    {

    }

    public interface IBet : INotifyPropertyChanged
    {
        int Chips { get; set; }
        int PossibleReturn { get; }
        int PossibleProfit { get; }
        bool IsWin(IRollTemplate input);
    }

    public interface IBetInterpreter
    {
        IRollTemplate LastRoll { get; }
        void MoveToNext();
        void MoveToPrevious();
        void JumpTo(int rollIndex);
    }
}
