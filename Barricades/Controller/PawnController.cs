using Barricades.Model;
using Barricades.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Controller
{
    class PawnController
    {
        private InputView inputView { get; set; }

        private OutputView outputView { get; set; }

        private Player player { get; set; }

        public PawnController(InputView inputView, OutputView outputView)
        {
            this.inputView = inputView;
            this.outputView = outputView;
        }

        public void movePawn(Player player, int moves)
        {
            this.player = player;
            Pawn pawn = null;

            for (int i = 0; i < moves; i++) {
                while (!movePawn(pawn))
                pawn = selectPawn();
            }
        }

        private Pawn selectPawn()
        {
            int number = -1;
            string input = "";
            while (!int.TryParse(input, out number) || (number <= 0 || number > 3))
            {
                outputView.printPawnRequest(player.playerNumber + 1);
                input = inputView.getInput().KeyChar.ToString();
            }
            return player.getPawn(number);
        }

        private bool movePawn(Pawn pawn)
        {
            if (pawn == null)
            {
                return false;
            }
            if (pawn.location == null)
            {
                if (!player.deployPawn(pawn))
                {
                    outputView.printDeployError();
                    return false;
                }
            }
            bool validMove = false;
            while (!validMove)
            {
                outputView.printDirectionRequest();
                var input = inputView.getInput().Key;
                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        validMove = pawn.Move(Direction.Up);
                        break;
                    case ConsoleKey.DownArrow:
                        validMove = pawn.Move(Direction.Down);
                        break;
                    case ConsoleKey.LeftArrow:
                        validMove = pawn.Move(Direction.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        validMove = pawn.Move(Direction.Right);
                        break;
                }
            }
            return validMove;
        }
    }
}
