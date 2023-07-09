using System;
using System.Collections.Generic;

class Program
{
    public abstract class BaseClass
    {
        public abstract void Func1();
        public void Func2()
        {
            Console.WriteLine("AAA");
        }
    }
    static IEnumerable<int> GetNumber()
    {
        yield return 10;  // 첫번째 루프에서 리턴되는 값
        yield return 20;  // 두번째 루프에서 리턴되는 값
        yield return 30;  // 세번째 루프에서 리턴되는 값
    }

    static void Main(string[] args)
    {
        foreach (int num in GetNumber())
        {
            Console.WriteLine(num);
        }
        foreach (int num in GetNumber())
        {
            Console.WriteLine(num);
        }
    }
}