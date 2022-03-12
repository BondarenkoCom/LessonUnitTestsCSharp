using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Employee : Person // Employee будет использовать и наследовать все от класса Person
    {
        
    }

    public class BlackLagoon : Employee
    {

    }


    //Класс описывает человека
    public class Person
    {
        private string _name; //приватная переменная _name

        public string Name
        {
            //get; set; Свойства (методы доступа)
            

            get { return _name; }//получит  _name
 
            set { _name = value; } // определит значение для _name
        }


        public void Display() //через Display можно вывести значение
        {
            Console.WriteLine(Name); 
        }

    }
}
