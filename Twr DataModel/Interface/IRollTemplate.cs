using System.Collections.Generic;

namespace TryWinRoulette.DataModel.Interface
{
    public interface IRollTemplate
    {
        int Value { get; }
        RollColor Color { get; }
    }

    public interface IRollTemplatesPool : IEnumerable<IRollTemplate>
    {
        int MaxValue { get; }
        IRollTemplate this[int value] { get; }
    }

    public enum RollColor
    {
        Green,
        Red,
        Black
    }    
}
