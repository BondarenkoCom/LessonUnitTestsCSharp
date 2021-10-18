using System;
using System.Data;

namespace StructureAndClass
{
    class Program
    {
        static void Main(string[] args)
        {
            UseStruct.GetState();

            Person p = new Person { name = "Tom", age = 22 };

            UseStruct.ChangePerson(ref p);

            Console.WriteLine(p.name);
            Console.WriteLine(p.age);

            Console.ReadLine();
        }

    }

    class UseStruct
    {

    
    class Person
    {
        public string name;
        public int age;
    }

    public static void GetState()
        {
            State state1 = new State(); //Структура ,ее данные размещены в стеке
            State state2 = new State();
            state1.x = 1;
            state2.y = 2;

            state1 = state2;
            state2.x = 5;
            Console.WriteLine(state1.x);
            Console.WriteLine(state2.x);


            Country country1 = new Country(); // Country - класс , в стек помещается ссылдка на адрес в хип  а в хипе распологаются все данные объекта country1

        }
    }


    struct  State
    {
        public int x;
        public int y;
        public Country country;
    }

    struct Country
    {
        public int x;
        public int y;
    }

}
