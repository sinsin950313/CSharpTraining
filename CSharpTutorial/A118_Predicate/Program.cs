using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A118_Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = (n) => { return n % 2 == 0; };
            Console.WriteLine(isEven(6));

            Predicate<string> isLowerCase = (s) => { return s.Equals(s.ToLower()); };
            Console.WriteLine(isLowerCase("This is test"));
        }
    }
}
