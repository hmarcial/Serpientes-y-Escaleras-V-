﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syp
{
    class Dado
    {
        private static Random dado = new Random();
        public int LANZAR()
        {
            int a = dado.Next(1, 7);
            return a;
        }
    }
}
