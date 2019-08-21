//Welcomes player via display
//Asks player to choose a difficulty
    //sets difficulty
//Displays game board
//Lets player go first
//asks them to select a square
//checks if there are winners
    //if true, chooses winner
//displays gameboard with chosen square
//computer selects
//check if there are winners
    //if true chooses winner
//rinse repeat
//after a player wins, displays winning row
//goes back to difficulty selection


using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.StartTicTacToe();
        }

        public void StartTicTacToe()
        {
            IGameController gameController = new GameController(new ConsoleGameDisplay());
            gameController.PlayTicTacToe();
        }
    }
}
