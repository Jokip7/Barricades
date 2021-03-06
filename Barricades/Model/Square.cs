﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Square : Printable
    {
        public int x { get; }

        public int y { get; }

        public bool canMoveTo { get; set; }

        public virtual char Character
        {
            get
            {
                if (!isOccupied())
                    return 'o';
                else
                    return Occupier.Character;
            }
        }

        public Movable Occupier { get; set; }

        public Dictionary<Direction, Square> linkedSquares { get; set; }

        public Square(int x, int y)
        {
			linkedSquares = new Dictionary<Direction, Square>();
            this.x = x;
            this.y = y;
            canMoveTo = true;
        }

        public void Hit()
        {
            Occupier.Hit();
        }

        public Square getLinkedSquare(Direction direction)
        {
            return (from sq in linkedSquares where sq.Key == direction select sq).FirstOrDefault().Value;
        }

        public bool isOccupied()
        {
            if (Occupier != null)
                return true;
            return false;
        }
    }
}
