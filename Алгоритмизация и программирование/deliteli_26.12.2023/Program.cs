﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliteli_26._12._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            for (double i = 103; i <= 111; i += 2)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        flag = false;
                }
                if (flag == true)
                {
                    Console.WriteLine((Math.Pow(i, 4), Math.Pow(i, 3)));
                }
                flag = true;
            }
        }
    }
}
