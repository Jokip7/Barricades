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

        public virtual char Character
        {
            get
            {
				if(Occupier == null)
					return 'o';
				return Occupier.
            }
        }

        public Movable Occupier { get; set; }

        public Dictionary<Direction, Square> linkedSquares { get; set; }

        public Square(int x, int y)
        {
			linkedSquares = new Dictionary<Direction, Square>();
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
