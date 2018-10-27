namespace SnakesAndLadders.Game.Entities
{
    class SnakesAndLaddersBoard: IGameboard
    {
        private int BoardSize;

        public SnakesAndLaddersBoard()
        {
            BoardSize = 100;
        }

        public int GetBoardSize()
        {
            return BoardSize;
        }

        public int GetStartingSquare()
        {
            return 1;
        }
    }
}
