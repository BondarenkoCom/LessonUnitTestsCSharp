using System;

namespace ArrayParam
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            Display(message);
            Console.ReadKey();
        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
