using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Square : Printable
    {
        public int x { get; }

        public int y { get; }

        public bool canMoveTo { get; set; }

        public char Character
        {
            get
            {
                return '.';
            }
        }

        public Movable Occupier { get; set; }

        public Dictionary<Direction, Square> linkedSquares { get; set; }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
            canMoveTo = true;
        }

        public void Hit()
        {
            Occupier.Hit();
        }

        public bool isOccupied()
        {
            if (Occupier != null)
                return true;
            return false;
        }
    }
}
