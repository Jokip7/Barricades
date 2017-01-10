using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Barricade : Movable
    {
        public char Character
        {
            get
            {
                return 'b';
            }
        }

        public Square location
        {
            get; set;
        }

        public void Hit()
        {
            throw new NotImplementedException();
        }

        public bool Move(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
