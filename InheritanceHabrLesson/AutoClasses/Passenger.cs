using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHabrLesson.AutoClasses
{
    public class Passenger : Car
    {

        public string PassengerType { get; set; }
        public Passenger(int year, int weight, string color, double speed, string passengerType) : base(year, weight, color, speed)
        {
            PassengerType = passengerType;
        }

        public override void Info() //С помощью Override переопределил метод Info для класса Truck(Transport >> Car >> Truck 
        {
            Console.WriteLine("Airplane");
            Console.WriteLine($"Year:{Year}/n" +
                              $"Weight:{Weight}/n" +
                              $"Color:{Color}");
            Console.WriteLine($"Speed:{Speed}/n");
            Console.WriteLine($"Passenger Type:{PassengerType}/n");
        }
    }

}
