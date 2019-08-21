using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface IGameController
    {
        void PlayTicTacToe();
        string Difficulty { get; }
    }

    public class GameController : IGameController
    {

        private readonly IGameDisplay gameDisplay;
        public string Difficulty { get; private set; }

        public GameController() { }

        public GameController(IGameDisplay gameDisplay)
        {
            this.gameDisplay = gameDisplay;
        }

        public void PlayTicTacToe()
        {
            WelcomePlayerWithGameDisplay();
            SelectDifficulty();
        }

        private void SelectDifficulty()
        {
            string chosenDifficulty = gameDisplay.GetPlayerInput("Please select a difficulty " +
                "\r\n 1) Easy");

            Difficulty = chosenDifficulty;
        }

        private void WelcomePlayerWithGameDisplay()
        {
            gameDisplay.Display("Welcome to Tic Tac Toe!");
        }
    }
}
