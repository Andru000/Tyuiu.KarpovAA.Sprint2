﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarpovAA.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
           int z = 0;
            bool res;
            if (2<=x && x<=13)
            {
                if (x == 2)
                {
                    if (y == 4 || y == 5)
                        z = 1;
                    else
                        z = 0;
                }

                if (x == 3)
                {
                    if (y == 11 || (y >= 3 && y <= 7))
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 4)
                {
                    if (y == 11 || (y >= 3 && y <= 7))
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 5)
                {
                    if (y == 11 || (y >= 3 && y <= 7))
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 6)
                {
                    if (y >= 5 && y <= 11)
                        z = 1;
                    else 
                        z = 0;
                }
                if (x == 7)
                {
                    if (y >= 5 && y <= 11)
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 8)
                {
                    if (y >= 5 && y <= 11)
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 9)
                {
                    if (y == 5 || y == 11 || y == 12)
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 10)
                {
                    if ((y >= 2 && y <= 5) || y == 11 || y == 12)
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 11)
                {
                    if ((y >= 2 && y <= 5) || y == 11)
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 12)
                {
                    if ((y >= 2 && y <= 5) || y == 11)
                        z = 1;
                    else
                        z = 0;
                }
                if (x == 13)
                {
                    if ((y >= 9 && y <= 13) || y == 2 || y == 3)
                        z = 1;
                    else
                        z = 0;
                }

            }
            if (z == 1)
                res = true;
            else
                res = false;
            return res;
        }
    }
}
