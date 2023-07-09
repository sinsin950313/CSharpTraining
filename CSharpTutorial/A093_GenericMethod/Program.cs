using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A093_GenericMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "tiger", "lion", "zebra" };

            PrintArray(a);
            PrintArray(d);
            PrintArray(s);
        }

        private static void PrintArray<T>(T[] arr)
        {
            foreach(var elem in arr)
            {
                Console.Write("{0, 8}", elem);
            }
            Console.WriteLine();
        }
    }
}
