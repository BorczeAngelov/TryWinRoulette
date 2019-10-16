using System;
using System.Collections.Generic;
using TryWinRoulette.DataModel.Interface;
using TryWinRoulette.DataModel.Model;

namespace TryWinRoulette.DataModel.Logic
{
    internal class BasicAnalyser : IBasicAnalyser<IRouletteRolls, IBasicStatistics>
    {
        private IRouletteRolls _rouletteRolls;
        private BasicStatistics _basicStatisticUnits;

        public IBasicStatistics Analise(IRouletteRolls rouletteRolls)
        {
            _rouletteRolls = rouletteRolls;
            _basicStatisticUnits = new BasicStatistics(_rouletteRolls.RollTemplatesPool, _rouletteRolls.Count);    

            CountRouletteRolls();

            return _basicStatisticUnits;
        }

        private void CountRouletteRolls()
        {
            foreach (var rollValue in _rouletteRolls)
            {
                _basicStatisticUnits[rollValue.Value].RegisterHit();
            }
            
        }
    }
}
