using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
	class EmptySquare : Square, Printable
	{
		public EmptySquare(int x, int y) : base(x, y)
		{
		}
	}
}
