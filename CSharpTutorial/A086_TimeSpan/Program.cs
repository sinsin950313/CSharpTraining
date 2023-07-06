using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A086_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime chistmas = new DateTime(2018, 12, 25);
            DateTime newYearsDay = new DateTime(2019, 1, 1);

            TimeSpan span = newYearsDay - chistmas;
            Console.WriteLine("크리스마스와 1월 1일의 시간 간격");
            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14}", span.Days);
            Console.WriteLine("{0,14}", span.Hours);
            Console.WriteLine("{0,14}", span.Minutes);
            Console.WriteLine("{0,14}", span.Seconds);
            Console.WriteLine("{0,14}", span.Milliseconds);

            Console.WriteLine("또는");
            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14}", span.TotalDays);
            Console.WriteLine("{0,14}", span.TotalHours);
            Console.WriteLine("{0,14}", span.TotalMinutes);
            Console.WriteLine("{0,14}", span.TotalSeconds);
            Console.WriteLine("{0,14}", span.TotalMilliseconds);
            Console.WriteLine("{0,14} ticks", span.Ticks);
        }
    }
}
