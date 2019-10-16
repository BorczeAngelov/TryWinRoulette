using System.Collections;
using System.Collections.Generic;
using TryWinRoulette.DataModel.Interface;

namespace TryWinRoulette.DataModel.Model
{
    internal class RollTemplatesPool : IRollTemplatesPool
    {
        private readonly List<IRollTemplate> _rollUnits;

        public int MaxValue { get; }

        public IRollTemplate this[int value]
        {
            get => _rollUnits[value];
        }

        public RollTemplatesPool(int maxValue)
        {
            MaxValue = maxValue;
            _rollUnits = new List<IRollTemplate>();

            for (int i = 0; i <= MaxValue; i++)
            {
                var rollColor = ReturnRollColor(i);
                _rollUnits.Add(new RollTemplate(i, rollColor));
            }
        }

        private RollColor ReturnRollColor(int value)
        {
            var result = RollColor.Black;
            switch (value)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 12:
                case 14:
                case 16:
                case 18:
                case 19:
                case 21:
                case 23:
                case 25:
                case 27:
                case 30:
                case 32:
                case 34:
                case 36:
                    result = RollColor.Red;
                    break;
                case 0:
                    result = RollColor.Green;
                    break;
            }
            return result;
        }

        public IEnumerator<IRollTemplate> GetEnumerator()
        {
            return _rollUnits.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _rollUnits.GetEnumerator();
        }
    }
}
