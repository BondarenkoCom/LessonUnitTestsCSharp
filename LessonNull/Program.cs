using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load.....");
            Console.WriteLine(Characters.BlackLagoon());
            Console.ReadKey();
        }
    }

    public static class Characters
    {



        public static string GetWeapon()
        {
            WeaponClass weapon = new WeaponClass();

            weapon[0] = new Weapon { label = "Beretta 92FS Inox \"9mm Sword Cutlass" };
            weapon[1] = new Weapon { label = "Barrett M82A1 - .50 Caliber"};
            weapon[2] = new Weapon { label = "SVD Dragunov  - 7.62x54mm R"};

            Weapon Revy = weapon[0];
            Weapon Roberta = weapon[1];
            Weapon Sofiya = weapon[2];
            string RevyWeapon = ($"{Revy.label}");
            string RobertaWeapon = ($"{Roberta.label}");
            string SofiyaWeapon = ($"{Sofiya.label}");

            //string[] arrayResult = new string[Convert.ToInt32(SofiyaWeapon) , Convert.ToInt32(RevyWeapon) , Convert.ToInt32(RobertaWeapon)];
            //return arrayResult;
            return RobertaWeapon; 
            //yield return RevyWeapon;


        }
        
        public static string BlackLagoon()
        {
            People people = new People();

            people[0] = new Person { Name = "Revy", Age = "21" };
            people[1] = new Person { Name = "Roberta", Age = "34" };
            people[2] = new Person { Name = "Sofiya Pavlovna", Age = "40" };

            Person Revy = people[0];
            Person Roberta = people[1];
            Person Sofiya = people[2];
            //Console.WriteLine($"{Revy?.Name} , {Revy?.Age} \n {Roberta.Name} , {Roberta.Age} \n {Sofiya.Name} , {Sofiya.Age}");
            var result = ($"{Revy?.Name} , {Revy?.Age} use {GetWeapon()} \n{Roberta.Name} , {Roberta.Age} use {GetWeapon()} \n{Sofiya.Name} , {Sofiya.Age} use {GetWeapon()}");
            return result;
            //return Sofiya.Name.ToString();
        }
        
    }

    public class Weapon
    {
        public string label { get; set; }
    }


    public class WeaponClass
    {
        Weapon[] dataWeapon;

        public WeaponClass()
        {
            dataWeapon = new Weapon[3];
        }

        public Weapon this[int indexW]
        {
            get
            {
                return dataWeapon[indexW];
            }
            set
            {
                dataWeapon[indexW] = value;
            }
        }
    }



    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }

    public class People
    {
        Person[] data;
        //Weapon[] dataWeapon;
        public People()
        {
            //по идее все объекты храняться в массиве data
            data = new Person[3];
        }
        //Индексатор
        public Person this[int index]
        {
            get
            {
                //для  получения по индексу блок get и нужен
                return data[index];
            }
            set
            {
                //сохранение в массив
                data[index] = value;
            }
        }
    }

}
