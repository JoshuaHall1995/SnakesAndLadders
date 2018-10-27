namespace SnakesAndLadders.Game.Entities
{
    public class Player: IPlayer
    {
        public int CurrentSquare, EndingSquare;
        private IDice _dice;

        public Player(IDice dice, int startingSquare, int endSquare)
        {
            _dice = dice;
            CurrentSquare = startingSquare;
            EndingSquare = endSquare;
        }  

        public void TakeTurn()
        {
            var roll = _dice.DiceRoll();
            if (CurrentSquare + roll <= EndingSquare)
            {
                CurrentSquare = CurrentSquare + roll;
            }
        }

        public int GetCurrentLocation()
        {
            return CurrentSquare;
        }
    }
}
