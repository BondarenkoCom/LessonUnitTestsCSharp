using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ReaderXmlFiles
{
    class Program
    {
        public static  void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //ReaderXML.ScanXML("C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\SampleXML");
           // ReaderXML.ScanXML();
             
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


}
