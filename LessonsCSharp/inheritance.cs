using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LessonsCSharp
{
    public class Person
    {
        public string Name { get; set; }
        public  Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }
}
