using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BowlingGame
{
    public class Game
    {

        #region Private Members

        private int[] knockedDownPins = new int[21];
        private int rollCounter = 0;

        #endregion

        public void Roll(int pins)
        {
            if (pins == 10)
            {
                rollCounter++;
            }
            knockedDownPins[rollCounter++] = pins;
        }

        public int Score()
        {
            int totalScore = 0;
            for (int i = 0; i < knockedDownPins.Length; i++)
            {
                if (knockedDownPins[i] == 10)
                {
                    totalScore += knockedDownPins[i + 1] + knockedDownPins[i + 2];
                }
                else if (i > 0 && i % 2 == 1)
                {
                    int frameScore = knockedDownPins[i] + knockedDownPins[i - 1];
                    if (frameScore == 10)
                    {
                        totalScore += knockedDownPins[i + 1];
                    }
                }
                totalScore += knockedDownPins[i];
            }
            return totalScore;
        }
    }
}
