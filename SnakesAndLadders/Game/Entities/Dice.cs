using System;

namespace SnakesAndLadders.Game.Entities
{
    public class Dice : IDice
    {
        public int DiceRoll()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
