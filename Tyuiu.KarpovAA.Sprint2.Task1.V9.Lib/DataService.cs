﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarpovAA.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c + 1000 < d);
            res[1] = (a + 2 > b) & (c < b);
            res[2] = (a > b) || (c < b);
            res[3] = (a + 2 > b) && (c < b);
            res[4] = (!res[0]);
            res[5] = (a > b) ^ (c + 2000 < d);


            return res;
        }
    }
}
