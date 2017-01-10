using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Barricade : Movable, Printable
    {
        public char Character
        {
            get
            {
                return 'B';
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

        public void Move()
        {
            throw new NotImplementedException();
        }

    }
}
