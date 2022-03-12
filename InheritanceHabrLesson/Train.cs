using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHabrLesson
{
    public class Train : Transport
    {
        //первый плюс наследования(что я отметил, это можно наследовать все умения базового класса (тут Это Transport) и в новом классе можно унаследовать всю базу и добавить свои модификации
        //(тут это int Carraigees)
        public int Carriages { get; set; }

        public Train(int year, int weight, string color, int carriages) : base(year, weight, color)
        {
            Carriages = carriages;
        }

        public override void Info()
        {
            Console.WriteLine("Train");
            Console.WriteLine($"Year:{Year}/n" +
                              $"Weight:{Weight}/n" +
                              $"Color:{Color}");
            Console.WriteLine($"Carriages:{Carriages}/n");
        }
    }
}
