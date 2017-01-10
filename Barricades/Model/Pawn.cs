using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Pawn : Movable, Printable 
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

        public void Move()
        {
            //Move this pawn
        }

        public void Hit()
        {
            throw new NotImplementedException();
        }

    }
}
