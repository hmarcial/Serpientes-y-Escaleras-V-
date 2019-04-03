using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syp
{
    class Tablero
    {
        protected int[] vec;
        public Tablero()
        {
            vec = new int[101];
            for (int i = 1; i < 100; i++)
            {
                vec[i] = 0;
            }
            vec[3] = 57;
            vec[6] = 41;
            vec[32] = 21;
            vec[45] = 41;
            vec[51] = 43;
            vec[61] = 22;
            vec[13] = 1;
            vec[4] = -2;
            vec[50] = -37;
            vec[68] = -13;
            vec[81] = -65;
            vec[93] = -50;
            vec[98] = -62;
            vec[99] = -98;
        }

    }
}

