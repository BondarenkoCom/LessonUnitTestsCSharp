using System;
using System.Net.Http;
using System.Xml.Serialization;
using printer = System.Console;

namespace LessonBaseCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Подготовка к подписи на событие 
            Counter cou = new Counter();
            HandlerInitSeventyOne hanOne = new HandlerInitSeventyOne();
            handlerTwoAfterSeventyOne hanTwo = new handlerTwoAfterSeventyOne();


            //Сделать подписку на событие
            Counter.onCount += hanOne.Message;
            Counter.onCount += hanTwo.Message;


            Counter.Count();

            //ConstructorCSharp checkAge = new ConstructorCSharp("Ada", 32);
            //checkAge.ReWrite();
            //ConstructorCSharp checkAgeCyber = new ConstructorCSharp("Vi", 25);
            //
            //checkAgeCyber.ReWrite();

            //structureRecognitoin.GetUser(); //Example Structure
            //TransformationTypes.Person.GetTransformPerson();

        }


        private class structureRecognitoin
        {
            public static void GetUser()
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
}
