using Barricades.Model;
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

        public void startGame()
        {
            game = new Game();
            game.startGame();
        }
    }
}
