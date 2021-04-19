using NUnit.Framework;


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

        [Test]
        public void TestOneSpare()
        {
            Setup();
            RollSpare();
            game.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, game.Score());
        }

        [Test]
        public void TestOneStrike()
        {
            Setup();
            RollStrike();
            game.Roll(3);
            game.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, game.Score());
        }

        [Test]
        public void TestPerfectGame()
        {
            Setup();
            RollMany(12,10);
            Assert.AreEqual(300, game.Score());
        }



    #region Private Methods

    private void Setup()
        {
            game = new Game();
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);
            }
        }

        private void RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
        }

        private void RollStrike()
        {
            game.Roll(10);
        }

        #endregion
    }
}
