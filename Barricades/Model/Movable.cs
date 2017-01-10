using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    interface Movable 
    {
        void Move();

        void Hit();

        Square location
        {
            get;
            set;
        }
    }
}
