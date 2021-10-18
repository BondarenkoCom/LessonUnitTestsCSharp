using System;
using System.IO;
using System.Linq;
using System.Xml;


namespace XmlView
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load");

            string pathXmlReport = @"C:\Users\BondarenkoAS\MyRepos\LessonBaseCSharp\XmlView\xmlReport\ReportXML.xml";

            XmlDocument Xdoc = new XmlDocument();
            Xdoc.Load(pathXmlReport);
            XmlNode testNode = Xdoc.SelectSingleNode("/test-run/test-suite/test-suite/test-suite/test-case[4]/failure/message");
            if (testNode != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(testNode.InnerText);
            }

            //XmlElement xRoot = Xdoc.DocumentElement;
            //XmlNode root = Xdoc.FirstChild;


            //XmlNode StringNode = xRoot.SelectNodes("/test-run/test-suite/environment");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            //foreach (XmlNode xnode in xRoot )
            //{
            //    if (xnode.Attributes.Count > 0)
            //    {
            //        XmlNode attr = xnode.Attributes.GetNamedItem("name");
            //        //XmlNode attr = xnode.ParentNode;
            //        if (attr!= null)
            //            Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine(attr.Value);
            //    }
            //}
        }
    }
}
