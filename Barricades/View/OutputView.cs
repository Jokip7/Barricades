using Barricades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.View
{
    class OutputView
    {
        private const int DELAY = 70;

        private void printConsoleMessage(string message)
        {
            Console.Write("> ");
            foreach (var letter in message.Trim())
            {
                Console.Write(letter);
                System.Threading.Thread.Sleep(DELAY);
            }

            Console.WriteLine(Environment.NewLine);
        }

        public void printWelcome()
        {
            printConsoleMessage("Welcome to Barricades, player!");
            printConsoleMessage("Placeholder informatie voor het spel.");
            printConsoleMessage("Druk op een knop om een spel te beginnen.");
            Console.ReadKey();
        }

        public void printInputError()
        {
            printConsoleMessage("Input not recognized.");
        }

        public void printBoard(List<Square> squares)
        {

        }
    }
}
