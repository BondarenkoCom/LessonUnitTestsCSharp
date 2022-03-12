using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHabrLesson
{
    public class Car : Transport
    {
        //первый плюс наследования(что я отметил, это можно наследовать все умения базового класса (тут Это Transport) и в новом классе можно унаследовать всю базу и добавить свои модификации
        //(тут это int Carraigees)
        public double Speed { get; set; }

        
        public Car(int year, int weight, string color, double speed) : base(year, weight, color) //публично наследовали от Transport year/weight/color
        {
            Speed = speed;
        }

        public override void Info() //С помощью Override переопределил метод Info для класса car
        {
            Console.WriteLine("Airplane");
            Console.WriteLine($"Year:{Year}/n" +
                              $"Weight:{Weight}/n" +
                              $"Color:{Color}");
            Console.WriteLine($"Speed:{Speed}/n");
        }
    }
}
