using TryWinRoulette.DataModel.Interface;

namespace TryWinRoulette.DataModel.Component
{
    internal class StatisticGenerator : IStatisticGenerator<IBasicStatistics>
    {
        public IBasicStatistics Analise(IRouletteRolls rouletteRolls)
        {
            var basicAnalyser = new BasicAnalyser();
            //Add more analzsers
            var basicStatistics = basicAnalyser.Analise(rouletteRolls);

            return basicStatistics;
        }
    }
}
