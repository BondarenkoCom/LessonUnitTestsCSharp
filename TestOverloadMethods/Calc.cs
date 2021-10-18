using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOverloadMethods
{
    class Calc
    {
        public void Add(int a , int b)
        {
            int result = a + b;
            Console.WriteLine($"Result {result}");

        }
        public void Add(int a, int b , int c  , int  d)
        {
            int result = a + b + c + d;
            Console.WriteLine($"Result {result}");
        }
        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"Result {result}");
        }
        public void Add()
        {

        }

    }
}
