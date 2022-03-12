using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonBaseCSharp
{
    class TransformationTypes
    {
        public class Person
        {
            public static void GetTransformPerson()
            {
                Employee employee = new Employee("Tom", "Valve"); //Создаем новый экземпляр  класса с наследованием от Person
                Person person = employee;  // преобразование от Employee к Person
                Employee employee2 = (Employee)person; // преобразование от Person к Employee
                object obj = new Employee("Bill", "Microsoft");

                Console.WriteLine(person.Name);
                ((Person)obj).Display();
                Console.ReadKey();

            }

            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }

            public void Display()
            {
                Console.WriteLine($"Person {Name}");
            }
        }

        public class Employee : Person
        {
            public string Company { get; set; }

            public Employee(string name, string company) : base(name)
            {
                Company = company;
            }
        }


        public class Client : Person
        {
            public string Bank { get; set; }

            public Client(string name, string bank) : base(name)
            {
                Bank = bank;
            }
        }

    }
}
