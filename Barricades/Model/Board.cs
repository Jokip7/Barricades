using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Board
    {
        public List<Square> Squares { get; set; }

        private Finish FinishSquare { get; set; }

        private Forest ForestSquare { get; set; }

        public void generate()
        {
            Squares = new List<Square>();
            //Generate the board
        }

        public bool finishOccupied()
        {
            return FinishSquare.isOccupied();
        }

        public Square findSquare(int x, int y)
        {
            return (from sq in Squares
                    where sq.x == x && sq.y == y
                    select sq).First();
        }
    }
}
