using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Rest : Square
    {
        public Rest(int x, int y) : base(x, y)
        {

        }

        public new char Character
        {
            get
            {
                return 'R';
            }
        }
    }
}
