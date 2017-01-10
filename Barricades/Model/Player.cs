using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Player
    {
        private const int NUMBER_OF_PAWNS = 4;

        public List<Pawn> pawns { get; set; }

        public int playerNumber { get; set; }

        public Square firstSquare { get; set; }

        public Player(int playerNumber, Square firstSquare)
        {
            this.playerNumber = playerNumber;
            this.firstSquare = firstSquare;
            generatePawns();
        }

        private void generatePawns()
        {
            pawns = new List<Pawn>();
            for (int i = 0; i < NUMBER_OF_PAWNS; i++)
            {
                pawns.Add(new Pawn());
            }
        }

        public Pawn getPawn(int number)
        {
            return pawns[number];
        }

        public bool deployPawn(Pawn pawn)
        {
            if (pawn.location == null && !firstSquare.isOccupied())
            {
                firstSquare.Occupier = pawn;
                pawn.location = firstSquare;
                return true;
            }
            return false;
        }

    }
}
