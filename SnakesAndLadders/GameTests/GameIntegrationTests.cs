
// Attempted an integration test as this would be the best way to test the overall game.
// Ran into issues with a way, without mocking, to ensure it would complete in a certain amount of
// turns. 

//using System;
//using System.Threading;
//using NSubstitute;
//using NUnit.Framework;
//using Should;
//using SnakesAndLadders.Game.Entities;

//namespace SnakesAndLadders.GameTests
//{
//    public class GameIntegrationTests
//    {
//        private SnakesAndLaddersBoard _gameBoard;
//        private Player _player;
//        private Dice _dice;
//        private Game.Entities.Game _game;

//        [SetUp]
//        public void SetUp()
//        {
//            _dice = new Dice();
//            _gameBoard = new SnakesAndLaddersBoard();
//            _player = new Player(_dice, 1, 100);
//            _game = new Game.Entities.Game(_gameBoard, _player);
//        }

//        [Test]
//        public void GameShouldBeAbleToEnd()
//        {
//            var timeSpan = new TimeSpan(0, 0, 0, 30, 0);
//            int elapsed = 0;

//            while (_player.CurrentSquare < _player.EndingSquare && elapsed < timeSpan.TotalMilliseconds)
//            {
//                Thread.Sleep(1000);
//                elapsed += 1000;
//                _game.TakeTurn();
//            }
//            _game.gameOver.ShouldBeTrue();
//        }


//    }

//}
