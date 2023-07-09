using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A120_LinqBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };
            List<int> lstSortedEvent = new List<int>();

            foreach(var item in data)
            {
                if(item % 2 == 0)
                {
                    lstSortedEvent.Add(item);
                }
                lstSortedEvent.Sort();
            }

            Console.WriteLine("Using foreach : ");
            foreach (var item in lstSortedEvent)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var sortedEven =
                from item in data
                where item % 2 == 0
                orderby item
                select item;

            Console.WriteLine("Using Linq");
            foreach(var item in sortedEven)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
