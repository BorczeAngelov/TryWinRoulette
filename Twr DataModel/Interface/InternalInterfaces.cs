namespace TryWinRoulette.Engine.Interface
{
    internal interface IStatisticGenerator<T>
    {
        T Analise(IRouletteRolls rouletteRolls);
    }
}
