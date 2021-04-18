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
        }
    }
}
