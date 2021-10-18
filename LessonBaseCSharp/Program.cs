using System;
using printer = System.Console;

namespace LessonBaseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            printer.WriteLine("User");

            Recognition BatGirl;
            BatGirl.name = "Barbara";
            BatGirl.age = 20;
            BatGirl.DisplayInfo();


        }

        private struct Recognition
        {
            public string name;
            public int age;

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name} Age: {age}");
            }
        }

    }
}
