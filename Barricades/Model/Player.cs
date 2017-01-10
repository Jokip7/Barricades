using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Player
    {
        private List<Pawn> pawns { get; set; }

        public int playerNumber { get; set; }

        public Player(int playerNumber)
        {
            this.playerNumber = playerNumber;
        }

        public Pawn getPawn(int number)
        {
            return pawns[number];
        }

    }
}
