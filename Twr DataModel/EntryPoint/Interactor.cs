using TryWinRoulette.Engine.Component;
using TryWinRoulette.Engine.Interface;

namespace TryWinRoulette.Engine.Interactor
{
    public class Interactor
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

        public IBetFactory CreateBetFactory()
        {
            return new BetFactory();
        }
    }
}
