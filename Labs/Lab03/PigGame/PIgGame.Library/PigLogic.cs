/* Pig game-play logic
 * Written by Brian Bird
 * Original 4/25/15, updated 10/17/17
 */

using System;

namespace PigGame
{
    public class PigLogic
    {
        /*************** fields ********************/

        private const int WINNING_SCORE = 100;
        public const int BAD_NUMBER = 1;

        private Random rand = new Random();
        private int player1Score;
        private int player2Score;
        private int turnPoints;
        private int turn;           // 1 for player2, 2 for player2

        /************** Properties ***************/

        public String Player1Name { get; set; }
        public String Player2Name { get; set; }
        public int Player1Score { get { return player1Score; } }
        public int Player2Score { get { return player2Score; } }
        public int TurnPoints { get { return turnPoints; } }
        public int Turn { get { return turn; } }

        /*************** Constructors *************/

        public PigLogic()
        {
            player1Score = 0;
            player2Score = 0;
            turnPoints = 0;
            turn = 1; // player 1 goes first
        }

        // Use to instantiate an object with the state for a game in progress
        public PigLogic(int p1Score, int p2Score, int tPoints, int t)
        {
            player1Score = p1Score;
            player2Score = p2Score;
            turnPoints = tPoints;
            turn = t;
        }

        /*************** public methods ******************/

        // Start over without creating a new game object
        public void ResetGame()
        {
            player1Score = 0;
            player2Score = 0;
            turnPoints = 0;
            turn = 1;
        }

        // Roll die and update turn points field
        public int RollDie()
        {
            int roll = rand.Next(6) + 1;

            if (roll != BAD_NUMBER)
            {
                turnPoints += roll;
            }
            else
            {
                turnPoints = 0;
            }

            return roll;
        }

        // Get player based on the assumption that player 1 always goes first
        public String GetCurrentPlayer()
        {
            if (turn == 1)
                return Player1Name;
            else
                return Player2Name;
        }


        // toggles the turn number between 1 and 2
        public int ChangeTurn()
        {
            if (turn == 1)
                player1Score += turnPoints;
            else
                player2Score += turnPoints;

            turnPoints = 0;

            turn = turn % 2 + 1;
            return turn;
        }

        // rules for winning:
        // 1. Both players need to have had the same number of turns
        // 2. First player to reach WINNING_SCORE wins
        // 3. If both players have reached WINNING_SCORE 
        //    the one with the higher score wins
        public String CheckForWinner()
        {
            string name = "";

            if (player1Score >= WINNING_SCORE && player2Score >= WINNING_SCORE)
            {
                if (player1Score == player2Score)
                {
                    name = "Tie";
                }
                else if (player1Score > player2Score)
                {
                    name = Player1Name;
                }
                else
                {
                    name = Player2Name;
                }
            }
            else if (player1Score >= WINNING_SCORE)
            {
                name = Player1Name;
            }
            else if (player2Score >= WINNING_SCORE)
            {
                name = Player2Name;
            }

            return name;
        }

        // Automatically play a turn for the current player
        // Returns true if it wants to take another turn
        // We'll keep rolling as long as points for the turn are low (less than 7)
        public bool AiRoll(out int roll)
        {
            roll = RollDie();
            return (turnPoints < 7);
        }
    }
}

