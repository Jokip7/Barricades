using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barricades.Model
{
    class Dice
    {
        private const int LOWEST_EYE = 1;
        private const int HIGHEST_EYE = 6;
        Random random;

        public Dice()
        {
            random = new Random();
        }

        public int throwDice()
        {
            return random.Next(LOWEST_EYE, HIGHEST_EYE + 1);
        }
    }
}
