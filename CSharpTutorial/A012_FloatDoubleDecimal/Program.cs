using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A012_FloatDoubleDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float flt = 1f / 3;
            double dbl = 1d / 3;
            decimal dcm = 1m / 3;

            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}", flt, dbl, dcm);
            Console.WriteLine("float : {0} bytes\ndouble : {1} bytes\ndecimal : {2}bytes", sizeof(float), sizeof(double), sizeof(decimal));
            Console.WriteLine("float : {0} ~ {1}", float.MaxValue, float.MinValue);
            Console.WriteLine("double : {0} ~ {1}", double.MaxValue, double.MinValue);
            Console.WriteLine("decimal : {0} ~ {1}", decimal.MaxValue, decimal.MinValue);
        }
    }
}
