

namespace SnakesAndLadders.Game.Entities
{
    public class Game: IGame
    {
        public bool gameOver;
        private IGameboard _gameBoard;
        private IPlayer _player;
        private int boardSize;

        public Game(IGameboard gameBoard, IPlayer player)
        {
            _gameBoard = gameBoard;
            boardSize = _gameBoard.GetBoardSize();
            _player = player;
            gameOver = false;
        }

        public void TakeTurn()
        {
            _player.TakeTurn();
            var playerPosition = _player.GetCurrentLocation();
            if (playerPosition == boardSize)
            {
                gameOver = true;
            }
        }
    }
}
