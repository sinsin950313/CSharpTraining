using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A033_ConstAndReadonly
{
    internal class Program
    {
        class ConstEx
        {
            public const int number = 3;
        }

        class ReadonlyEx
        {
            public readonly int number = 10;
            public ReadonlyEx()
            {
                number = 20;
            }
            public ReadonlyEx(int n)
            {
                number = n;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.number);

            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);
        }
    }
}
