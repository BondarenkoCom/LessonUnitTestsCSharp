using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHabrLesson.AutoClasses
{
    public class Truck : Car
    {

        public double BodyLenght { get; set; }
        public Truck(int year, int weight, string color, int speed , double bodyLenght) : base(year, weight, color, speed)
        {
            BodyLenght = bodyLenght;
        }

        public override void Info() //С помощью Override переопределил метод Info для класса Truck(Transport >> Car >> Truck 
        {
            Console.WriteLine("Airplane");
            Console.WriteLine($"Year:{Year}/n" +
                              $"Weight:{Weight}/n" +
                              $"Color:{Color}");
            Console.WriteLine($"Speed:{Speed}/n");
            Console.WriteLine($"BodyLenght:{BodyLenght}/n");
        }
    }
}
