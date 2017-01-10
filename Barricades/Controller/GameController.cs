using Barricades.Model;
using Barricades.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Controller
{
    class GameController
    {
        private Game game { get; set; }

        private InputView inputView { get; set; }

        private OutputView outputView { get; set; }

        public GameController(InputView inputView, OutputView outputView)
        {
            this.inputView = inputView;
            this.outputView = outputView;
        }

        public void startGame()
        {
            game = new Game();
            game.startGame();
            playGame();
        }

        private void playGame()
        {
            while (!game.gameOver())
            {
                game.playTurn();
                outputView.printBoard(game.board.Squares);
                Console.ReadKey();
            }
        }
    }
}
