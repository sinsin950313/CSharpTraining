using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A070_StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program x = new Program();

            int a = 10;
            int b = 30;
            int c = 20;
            Console.WriteLine("가장 큰 수는 {0}", Larger(Larger(a, b), c));
        }

        private static int Larger(int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}
