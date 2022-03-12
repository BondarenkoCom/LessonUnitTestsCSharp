using System;
using System.Runtime.InteropServices;

namespace ClassSystemObject
{
    class Program
    {
        static void Main(string[] args)
        {

            accountUseIdObject accountObj1 = new accountUseIdObject { sum = 1000};
            accountUseIdObject accountObj2 = new accountUseIdObject { sum = 9999};

            accountObj1.id = 1;
            accountObj2.id = "ObjectId423";

            int id1 = (int)accountObj1.id;
            string id2 = (string)accountObj2.id;

            Console.WriteLine(id1);
            Console.WriteLine(id2);

            ///вызов универсального класса позволяет менять тип данных на лету
            accountUniversalType<int> accountUniversal1 = new accountUniversalType<int> { UniversalSum = 1111 };
            accountUniversalType<string> accountUniversal2 = new accountUniversalType<string> { UniversalSum = 4234 };

            accountUniversal1.UniversalId = 1;
            accountUniversal2.UniversalId = "ID H2";

            int UnId1 = accountUniversal1.UniversalId;
            string UnId2 = accountUniversal2.UniversalId;

            Console.WriteLine(UnId1);
            Console.WriteLine(UnId2);


        }
    }

    public class accountUseIdObject
    {
        public object id { get; set; } //Object можно использовать если нужно менять тип данных постоянно
        public int sum { get; set; }
    }

    public class accountUniversalType<T> //<T> указывает на то что класс обобщенный
    {
        public T UniversalId { get; set; }
        public int UniversalSum { get; set; }


    }

}
