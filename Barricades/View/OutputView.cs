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
            //string boardString = "";
            //int yPos = 0;
            //foreach (var square in squares)
            //{
            //    if (square.y > yPos)
            //    {
            //        boardString += Environment.NewLine;
            //        yPos++;
            //    }
            //    boardString += square.Character;
            //}
            //Console.WriteLine(boardString);

			for(int y = 9; y > -1; y--)
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
    }
}
