using System;
using System.Collections.Generic;

namespace TryWinRoulette.DataModel.Interface
{
    internal interface IStatisticGenerator<T>
    {
        T Analise(IRouletteRolls rouletteRolls);
    }
}
