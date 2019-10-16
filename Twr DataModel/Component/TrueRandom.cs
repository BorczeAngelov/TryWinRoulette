using System;
using System.Security.Cryptography;

namespace TryWinRoulette.DataModel.Component
{
    internal class TrueRandom : IDisposable
    {
        private readonly RNGCryptoServiceProvider _byteRandomiser = new RNGCryptoServiceProvider();

        public int Next(int inclusiveMaxValue)
        {
            var exclusiveValue = inclusiveMaxValue + 1;
            if (!byte.TryParse(exclusiveValue.ToString(), out byte numberSides))
            {
                throw new ArgumentOutOfRangeException(nameof(inclusiveMaxValue));
            }

            var randomValue = RollDice(numberSides);
            return randomValue - 1;
        }

        #region True random methods from Microsoft
        //https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.rngcryptoserviceprovider?view=netframework-4.8
        private byte RollDice(byte numberSides)
        {
            if (numberSides <= 0)
                throw new ArgumentOutOfRangeException(nameof(numberSides));

            // Create a byte array to hold the random value.
            byte[] randomNumber = new byte[1];
            do
            {
                // Fill the array with a random value.
                _byteRandomiser.GetBytes(randomNumber);
            }
            while (!IsFairRoll(randomNumber[0], numberSides));
            // Return the random number mod the number
            // of sides.  The possible values are zero-
            // based, so we add one.
            return (byte)((randomNumber[0] % numberSides) + 1);
        }

        private bool IsFairRoll(byte roll, byte numSides)
        {
            // There are MaxValue / numSides full sets of numbers that can come up
            // in a single byte.  For instance, if we have a 6 sided die, there are
            // 42 full sets of 1-6 that come up.  The 43rd set is incomplete.
            int fullSetsOfValues = Byte.MaxValue / numSides;

            // If the roll is within this range of fair values, then we let it continue.
            // In the 6 sided die case, a roll between 0 and 251 is allowed.  (We use
            // < rather than <= since the = portion allows through an extra 0 value).
            // 252 through 255 would provide an extra 0, 1, 2, 3 so they are not fair
            // to use.
            return roll < numSides * fullSetsOfValues;
        }
        #endregion

        public void Dispose()
        {
            _byteRandomiser.Dispose();
        }
    }
}
