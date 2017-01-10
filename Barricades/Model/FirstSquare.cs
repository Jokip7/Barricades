using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
	class FirstSquare : Square, Printable
	{
		public int NumberPawns { get; set; }

		public FirstSquare(int x, int y) : base(x, y)
		{

			NumberPawns = 4;
		}
	}
}
