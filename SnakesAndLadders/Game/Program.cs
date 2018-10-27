using System;
using SnakesAndLadders.Game.Entities;

namespace SnakesAndLadders.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var dice = new Dice();
            var gameBoard = new SnakesAndLaddersBoard();
            var player = new Player(dice, 
                gameBoard.GetStartingSquare(), gameBoard.GetBoardSize());
            var game = new Entities.Game(gameBoard, player);

            Console.WriteLine("Welcome to Snakes and ladders.\nPress any key to begin.");
            Console.ReadKey();

            while (game.gameOver == false)
            {
                var previousPlayerSquare = player.CurrentSquare;
                Console.WriteLine($"You are {player.CurrentSquare} and want to be {player.EndingSquare}.");
                game.TakeTurn();

                if (player.CurrentSquare - previousPlayerSquare > 0)
                    Console.WriteLine($"You rolled {player.CurrentSquare - previousPlayerSquare}.");

                if (player.CurrentSquare - previousPlayerSquare == 0)
                    Console.WriteLine($"You rolled too high.");

                Console.WriteLine("Press any key to roll again.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Congratulations, you won.");
            Console.ReadKey();
        }
    }
}
