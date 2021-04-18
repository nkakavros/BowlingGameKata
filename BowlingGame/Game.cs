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
            return 0;
        }
    }
}
