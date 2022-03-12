using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHabrLesson
{
    public  abstract class Transport
    {
        public int Year { get; set; }
        public int Weight { get;set; }
        public string Color { get; set; }

        protected Transport()
        {
            Year = 0;
            Weight = 0;
            Color = "Unknown";
        }

        protected Transport(int year, int weight, string color)
        {
            Year = year;
            Weight = weight;
            Color = color;
        }

        public abstract void Info();

    }
}
