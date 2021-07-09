using System;
using System.IO;
using System.Runtime.CompilerServices;
using Unity;
//using Moq;


namespace ReaderXmlFiles
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //ReaderXML.ScanXML("C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\SampleXML");
           //ReaderXML.ScanXML();
           Console.WriteLine("Load");
           //SeriesDemo.InterfaceDemo();
     
        }
    }

 


    public  class ReaderXML
    {
        //public static void ScanXML(string XmlPath)
        public string  ScanXML()
        {
            string XmlPath = "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\SampleXML";
            string EmptyXmlFile = "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\EmptySampleXML";
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