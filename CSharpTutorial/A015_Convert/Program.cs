﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A015_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("첫 번째 숫자를 입력하세요 : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요 : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            short value = short.MaxValue;
            Console.WriteLine();
            Console.WriteLine("2진수, 8진수, 10진수, 16진수로 출력하기");

            {
                int baseNum = 2;
                string s = Convert.ToString(value, baseNum);
                int i = Convert.ToInt32(s, baseNum);
                Console.WriteLine("i = {0}, {1, 2}진수 = {2, 16}", i, baseNum, s);
            }

            {
                int baseNum = 8;
                string s = Convert.ToString(value, baseNum);
                int i = Convert.ToInt32(s, baseNum);
                Console.WriteLine("i = {0}, {1, 2}진수 = {2, 16}", i, baseNum, s);
            }

            {
                int baseNum = 10;
                string s = Convert.ToString(value, baseNum);
                int i = Convert.ToInt32(s, baseNum);
                Console.WriteLine("i = {0}, {1, 2}진수 = {2, 16}", i, baseNum, s);
            }

            {
                int baseNum = 16;
                string s = Convert.ToString(value, baseNum);
                int i = Convert.ToInt32(s, baseNum);
                Console.WriteLine("i = {0}, {1, 2}진수 = {2, 16}", i, baseNum, s);
            }
        }
    }
}
