using TryWinRoulette.Engine.Interface;
using TryWinRoulette.Engine.DataModel;

namespace TryWinRoulette.Engine.Component
{
    class RandomGenerator
    {
        internal IRouletteRolls GenerateRouletteRolls(RouletteStyle rouletteStyle, ulong rolls)
        {
            int maxValue = 36;
            var rollUnitsPool = new RollTemplatesPool(maxValue);
            var rouletteRolls = new RouletteRolls(rollUnitsPool);

            using (var dotNetRandom = new TrueRandom())
            {
                for (ulong i = 0; i < rolls; i++)
                {
                    var randomNumber = dotNetRandom.Next(maxValue);
                    rouletteRolls.Add(randomNumber);
                }
            }
            return rouletteRolls;
        }
    }
}
