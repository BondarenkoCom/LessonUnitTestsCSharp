using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonBaseCSharp
{

    //1. Определите условие возникновения события и методы которые должны сработать.
    //2. Определите сигнатуру этих методов и создайте делегат на основе этой сигнатуры.
    //3. Создайте общедоступное событие на основе этого делегата и вызовите, когда условие сработает.
    //4. Обязательно(где-угодно) подпишитесь на это событие теми методами, которые должны сработать и сигнатуры которых подходят к делегату.

    public class LessonSharpEvents
    {

    }

    public class Counter
    {
        //Создаем делегат
        public delegate void MethodContainer();  

        //Событие OnCount c типом делегата MethodContainer.
        public static event  MethodContainer onCount;  



        public static void Count()
        {
            int a = 100;
            for (int i = 0; i < a; i++)
            {
                if (i == 71)
                {
                    //Запуск события
                    onCount();

                }
                //Console.WriteLine(i);
            }
        }
    }

    public class HandlerInitSeventyOne
    {
        public void Message()
        {

            Console.WriteLine("Пора действовать, ведь уже 71!");
        }
    }

    public class handlerTwoAfterSeventyOne
    {
        public void Message()
        {
            Console.WriteLine("Точно, уже 71!");
        }

    }


}
