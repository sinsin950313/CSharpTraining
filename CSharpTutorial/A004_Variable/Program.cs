using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A004_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write Name : ");
            string name = Console.ReadLine();

            Console.Write("Write Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Write Height : ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Hello, ");
            Console.Write(name);
            Console.WriteLine();


            Console.Write("Age : ");
            Console.WriteLine(age);

            Console.Write("Height : ");
            Console.Write(height);
            Console.WriteLine("cm");
        }
    }
}
