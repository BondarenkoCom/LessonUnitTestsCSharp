using System;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Counter c1 = new Counter {Value = 23};
            Counter c2 = new Counter {Value = 41};

            //bool result 

        }
    }

    class Counter
    {
        public int Value { get; set; }
    }
}
