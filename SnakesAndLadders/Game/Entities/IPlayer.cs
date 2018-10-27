namespace SnakesAndLadders.Game.Entities
{
    public interface IPlayer
    {
        void TakeTurn();
        int GetCurrentLocation();
    }
}
