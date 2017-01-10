using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Board
    {
        public List<Square> Squares { get; set; }

        private Finish FinishSquare { get; set; }

        private Forest ForestSquare { get; set; }

        public void generate()
        {
            Squares = new List<Square>();

			//max y = 10 max x = 11
			//0
			Squares.Add(new FirstSquare(1, 0));
			Squares.Add(new FirstSquare(3, 0));
			Squares.Add(new FirstSquare(7, 0));
			Squares.Add(new FirstSquare(9, 0));

			//1
			for(int i = 0; i < 11; i++)
			{
				Squares.Add(new Square(i, 1));
			}

			//2
			for (int i = 0; i < 11; i++)
			{
				if (i == 0 || i == 2 || i == 5 || i == 8 || i == 10)
				{
					Squares.Add(new Rest(i, 2));
				}
				else
				{
					Squares.Add(new Square(i, 2));
				}

			}

			//3
			Squares.Add(new Forest(5, 3));

			//4
			for(int i = 3; i < 8; i++)
			{
				if (i == 5)
					Squares.Add(new Rest(i, 4));
				else
					Squares.Add(new Square(i, 4));
			}

			//5
			Squares.Add(new Rest(2, 5));
			for(int i = 3; i < 8; i++)
			{
				Squares.Add(new Square(i, 5));
			}
			Squares.Add(new Rest(8, 5));

			//6
			for(int i = 2; i < 9; i++)
			{
				Squares.Add(new Village(i, 6));
			}

			//7
			for(int i = 1; i < 10; i++)
			{
				if (i == 4 || i == 6)
					Squares.Add(new Rest(i, 7));
				else
					Squares.Add(new Village(i, 7));
			}

			//8
			for(int i = 1; i < 10; i++)
			{
				Squares.Add(new Square(i, 8));
			}

			//9
			Squares.Add(new Finish(5, 9));

		}

        public bool finishOccupied()
        {
            return FinishSquare.isOccupied();
        }

        public Square findSquare(int x, int y)
        {
            return (from sq in Squares
                    where sq.x == x && sq.y == y
                    select sq).First();
        }

    }
}
