﻿using TryWinRoulette.DataModel.Interface;

namespace TryWinRoulette.DataModel.Model
{
    internal class RollTemplate : IRollTemplate
    {
        public int Value { get; }

        public RollColor Color { get; }

        public RollTemplate(int value, RollColor rollColor)
        {
            Value = value;
            Color = rollColor;
        }
    }
}
