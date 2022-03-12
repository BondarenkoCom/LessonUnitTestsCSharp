using System;
using System.Collections;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Unity;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Text;

//using Moq;


namespace ReaderXmlFiles
{
    class Program
    {
        public static object errorMessageEncoding { get; private set; }

        public static void Main(string[] args)
        {
            Console.WriteLine("Load");



        }

        public class ParameterSenderLink
        {
            public static void Addition(ref int x , int t)
            {
                x += t;
            }

        }

        public class ParametersSender
        {
            public static void noChange(int i, int j)
            {
                //i = 1;
                //j = 2;

                Console.WriteLine($"{j * i} standart sender");
            }
        }

     
        public class Stack
        {
            public static void StackDemoStart()
            {
                Stack stk1 = new Stack(10);
                Stack stk2 = new Stack(10);
                Stack stk3 = new Stack(10);
                char ch;
                int i;

                //поместить символы в стек stk
                Console.WriteLine("Поместить символы A-J в стек stk1");
                for (i = 0; !stk1.IsFull(); i++)
                {
                    stk1.Push((char) ('A' + i));
                }

                if (stk1.IsFull()) Console.WriteLine("стек stk1: ");
                while (!stk1.IsEmpty())
                {
                    ch = stk1.Pop();
                    Console.WriteLine(ch);
                }

                Console.WriteLine();

                if (stk1.IsEmpty()) Console.WriteLine("Стек stk1 пуст. \n");

                //поместить доп символы в стек stk1
                Console.WriteLine("Вновь поместить символы A-J в стек stk1.");
                for (i = 0; !stk1.IsFull(); i++)
                {
                    stk1.Push((char) ('A' + i));
                }

                //извлечение элементоа из стека stk1 и закинуть их в стек stk2
                //по итогу элементы сохраняются в стеке stk2 в обратном порядке
                Console.WriteLine("А теперь извлечь символы из стека stk1\n и поместить их в стек stk2");
                while (!stk1.IsEmpty())
                {
                    ch = stk1.Pop();
                    stk2.Push(ch);
                }

                Console.Write("содержимое стека stk2: ");
                while (!stk2.IsEmpty())
                {
                    ch = stk2.Pop();
                    Console.WriteLine(ch);
                }

                Console.WriteLine("\n");

                //поместить 5 символов в стек
                Console.WriteLine("поместить 5 символов в стек stk3");
                for (i = 0; i < 5; i++)
                {
                    stk3.Push((char) ('A' + i));
                }

                Console.WriteLine($"Емкость стека stk3: {stk3.Capacity()}");
                Console.WriteLine($"Количество объектов в стеке stk3: {stk3.GetNum()}");
            }

            private char[] stck; //массив содержащий стек
            private int tos; //индекс вершины стека

            //построить пустой класс StackMemory для реализации стека указанного размера
            public Stack(int size)
            {
                stck = new char[size]; //распределить память для стека 
                tos = 0;
            }

            //поместить символы в стек 
            public void Push(char ch)
            {
                if (tos == stck.Length)
                {
                    Console.WriteLine("- Стек заполнен");
                    return;
                }

                stck[tos] = ch;
                tos++;
            }

            //Извлечь символ из стека
            public char Pop()
            {
                if (tos == 0)
                {
                    Console.WriteLine("- Стек пуст");
                    return (char) 0;
                }

                tos--;
                return stck[tos];
            }

            //вернуть true если стек заполнен
            public bool IsFull()
            {
                return tos == stck.Length;
            }

            //вернуть значение true если стек  пуст
            public bool IsEmpty()
            {
                return tos == 0;
            }

            //вернуть общую емкость стека
            public int Capacity()
            {
                return stck.Length;
            }

            //вернуть кол-во объектов, находящихся в данный момент в стеке
            public int GetNum()
            {
                return tos;
            }
        }

        public class FactoryDemoReal
        {
            public static void FactoryDemoStart()
            {
                Developer dev = new PanelDeveloper("ООО кирпич строй");
                House house2 = dev.Create();

                dev = new WoodDeveloper("Частный застройщик");
                House house = dev.Create();

                Console.ReadLine();
            }

            //Абстрактный класс строй компании
            abstract class Developer
            {
                public string Name { get; set; }

                public Developer(string n)
                {
                    Name = n;
                }

                //фабричный метод 
                abstract public House Create();
            }

            //Строит панельные дома
            class PanelDeveloper : Developer
            {
                public PanelDeveloper(string n) : base(n)
                {
                }

                public override House Create()
                {
                    return new PanelHouse();
                }
            }

            //Строит деревянные дома
            class WoodDeveloper : Developer
            {
                public WoodDeveloper(string n) : base(n)
                {
                }

                public override House Create()
                {
                    return new WoodHouse();
                }
            }

            abstract class House
            {
            }

            class PanelHouse : House
            {
                public PanelHouse()
                {
                    Console.WriteLine("Панельный дом построен");
                }
            }

