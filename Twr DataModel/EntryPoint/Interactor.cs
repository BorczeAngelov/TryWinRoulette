using TryWinRoulette.Engine.Component;
using TryWinRoulette.Engine.Interface;

namespace TryWinRoulette.Engine.Interactor
{
    public class Interactor
    {
        public IRouletteRolls GenerateRolls(RouletteStyle rouletteStyle, ulong rolls)
        {
            var randomGenerator = new RandomGenerator();           

            var rouletteRolls = randomGenerator.GenerateRouletteRolls(rouletteStyle, rolls);
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
