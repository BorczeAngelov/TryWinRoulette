using System.Collections.Generic;
using TryWinRoulette.Engine.Interface;

namespace TryWinRoulette.Engine.DataModel
{
    internal class BasicStatistics : List<IBasicStatisticUnit>, IBasicStatistics
    {
        private readonly IRollTemplatesPool _rollTemplatesPool;

        public BasicStatistics(IRollTemplatesPool rollTemplatesPool, int rollCount)
        {
            _rollTemplatesPool = rollTemplatesPool;

            foreach (var item in _rollTemplatesPool)
            {
                var basicStaticsUnit = new BasicStatisticUnit(item, rollCount);
                Add(basicStaticsUnit);
            }
        }
    }
}
