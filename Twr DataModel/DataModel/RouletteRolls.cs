using System.Collections.Generic;
using TryWinRoulette.Engine.Interface;

namespace TryWinRoulette.Engine.DataModel
{
    internal class RouletteRolls : List<IRollTemplate>, IRouletteRolls
    {
        public IRollTemplatesPool RollTemplatesPool { get; }

        public int MaxValue { get => RollTemplatesPool.MaxValue; }

        public RouletteRolls(IRollTemplatesPool rollTemplatesPool)
        {
            RollTemplatesPool = rollTemplatesPool;
        }

        internal void Add(int randomNumber)
        {
            var rollUnit = RollTemplatesPool[randomNumber];
            Add(rollUnit);
        }
    }
}
