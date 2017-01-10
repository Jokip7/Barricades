using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class First : Square
    {
        public int number { get; set; }

        public First(int x, int y) : base(x, y)
        {
        }

        public override char Character
        {
            get
            {
                return char.Parse(number.ToString());
            }
        }
    }
}
