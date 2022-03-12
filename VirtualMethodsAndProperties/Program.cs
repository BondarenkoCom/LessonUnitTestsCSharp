using System;

namespace VirtualMethodsAndProperties
{
    //TODO закрепить все темы классов ниже
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill");
            p1.Display(); //вызвать метод display из класса Person

            Employee p2 = new Employee("Tom", "Capcom ");
            p2.Display();

            ShadowMethod p3 = new ShadowMethod("Batman", "Wayne");
            p3.Display();

            //использование абстрактныз классов

            NewHero real = new RealPerson("Tom", 21);
            NewHero fake = new FakePerson("WatchMan", "Power");

            real.ShowNewHero();
            fake.ShowNewHero();

        }
    }

    //Добавляем абстрактный класс
    abstract class NewHero
    {
        public string HeroName { get; set; }

        public NewHero(string heroName)
        {
            HeroName = heroName;
        }

        public abstract void ShowNewHero();
    }

    class RealPerson : NewHero
    {
        public int Age { get; set; }

        public RealPerson(string heroName, int age) : base(heroName)
        {
            Age = age;
        }

        public override void ShowNewHero()
        {
            Console.WriteLine($"{HeroName} In age = {Age}");
        }
    }

    class FakePerson : NewHero
    {
        public string HeroData { get; set; }

        public FakePerson(string heroName, string heroData) : base(heroName)
        {
            HeroData = heroData;
        }

        public override void ShowNewHero()
        {
            Console.WriteLine($"{HeroName} In age = {HeroData}");

        }
    }



    //Добавляем сокрытие методы
    public class Person
    {
        public string Name { get; set; }


        public Person(string name)
        {
            Name = name;

        }

        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }

    public class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        //если я хочу вывести и компанию и имя то нужно сделать переопределение для метода Display
        //(он должен быть с virtual в оригианале, а в классе наследования он должен быть с Override
        public override void Display()
        {
           Console.WriteLine($"{Name} работает в {Company}");
        }
    }

    //сделать метод в shadow
    public class ShadowMethod : Person
    {
        public string LastName { get; set; }

        public ShadowMethod(string name , string lastName): base(name)
        {
            LastName = lastName;
        }

        public new void Display()
        {
           Console.WriteLine($"{Name} имеет фамилию {LastName} ");
        }
    }

}
