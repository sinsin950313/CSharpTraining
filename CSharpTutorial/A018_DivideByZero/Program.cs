﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A018_DivideByZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            Console.WriteLine(10.0 / y);

            try
            {
                Console.WriteLine(x / y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
