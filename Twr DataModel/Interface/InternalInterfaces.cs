namespace TryWinRoulette.DataModel.Interface
{
    internal interface IStatisticGenerator<T>
    {
        T Analise(IRouletteRolls rouletteRolls);
    }
}
