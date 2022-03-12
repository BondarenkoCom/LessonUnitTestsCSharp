using System;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Примение операторов преобразования в программе:
            Counter counter1 = new Counter { Seconds = 115 };

            Timer timer = counter1;
            Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}"); // 0:1:55

            Counter counter2 = (Counter)timer;
            Console.WriteLine(counter2.Seconds);  //115

            Console.ReadKey();

        }
    }

    public class Timer
    {
        public int Hours {get; set;}
        public int Minutes {get; set;}
        public int Seconds {get; set;}
    }

    public class Counter
    {
        public int Seconds { get; set; } //get;set; свойство для для доступа к полям и струкутрам 

        public static implicit operator Counter(int x) //Counter становится классом с неявным преобразованием  , int x объект который надо преобразовать
        {
            return new Counter{Seconds = x}; //возвращаем обновленный класс Counter  
        }

        public static explicit operator int(Counter counter)  //Explict для преобразования явных значений
        {
            return counter.Seconds;
        }

        public static explicit operator Counter(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Counter { Seconds = h + m + timer.Seconds };
        }

        public static implicit operator Timer(Counter counter)
        {
            int h = counter.Seconds / 3600;
            int m = (counter.Seconds % 3600) / 60;
            int s = counter.Seconds % 60;
            return new Timer {Hours = h , Minutes = m , Seconds = s};
        }

    }


}
