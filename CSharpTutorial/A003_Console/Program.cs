using System;

namespace A003_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("Write Name : ");

            string name = Console.ReadLine();
            Console.Write("Hello, ");
            Console.Write(name);
            Console.WriteLine();
        }
    }
}
