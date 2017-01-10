using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Village : Square
    {
        public Village(int x, int y) : base(x, y)
        {

        }

        public override char Character
        {
            get
            {
				if(Occupier == null)
					 return 'v';
				return Occupier.Character;
            }
        }
    }
}
