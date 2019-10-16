using TryWinRoulette.DataModel.Interface;
using TryWinRoulette.DataModel.Model;

namespace TryWinRoulette.DataModel.Component
{
    class RandomGenerator
    {
        internal IRouletteRolls GenerateRouletteRolls(int maxValue, ulong rolls)
        {
            var rollUnitsPool = new RollTemplatesPool(maxValue);
            var rouletteRolls = new RouletteRolls(rollUnitsPool);

            var dotNetRandom = new TrueRandom();
            for (ulong i = 0; i < rolls; i++)
            {
                var randomNumber = dotNetRandom.Next(maxValue);
                rouletteRolls.Add(randomNumber);
            }
            return rouletteRolls;
        }
    }
}
