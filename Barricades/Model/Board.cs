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

			//creare squares

			//max y = 10 max x = 11
			//0

			//1
			for (int i = 0; i < 11; i++)
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
			Forest forestSquare = new Forest(5, 3);
			Squares.Add(forestSquare);
			ForestSquare = forestSquare;


			//4
			for (int i = 3; i < 8; i++)
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
			Finish finishSquare = new Finish(5, 9);
			Squares.Add(finishSquare);
			FinishSquare = finishSquare;

			//fill empty spaces
			for(int x = 0; x < 11; x++)
			{

				for(int y = 0; y < 10; y++)
				{
					if (!coordinateExists(x, y))
						Squares.Add(new EmptySquare(x, y));
				}

			}

			// create links

			//0
			findSquare(1, 0).linkedSquares.Add(Direction.Up, findSquare(1, 1));
			findSquare(3, 0).linkedSquares.Add(Direction.Up, findSquare(3, 1));
			findSquare(7, 0).linkedSquares.Add(Direction.Up, findSquare(7, 1));
			findSquare(9, 0).linkedSquares.Add(Direction.Up, findSquare(9, 1));

			//1
			for(int i = 0; i < 10; i++)
			{
				findSquare(i, 1).linkedSquares.Add(Direction.Right, findSquare(i + 1, 1));
			}
			for(int i = 10; i > 0; i--)
			{
				findSquare(i, 1).linkedSquares.Add(Direction.Left, findSquare(i - 1, 1));
			}
			findSquare(0, 1).linkedSquares.Add(Direction.Up, findSquare(0, 2));
			findSquare(2, 1).linkedSquares.Add(Direction.Up, findSquare(2, 2));
			findSquare(5, 1).linkedSquares.Add(Direction.Up, findSquare(5, 2));
			findSquare(8, 1).linkedSquares.Add(Direction.Up, findSquare(8, 2));
			findSquare(10, 1).linkedSquares.Add(Direction.Up, findSquare(10, 2));

			//2
			for (int i = 0; i < 10; i++)
			{
				findSquare(i, 2).linkedSquares.Add(Direction.Right, findSquare(i + 1, 2));
			}
			for (int i = 10; i > 0; i--)
			{
				findSquare(i, 2).linkedSquares.Add(Direction.Left, findSquare(i - 1, 2));
			}
			findSquare(3, 2).linkedSquares.Add(Direction.Up, findSquare(3, 4));
			findSquare(7, 2).linkedSquares.Add(Direction.Up, findSquare(7, 4));

			//3
			findSquare(5, 3).linkedSquares.Add(Direction.Up, findSquare(5, 4));

			//4
			for (int i = 3; i < 7; i++)
			{
				findSquare(i, 4).linkedSquares.Add(Direction.Right, findSquare(i + 1, 4));
			}
			for (int i = 7; i > 3; i--)
			{
				findSquare(i, 4).linkedSquares.Add(Direction.Left, findSquare(i - 1, 4));
			}
			findSquare(5, 4).linkedSquares.Add(Direction.Up, findSquare(5, 5));

			//5
			for (int i = 2; i < 8; i++)
			{
				findSquare(i, 5).linkedSquares.Add(Direction.Right, findSquare(i + 1, 5));
			}
			for (int i = 8; i > 2; i--)
			{
				findSquare(i, 5).linkedSquares.Add(Direction.Left, findSquare(i - 1, 5));
			}
			findSquare(2, 5).linkedSquares.Add(Direction.Up, findSquare(2, 6));
			findSquare(8, 5).linkedSquares.Add(Direction.Up, findSquare(8, 6));

			//6
			for (int i = 2; i < 8; i++)
			{
				findSquare(i, 6).linkedSquares.Add(Direction.Right, findSquare(i + 1, 6));
			}
			for (int i = 8; i > 2; i--)
			{
				findSquare(i, 6).linkedSquares.Add(Direction.Left, findSquare(i - 1, 6));
			}
			findSquare(5, 6).linkedSquares.Add(Direction.Up, findSquare(5, 7));

			//7
			for (int i = 1; i < 9; i++)
			{
				findSquare(i, 7).linkedSquares.Add(Direction.Right, findSquare(i + 1, 7));
			}
			for (int i = 9; i > 1; i--)
			{
				findSquare(i, 7).linkedSquares.Add(Direction.Left, findSquare(i - 1, 7));
			}
			findSquare(1, 7).linkedSquares.Add(Direction.Up, findSquare(1, 8));
			findSquare(9, 7).linkedSquares.Add(Direction.Up, findSquare(9, 8));

			//8
			for (int i = 2; i < 8; i++)
			{
				findSquare(i, 8).linkedSquares.Add(Direction.Right, findSquare(i + 1, 8));
			}
			for (int i = 8; i > 2; i--)
			{
				findSquare(i, 8).linkedSquares.Add(Direction.Left, findSquare(i - 1, 8));
			}
			findSquare(5, 8).linkedSquares.Add(Direction.Up, findSquare(5, 9));


		}

		public bool finishOccupied()
        {
            return FinishSquare.isOccupied();
        }

		public Square findSquare(int x, int y)
		{

			return (from sq in Squares
					where sq.x == x && sq.y == y
					select sq).FirstOrDefault();

		}

		private bool coordinateExists(int x, int y)
		{
			return findSquare(x, y) != null;
		}

    }
}
