using TryWinRoulette.Engine.Interface;

namespace TryWinRoulette.Engine.DataModel
{
    internal class BasicStatisticUnit : IBasicStatisticUnit
    {
        public IRollTemplate RollTemplate { get; }

        private readonly int _rollsCount;

        public int Hits { get; private set; }

        public double Probability { get; private set; }

        public BasicStatisticUnit(
            IRollTemplate rollTemplate,
            int rollsCount)
        {
            RollTemplate = rollTemplate;
            _rollsCount = rollsCount;
        }

        public void RegisterHit()
        {
            Hits++;
            Probability = (double)Hits / _rollsCount * 100;
        }
    }
}
