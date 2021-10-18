using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load Tuple");
            var tuple = (5, 10 , 111);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            tuple.Item1 += 23;
            Console.WriteLine(tuple.Item1);

            (int, int) TupleNew = (4, 12);
            (string, int, double) person = ("Motoko", 31, 172.3);
            Console.WriteLine(person.Item1);
            var tupleRes = GetPerson();
            Console.WriteLine(tupleRes.Item1);
            Console.WriteLine(tupleRes.Item2);

        }

        private static (int, int) GetPerson()
        {
            var result = (1  , 3);
            return result;
        }
    }
}
