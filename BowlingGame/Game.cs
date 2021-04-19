﻿using System;
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
                if (rolls[frameIndex] +
                    rolls[frameIndex + 1] == 10) // spare
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
    }
}
