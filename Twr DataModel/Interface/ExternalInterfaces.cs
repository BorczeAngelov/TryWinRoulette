using System.Collections.Generic;
using System.ComponentModel;

namespace TryWinRoulette.Engine.Interface
{
    public interface IRouletteRolls : IReadOnlyList<IRollTemplate>
    {
        int MaxValue { get; }
        IRollTemplatesPool RollTemplatesPool { get; }
    }

    public interface IBasicAnalyser<Input, Output>
    {
        Output Analise(Input input);
    }

    public interface IStatistic
    {

    }

    public interface IBasicStatistics : IReadOnlyList<IBasicStatisticUnit>, IStatistic
    {

    }

    public interface IBasicStatisticUnit //Ke treba da dodades i INPF za live updates
    {
        IRollTemplate RollTemplate { get; }
        int Hits { get; }
        double Probability { get; }
        void RegisterHit();
    }

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

    public enum RouletteStyle
    {
        European,
        American
    }
}
