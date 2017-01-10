using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Forest : Square
    {
        public Forest(int x, int y) : base(x, y)
        {
            canMoveTo = false;
        }
    }
}
