using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A057_ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            Console.Write("a[] : ");
            foreach(var value in a)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            int[] b = new int[] { 1, 2, 3 };
            Console.Write("b[] : ");
            foreach(var value in b)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            int[] c = new int[3] { 1, 2, 3 };
            Console.Write("c[] : ");
            foreach(var value in c)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            int[] d = new int[3];
            d[0] = 1;
            d[1] = d[0] + 1;
            d[2] = d[1] + 1;
            Console.Write("d[] : ");
            foreach(var value in d)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
