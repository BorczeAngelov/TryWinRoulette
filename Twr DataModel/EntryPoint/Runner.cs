using TryWinRoulette.DataModel.Component;
using TryWinRoulette.DataModel.Interface;

namespace TryWinRoulette.DataModel.EntryPoint
{
    public class Runner
    {
        public IRouletteRolls GenerateRolls(int maxNumber, ulong rolls)
        {
            var randomGenerator = new RandomGenerator();
            

            var rouletteRolls = randomGenerator.GenerateRouletteRolls(maxNumber, rolls);
            return rouletteRolls;
        }
                
        public IBasicStatistics AnaliseRools(IRouletteRolls rouletteRolls)
        {
            var statistic = new StatisticGenerator().Analise(rouletteRolls);
            return statistic;
        }
    }
}
