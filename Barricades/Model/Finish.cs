﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Finish : Square
    {
        public Finish(int x, int y) : base(x, y)
        {

        }

        public override char Character
        {
            get
            {
                return '=';
            }
        }
    }
}
