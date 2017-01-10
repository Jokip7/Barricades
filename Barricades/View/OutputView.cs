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
        private const int DELAY = 0;

        private void printConsoleMessage(string message)
        {
            Console.Write("> ");
            foreach (var letter in message.Trim())
            {
                Console.Write(letter);
                System.Threading.Thread.Sleep(DELAY);
            }

            Console.Write(Environment.NewLine);
        }

        public void printWelcome()
        {
            Console.WriteLine("> =*=* Welkom bij Barricades, speler! *=*=");
            printConsoleMessage("Placeholder informatie voor het spel.");
            printConsoleMessage("Druk op een knop om een spel te beginnen.");
            Console.ReadKey();
        }

        public void printInputError()
        {
            printConsoleMessage("Input niet herkend.");
        }

        public void printBoard(List<Square> squares)
        {
            Console.Clear();
			for(int y = 9; y >= 0; y--)
			{
				String line = "";
				for(int x = 10; x > -1; x--)
				{
					line += (from sq in squares
							 where sq.x == x && sq.y == y
							 select sq).FirstOrDefault().Character;
				}
				Console.WriteLine(line);
			}

        }

        public void printDice(int eyes)
        {
            printConsoleMessage("Je gooit " + eyes);
        }

        public void printPawnRequest(int playerNumber)
        {
            printConsoleMessage("Welke pion wil je verplaatsen, speler " + playerNumber + "?");
        }

        public void printDirectionRequest()
        {
            printConsoleMessage("Welke kant wil je op?");
        }

        public void printEmptyLine()
        {
            Console.WriteLine(Environment.NewLine);
        }

        public void printDeployError()
        {
            printConsoleMessage("Je kan deze pion niet neerzetten");
        }
    }
}
