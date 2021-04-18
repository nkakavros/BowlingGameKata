using NUnit.Framework;


namespace BowlingGame
{
    [TestFixture]
    public class BowlingGameTest
    {

        #region Private Members

        private Game NewGame => new Game();

        #endregion

        [Test]
        public void TestGutterGame()
        {
            Game game = NewGame;

            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void TestAllOnes()
        {
            Game game = NewGame;

            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }
            Assert.AreEqual(20, game.Score());
        }
    }
}
