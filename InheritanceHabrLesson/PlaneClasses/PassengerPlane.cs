using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHabrLesson.PlaneClasses
{
    public class PassengerPlane : Airplane
    {

        public int Seats { get; set; }

        public PassengerPlane(int year, int weight, string color, double wingLength, int seats) : base(year, weight, color, wingLength)
        {
            Seats = seats;
        }

        public override void Info() //С помощью Override переопределил метод Info для класса Truck(Transport >> Car >> Truck 
        {
            Console.WriteLine("Airplane");
            Console.WriteLine($"Year:{Year}/n" +
                              $"Weight:{Weight}/n" +
                              $"Color:{Color}");
            Console.WriteLine($"wingLength:{WingLength}/n");
            Console.WriteLine($"Seats:{Seats}/n");
        }
    }
}