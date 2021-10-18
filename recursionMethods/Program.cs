using System;

namespace recursionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("recursion");
            //  Factorial(22);
            Fibonachi(15);

        }

        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);

            }
        }

        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

    }
}
