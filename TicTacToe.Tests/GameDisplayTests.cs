using FluentAssertions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace TicTacToe.Tests
{
    public class GameDisplayTests
    {

        [Fact]
        public void GivenAMessage_ShouldDisplayThatMessage()
        {
            //arrange
            string displayText = "Welcome to Tic Tac Toe";

            IGameDisplay gameDisplay = new ConsoleGameDisplay();

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            gameDisplay.Display(displayText);


            //assert
            stringWriter.ToString().Should().Be(displayText);

            //cleanup
            stringWriter.Dispose();
        }

        [Fact]
        public void GivenAPlayerInput_ShouldReturnThatInput()
        {
            //arrange
            const string Expected = "easy";
            const string displayText = "Please select a difficulty";

            IGameDisplay gameDisplay = new ConsoleGameDisplay();

            StringWriter stringWriter = new StringWriter();
            StringReader stringReader = new StringReader(Expected);

            Console.SetOut(stringWriter);
            Console.SetIn(stringReader);

            //act
            string playerInput = gameDisplay.GetPlayerInput(displayText);


            //assert
            playerInput.Should().Be(Expected);

            //cleanup
            stringWriter.Dispose();
        }
    }
}
