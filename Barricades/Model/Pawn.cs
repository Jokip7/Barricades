using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Pawn : Movable
    {
        public Square location
        {
            get; set;
        }

        public char Character
        {
            get
            {
                return 'p';
            }
        }

        public bool Move(Direction direction)
        {
            var nextSquare = location.getLinkedSquare(direction);
            if (nextSquare == null || !nextSquare.canMoveTo)
                return false;
            location.Occupier = null;
            nextSquare.Occupier = this;
            return true;
        }

        public void Hit()
        {
            throw new NotImplementedException();
        }

    }
}
