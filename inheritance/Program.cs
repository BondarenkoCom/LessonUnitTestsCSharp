using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load");

            Person p = new Person { Name = "Samus" }; //новый экземляр класса с name
            p.Display(); //обращение к методу Display который содержит в себе вывод в консоль

            p = new Employee { Name = "Rock" };//новый Экземпляр класса который на это раз через Employee наследует все от класс Person
            p.Display();//так же вывод через Display
            
            p = new BlackLagoon { Name = "Revy" };
            p.Display();

            Console.Read();


        }
    }
}
