using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A111_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s1 = new SortedList<int, string>();
            s1.Add(3, "Three");
            s1.Add(4, "Four");
            s1.Add(1, "One");
            s1.Add(2, "Two");

            for(int i = 0; i < s1.Count; ++i)
            {
                Console.Write("k : {0}, v : {1} / ", s1.Keys[i], s1.Values[i]);
            }
            Console.WriteLine();

            foreach(var kvp in s1)
            {
                Console.Write("{0, -10}", kvp);
            }
            Console.WriteLine();

            SortedList<string, int> s2 = new SortedList<string, int>();
            s2.Add("One", 1);
            s2.Add("Two", 2);
            s2.Add("Three", 3);
            s2.Add("Four", 4);

            Console.WriteLine(s2["Two"]);

            foreach(var kvp in s2)
            {
                Console.Write("{0, -10}", kvp);
            }
            Console.WriteLine();

            int val;
            if(s2.TryGetValue("Ten", out val))
            {
                Console.WriteLine("Key : Ten, Value : {0}", val);
            }
            else
            {
                Console.WriteLine("[Ten] : Key is not valied");
            }

            if(s2.TryGetValue("One", out val))
            {
                Console.WriteLine("Key : One, Value : {0}", val);
            }
            else
            {
                Console.WriteLine("[Ten] : One is not valied");
            }

            Console.WriteLine(s2.ContainsKey("One"));
            Console.WriteLine(s2.ContainsKey("Ten"));
            Console.WriteLine(s2.ContainsValue(2));
            Console.WriteLine(s2.ContainsValue(6));

            s2.Remove("One");
            s2.RemoveAt(0);

            foreach(var kvp in s2)
            {
                Console.Write("{0, -10}", kvp);
            }
            Console.WriteLine();
        }
    }
}
