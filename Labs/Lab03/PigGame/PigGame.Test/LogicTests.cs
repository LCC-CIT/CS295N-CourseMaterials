using System;
using Xunit;

namespace PigGame.Test
{
    public class LogicTests
    {
        const string PLAYER1 = "Winnie";
        const string PLAYER2 = "Sam";
        PigLogic game;

        public LogicTests()
        {
            // Arrange (initialization)
            game = new PigLogic();
            game.Player1Name = PLAYER1;
            game.Player2Name = PLAYER2;
        }


        [Fact]
        public void GetCurrentPlayer1Test()
        {
            // Act (execute the method under test)
            string player = game.GetCurrentPlayer();

            // Assert (check the result)
            Assert.Equal(PLAYER1, player);
        }

        [Fact]
        public void GetCurrentPlayer2Test()
        {
            // Arrange
            game.ChangeTurn();

            // Act (execute the method under test)
            string player = game.GetCurrentPlayer();

            // Assert (check the result)
            Assert.Equal(PLAYER2, player);
        }

    }
}
