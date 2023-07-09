using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A119_ListAndLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string> { "mouse", "cow", "tiger", "rabbit", "dragon", "snake" };

            bool n = myList.Exists((s) => { return s.Contains("x"); });
            Console.WriteLine("이름에 'x'를 포함하는 동물이 있나요 : " + n);

            Console.Write("이름이 3글자인 첫 번째 동물 : ");
            string name = myList.Find((s) => { return s.Length == 3; });
            Console.WriteLine(name);

            Console.WriteLine("이름이 6글자 이상의 동물");
            List<string> longName = myList.FindAll((s) => { return s.Length > 5; });
            foreach(var item in longName)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("대문자로 변환 : ");
            List<string> capList = myList.ConvertAll((s) => { return s.ToUpper(); });
            foreach(var item in capList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
