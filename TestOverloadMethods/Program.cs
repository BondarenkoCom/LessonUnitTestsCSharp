using System;

namespace TestOverloadMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load...");
            Counter c1 = new Counter { Value = 113};
            Counter c2 = new Counter { Value = 45 };
            bool result = c1 > c2;
            Console.WriteLine(result);

            Counter c3 = c1 + c2;
            Console.WriteLine(c3.Value);

            Console.ReadKey();

        }
    }
}
