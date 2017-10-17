/* Console version of pig game
 * Written by Brian Bird
 * Original 10/9/17, updated 10/17/17
 */

using System;

namespace PigGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduce the game
            Console.WriteLine("Hello, You will be playing Pig against the machine.");
            Console.Write("Please enter your name:");
            string player = Console.ReadLine();

            // Set up the game object
            var game = new PigLogic();
            game.Player1Name = player;
            game.Player2Name = "Machine";

            // Game-play loop
            bool done = false;
            do
            {
                // Human player's turn
                Console.WriteLine(game.GetCurrentPlayer() + "'s turn");
                string go = "yes";
                int roll = 0;
                // loop for human to roll die
                while (go == "yes" || go == "y")
                {
                    roll = game.RollDie();
                    Console.WriteLine(" Roll: " + roll + ", Turn: " + game.TurnPoints);
                    if (roll == PigLogic.BAD_NUMBER)
                        break;
                    Console.Write("Do you want to roll the die again? (yes or no)");
                    go = Console.ReadLine().ToLower();
                }

                game.ChangeTurn();
                // Machine's turn
                Console.WriteLine(game.GetCurrentPlayer() + "'s turn");
                bool keepRolling = true;
                do
                {
                    keepRolling = game.AiRoll(out roll);
                    Console.WriteLine(" Roll: " + roll + ", Turn: " + game.TurnPoints);
                } while (keepRolling && roll == PigLogic.BAD_NUMBER);

                game.ChangeTurn();

                Console.WriteLine("----------------------");
                Console.WriteLine(game.Player1Name + "'s score: " + game.Player1Score);
                Console.WriteLine(game.Player2Name + "'s score: " + game.Player2Score);
                Console.WriteLine("----------------------");

                string winner = game.CheckForWinner();
                if (winner != "")
                {
                    Console.WriteLine("The winner is: " + winner);
                    done = true;
                }

            } while (!done);

        }
    }
}
