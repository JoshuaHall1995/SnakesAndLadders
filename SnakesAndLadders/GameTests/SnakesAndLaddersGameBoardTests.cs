using NUnit.Framework;
using Should;
using SnakesAndLadders.Game.Entities;

namespace SnakesAndLadders.GameTests
{
    class SnakesAndLaddersGameBoardTests
    {
        private SnakesAndLaddersBoard _gameBoard;

        [SetUp]
        public void SetUp()
        {
            _gameBoard = new SnakesAndLaddersBoard();
        }

        [Test]
        public void ShouldGetGameBoardSize()
        {
            var gameBoardSize = _gameBoard.GetBoardSize();
            gameBoardSize.ShouldEqual(100);
        }
        [Test]
        public void ShouldGetStartingSquare()
        {
            var gameBoardSize = _gameBoard.GetStartingSquare();
            gameBoardSize.ShouldEqual(1);
        }
    }
}
