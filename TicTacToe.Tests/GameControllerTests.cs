using System;
using Xunit;
using FluentAssertions;
using Moq;

namespace TicTacToe.Tests
{
    public class GameControllerTests
    {
        [Fact]
        public void ShouldWelcomePlayerWhenGameIsStarted()
        {
            //arrange
            Mock<IGameDisplay> gameDisplay = new Mock<IGameDisplay>();
            gameDisplay.Setup(x => x.Display("Welcome to Tic Tac Toe!")).Verifiable();

            IGameController gameController = new GameController(gameDisplay.Object);

            //act
            gameController.PlayTicTacToe();

            //assert
            gameDisplay.Verify();
        }

        [Fact]
        public void ShouldLetPlayerChooseADifficulty()
        {
            //arrange
            const string Value = "Easy";
            Mock<IGameDisplay> gameDisplay = new Mock<IGameDisplay>();
            gameDisplay.Setup(x => x.Display("Welcome to Tic Tac Toe!")).Verifiable();            
            gameDisplay.Setup(x => x.GetPlayerInput(It.IsAny<string>())).Returns(Value);

            IGameController gameController = new GameController(gameDisplay.Object);

            //act
            gameController.PlayTicTacToe();

            //assert
            gameController.Difficulty.Should().Be(Value);
        }
    }
}
