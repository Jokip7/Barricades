using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    interface Movable : Printable
    {
        bool Move(Direction direction);

        void Hit();

        Square location
        {
            get;
            set;
        }
    }
}
