﻿using NUnit.Framework;


namespace BowlingGame
{
    [TestFixture]
    public class BowlingGameTest
    {

        #region Private Members

        private Game game;

        #endregion

        [Test]
        public void TestGutterGame()
        {
            Setup();
            RollMany(20, 0);
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void TestAllOnes()
        {
            Setup();
            RollMany(20, 1);
            Assert.AreEqual(20, game.Score());
        }

        #region Private Methods

        private void Setup()
        {
            game = new Game();
        }

        private void RollMany(int n, int pins)
        {
            Setup();
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);
            }
        }

        #endregion
    }
}
