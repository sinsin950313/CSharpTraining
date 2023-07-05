using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A019_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue;

            checked
            {
                int y = 0;
                try
                {
                    y = x + 10;
                }
                catch(OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("int.MaxValue + 10 = {0}", y);
            }
        }
    }
}
