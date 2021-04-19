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
            int i = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                score += rolls[i] + rolls[i + 1];
                i += 2;
            }
            return score;
        }
    }
}
