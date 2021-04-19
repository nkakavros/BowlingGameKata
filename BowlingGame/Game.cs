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

        private int[] rolls = new int[21];
        private int currentRoll = 0;


        #endregion

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[frameIndex] == 10) // strike
                {
                    score += 10 +
                             rolls[frameIndex + 1] +
                             rolls[frameIndex + 2];
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += rolls[frameIndex] +
                             rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }

        #region Private Methods

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] +
                   rolls[frameIndex + 1] == 10;
        }

        #endregion
    }
}
