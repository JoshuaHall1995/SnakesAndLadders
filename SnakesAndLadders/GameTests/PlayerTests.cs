using NSubstitute;
using NUnit.Framework;
using Should;
using SnakesAndLadders.Game.Entities;

namespace SnakesAndLadders.GameTests
{
    class PlayerTests
    {
        private Player _player;
        private IDice _dice;

        [SetUp]
        public void SetUp()
        {
            _dice = Substitute.For<IDice>();
            _player = new Player(_dice, 1, 100);
        }

        [Test]
        public void GivenADiceRoll_ThePlayerMovesThatManySpaces()
        {
            _dice.DiceRoll().Returns(1);

            var startingPosition = _player.CurrentSquare;
            _player.TakeTurn();
            var endPosition = _player.CurrentSquare;
            endPosition.ShouldEqual(startingPosition + 1);
        }

        [Test]
        public void GivenAPlayersRollWillGoOffTheBoard_TheRollIsNegated()
        {
            _dice.DiceRoll().Returns(4);
            var expectedSquare = _player.EndingSquare - 3;
            _player.CurrentSquare = expectedSquare;
            _player.TakeTurn();
            _player.CurrentSquare.ShouldEqual(expectedSquare);
        }

        [Test]
        public void ShouldReturnPlayersCurrentSquare()
        {
            _player.CurrentSquare = 1;
            var currentLocation = _player.GetCurrentLocation();
            _player.CurrentSquare.ShouldEqual(currentLocation);
        }
    }
}
