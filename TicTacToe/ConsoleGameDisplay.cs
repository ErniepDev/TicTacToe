using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface IGameDisplay
    {
        void Display(string textToDisplay);
        string GetPlayerInput(string displayText);
    }

    public class ConsoleGameDisplay : IGameDisplay
    {
        public void Display(string textToDisplay)
        {
            Console.Write(textToDisplay);
        }

        public string GetPlayerInput(string displayText)
        {
            Console.WriteLine($"{displayText} ");
            return Console.ReadLine();
        }
    }
}
