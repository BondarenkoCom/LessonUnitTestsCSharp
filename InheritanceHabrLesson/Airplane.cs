using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHabrLesson
{
    public class Airplane : Transport
    {
        //первый плюс наследования(что я отметил, это можно наследовать все умения базового класса (тут Это Transport) и в новом классе можно унаследовать всю базу и добавить свои модификации
        //(тут это int Carraigees)
        public double WingLength { get; set; }

        public Airplane(int year, int weight, string color, double wingLength) : base(year, weight, color)
        {
            WingLength = wingLength;
        }

        public override void Info()
        {
            Console.WriteLine("Airplane");
            Console.WriteLine($"Year:{Year}/n" +
                              $"Weight:{Weight}/n" +
                              $"Color:{Color}");
            Console.WriteLine($"WingLength:{WingLength}/n");
        }
    }

}