            class WoodHouse : House
            {
                public WoodHouse()
                {
                    Console.WriteLine("Деревянный дом построен");
                }
            }


        }

        public class Factory
        {
            abstract class
                Product //Абстрактны класс Product определит интерфейс класса объекты которого надо реализовать
            {
            }

            class ConcreteProductA : Product //реализация класса Product
            {
            }

            class ConcreteProductB : Product //реализация класса Product
            {
            }

            abstract class Creator //абстрактный фабричный метод
            {
                public abstract Product FactoryMethod();
            }

            class ConcreteCreatorA : Creator // наследник класса Creator
            {
                public override Product FactoryMethod()
                {
                    return new ConcreteProductA();
                }
            }

            class ConcreteCreatorB : Creator // наследник класса Creator
            {
                public override Product FactoryMethod()
                {
                    return new ConcreteProductB();
                }
            }

        }

        public class SearchAlgorithms
        {
            public static void SearchStart()
            {
                int[] nums = new int[10];
                int val;
                bool found = false;

                //первоначальные значения элемента массива
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                }

                val = 5; //ForEach для поиска нужного значения
                foreach (var x in nums)
                {
                    if (x == val)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine($"Value is found {val}");
                }
            }
        }

        public class ForeachDemo
        {
            public static void ForeachDemoStart()
            {
                int sum = 0;
                int[] nums = new int[10];

                //задачть первоначальные значения массива nums
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                }

                //использовать цикл ForEach для вывода значений
                //элементы массива и подсчеты их суммы
                foreach (int x in nums)
                {
                    Console.WriteLine($"Значение элемента равно: {x}");
                    sum += x;
                }

