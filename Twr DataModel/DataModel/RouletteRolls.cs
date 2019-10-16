using System;
using System.Collections.Generic;
using TryWinRoulette.Engine.Interface;

namespace TryWinRoulette.Engine.DataModel
{
    internal class RouletteRolls : List<IRollTemplate>, IRouletteRolls
    {
        public IRollTemplatesPool RollTemplatesPool { get; }

        public int MaxValue { get => RollTemplatesPool.MaxValue; }

        public IRollTemplate CurrentRoll { get; private set; }

        public RouletteRolls(IRollTemplatesPool rollTemplatesPool)
        {
            RollTemplatesPool = rollTemplatesPool;
        }

        internal void Add(int randomNumber)
        {
            var rollUnit = RollTemplatesPool[randomNumber];
            Add(rollUnit);
        }

        public IRollTemplate MoveToNext()
        {
            var nextIndex = IndexOf(CurrentRoll) + 1;
            if (nextIndex >= Count)
            {
                throw new InvalidOperationException();
            }

            CurrentRoll = this[nextIndex];
            return CurrentRoll;
        }

        public IRollTemplate MoveToPrevious()
        {
            var nextIndex = IndexOf(CurrentRoll) - 1;
            if (nextIndex < -1)
            {
                throw new InvalidOperationException();
            }

            CurrentRoll = this[nextIndex];
            return CurrentRoll;
        }

        public IRollTemplate JumpTo(int index)
        {
            if (index < -1 || index >= Count)
            {
                throw new InvalidOperationException();
            }

            CurrentRoll = this[index];
            return CurrentRoll;
        }
    }
}
