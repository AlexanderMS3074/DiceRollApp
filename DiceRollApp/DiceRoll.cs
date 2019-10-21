using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace DiceRollApp {
    //                  2 d10 + 5
    class DiceRoll {
        private RNGCryptoServiceProvider rngCSP = new RNGCryptoServiceProvider();

        #region Public Variables
        public int NumberOfDice { set; get; }
        public int NumberOfSides { set; get; }
        public int ModifierAmount { set; get; }
        public char Modifier { set; get; }
        public int FinalResult { set; get; }
        #endregion
        
        bool IsFairRoll(byte roll, byte _numSides) {
            int fullSetsOfValues = byte.MaxValue / _numSides;
            return roll < _numSides * fullSetsOfValues;
        }
        
        int Dice(int _sides) {
            byte numSides = Convert.ToByte(_sides);
            byte[] randomNum = new byte[1];

            do { rngCSP.GetBytes(randomNum); }
            while (!IsFairRoll(randomNum[0], numSides));

            return (randomNum[0] % numSides) + 1;
        }
        
        public void RollDice(int _numberOfDice, int _numberOfSides,
                             char _modifier, int _modifierAmount) {
            //Set Variables
            NumberOfDice = _numberOfDice;
            NumberOfSides = _numberOfSides;
            Modifier = _modifier;
            ModifierAmount = _modifierAmount;

            //Initialize FinalResult to 0 to wipe any previous rolls
            FinalResult = 0;

            //for NumberOfDice roll Dice and add the results to FinalResult
            for (int i = 0; i < NumberOfDice; i++) {
                FinalResult += Dice(NumberOfSides);
            }
            if (Modifier == '+') { FinalResult += ModifierAmount; }
            else { FinalResult -= ModifierAmount; }
        }
    }
}
