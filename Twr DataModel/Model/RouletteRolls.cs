using System.Collections.Generic;
using TryWinRoulette.DataModel.Interface;

namespace TryWinRoulette.DataModel.Model
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
