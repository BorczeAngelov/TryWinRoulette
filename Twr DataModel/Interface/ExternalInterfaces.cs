using System.Collections.Generic;

namespace TryWinRoulette.Engine.Interface
{
    public interface IRouletteRolls : IReadOnlyList<IRollTemplate>
    {
        int MaxValue { get; }
        IRollTemplatesPool RollTemplatesPool { get; }

        IRollTemplate CurrentRoll { get; }
        IRollTemplate MoveToNext();
        IRollTemplate MoveToPrevious();
        IRollTemplate JumpTo(int index);
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

    public enum RouletteStyle
    {
        European,
        American
    }
}