                Console.WriteLine($"Сумма равна: {sum}");

            }
        }

        public class VariableArrays
        {
            public static void VariableArraysStart()
            {
                var vals = new[] {1, 2, 3, 4, 5};
                var valsDouble = new[,] {{1.1, 2.2}, {3.3, 4.4}, {5.5, 6.6}};
            }
        }

        public class Jagged
        {
            public static void JaggedStart()
            {
                //ступенчатый массив
                int[][] network_nodes = new int[4][];
                network_nodes[0] = new int[3];
                network_nodes[1] = new int[7];
                network_nodes[2] = new int[2];
                network_nodes[3] = new int[5];

                int i, j;
                //Fake Data CP
                for (i = 0; i < network_nodes.Length; i++)
                {
                    for (j = 0; j < network_nodes[i].Length; j++)
                    {
                        network_nodes[i][j] = i * j + 70;
                    }
                }

                Console.WriteLine($"Общее количество узлов сети: {network_nodes.Length}");

                for (i = 0; i < network_nodes.Length; i++)
                {
                    for (j = 0; j < network_nodes[i].Length; j++)
                    {
                        Console.Write($"Использование в узле сети {i} ЦП {j}:");
                        Console.Write($"{network_nodes[i][j]}% ");
                    }
                }

                Console.WriteLine();
            }
        }

        public class LenghtDemo3D
        {
            public static void LenghtDemo3DStart()
            {
                int[,,] nums = new int[10, 5, 6];

                Console.WriteLine($"Lenght array = {nums.Length}");
            }
        }

        public class LenghtDemo
        {
            public static void LenghtDemoStart()
            {
                int[] nums = new int[10];


                Console.WriteLine($"Lenght = {nums.Length}");
                //использовать свойство Lenght для инициализации массива nums
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = i * i;
                }

                Console.Write($"Содержимое массива:");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[i] + "  ");
                }

                Console.WriteLine();
            }
        }


        public class ArrayDemo
        {

            public static void ThreeDMatrix()
            {
                int[,,] m = new int[3, 3, 3];
                int sum = 0;
                int n = 1;

                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        for (int z = 0; z < 3; z++)
                        {
                            m[x, y, z] = n++;
                        }
                    }
                }

                sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];
                Console.WriteLine($"Сумма значенией по первой диагонали {sum}");
            }

            public static void twoDimensionalArray()
            {
                int t, i;
                int[,] table = new int[3, 4];

                for (t = 0; t < 3; ++t)
                {
                    for (i = 0; i < 4; ++i)
                    {
                        table[t, i] = (t * 4) + i + 1;
                        Console.Write(table[t, i] + " ");
                    }

                    Console.WriteLine();
                }
            }


            public static void BigHorizonArray()
            {
                int[] sample = new int[10];
                int i;

                //превышение границы массива
                for (i = 0; i < 100; i = i + 1)
                {
                    sample[i] = i;
                }
            }

            public static void ArrayDemoVisual()
            {
                int[] sample = new int[10];
                int i;

                for (i = 0; i < 10; i = i + 1)
                {
                    sample[i] = i;
                }

                for (i = 0; i < 10; i = i + 1)
                {
                    Console.WriteLine("Sample [" + i + "]: " + sample[i]);
                }

            }

            public static void ArrayAverage()
            {
                int[] nums = {99, 10, 100, 18, 78, 23, 63, 9, 87, 49};
                int avg = 0;

                for (int i = 0; i < 10; i++)
                {
                    avg = avg + nums[i];
                }

                avg = avg / 10;
                Console.WriteLine($"Среднее: {avg}");
            }
        }

        public class Rect
        {
            //объявление переменных публичных
            public int Width;
            public int Height;

            //передача в параметр класса переменных 

            public Rect(int w, int h)
            {
                //присваиваем сокращение к переменной
                Width = w;
                Height = h;
            }

            public int Area()
            {
                //return можно использовать когда не стандартный вывод данныъ к примеру WPF или веб Интерфейс
                return this.Width * this.Height;
            }

            public class UseRect
            {
                public static void UseRectMethod()
                {
                    //через Rect(это класс) я создаю новый экзпемляр/объект где для переменных w и h буду присвоены новые значение
                    Rect r1 = new Rect(4, 5);
                    Rect r2 = new Rect(7, 9);

                    Console.WriteLine($"Площадь прямоугольника r1: {r1.Area()}");
                    Console.WriteLine($"Площадь прямоугольника r1: {r2.Area()}");

                }
            }



        }

        class UseTypeOf
        {
            public static void CheckType()
            {
                Type t = typeof(Console);
                Console.WriteLine(t.FullName);

                if (t.IsClass) Console.WriteLine("Это класс");
                if (t.IsAbstract) Console.WriteLine("Это абстрактный класс");
                else Console.WriteLine("Являтся конкретным классом");
            }
        }

        class Building
        {
            //описание объектов
            public int Floors;
            public int Area;
            public int Occupants;


        }

        class Destruct
        {
            public int x;

            public Destruct(int i)
            {
                x = i;
            }

            //Вызов при утилизации объекта
            ~Destruct()
            {
                Console.WriteLine("Уничтожить " + x);
            }

            public void Generator(int i)
            {
                Destruct o = new Destruct(i);
            }

            public class DesctructDemo
            {
                public static void DemoDestruct()
                {
                    int count;

                    Destruct ob = new Destruct(0);

                    /* создание большого кол-во мусорных объектов*/
                    for (count = 1; count < 10000; count++)
                    {
                        ob.Generator(count);
                    }

                    Console.WriteLine("Готово!");
                }
            }

        }

        class BuildindDemo //для реализации/создания экземпляра house
        {
            public static void CreateObjectsHouse()
            {

                //1)Building house - объявление переменной house которая ссылается на класс Building
                //2)new Building(); -  создает копию объекта (как бы физически) через оператор new
                //3)Building house = new Building(); - переменная House присвоится на данный объект 
                Building house = new Building(); //объявление объекта типа Building

                Building
                    office = new Building(); //используя class Building можно создать новый объект Office с значениями от Building


                int areaPP; //площадь на одного человека


                // присвоить значение полям в house

                house.Occupants = 4;
                house.Area = 2400;
                house.Floors = 2;

                //присвоить значения новому объекту Office
                office.Occupants = 100;
                office.Area = 14000;
                office.Floors = 20;

                areaPP = house.Area / house.Occupants;


                Console.WriteLine($"House \n {house.Floors} \n {house.Occupants} \n {house.Area} \n {areaPP}");
                Console.WriteLine(
                    $"Office \n {office.Floors} \n {office.Occupants} \n {office.Area} \n {areaPP = office.Area / office.Occupants}");
            }
        }

        public class ReaderXML
        {
            //public static void ScanXML(string XmlPath)
            public string ScanXML()
            {
                string XmlPath = "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\SampleXML";
                string EmptyXmlFile =
                    "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\EmptySampleXML";
                using (FileStream fstream = File.OpenRead(XmlPath))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    Console.WriteLine(array.Length);
                    string textFromXml = System.Text.Encoding.Default.GetString(array);
                    Console.WriteLine(textFromXml);
                    return textFromXml;
                    //  var Xml = File.OpenRead(textFromXml);
                }

            }

        }

        public class SeriesDemo
        {
            public static void InterfaceDemo()
            {
                ByTwos ob = new ByTwos();
                for (int i = 0; i < 5; i++)
                    Console.WriteLine("Следующее число равно " + ob.GetNext());
                Console.WriteLine("\nСбросить");
                ob.Reset();
                for (int i = 0; i < 5; i++)
                    Console.WriteLine("Следующее число равно " + ob.GetNext());
                Console.WriteLine("\nНачать с числа 100");
                ob.SetStart(100);
                for (int i = 0; i < 5; i++)
                    Console.WriteLine("Следующее число равно " + ob.GetNext());
                ob.GetPrevious();
                for (int i = 100; i < 1; i--)
                    Console.WriteLine("предыдущее число равно " + ob.GetPrevious());
            }
        }
    }
}