using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A010_ConsoleFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency : {0:C2}\n" +
                "(D) Decimal : {0:D2}\n" +
                "(E) Scientific : {0:E2}\n" +
                "(f) Fixed Point : {0:F2}\n" +
                "(G) General : {0:G2}\n" +
                "(N) Number : {0:N2}\n" +
                "(P) Percent : {1:P2}\n" +
                "(R) Round Trip : {1:R2}\n" +
                "(X) Hexadecimal : {0:X2}\n" +
                "(C) Currency : {0, 20:C2}\n",
                -12345678, -1234.5678f
                );
        }
    }
}
