using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NuGet.Frameworks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ReaderXmlFiles;



namespace ReaderXmlUnitTest 
{
    [TestFixture]
    public  class Tests
    {

        private string _TestXmlFile = "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\SampleXML";
        private string _ExpectedXmlFile = "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\ExpectedSampleXML";
        private  string _EmptyXmlFile = "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\EmptySampleXML";
     


        [Test]
        public void Input_valid_XML_Lenght()
        {
            var _ReaderXML = new ReaderXML();

            var result = _ReaderXML.ScanXML();

            //Assert

            Assert.AreEqual(result.Length, "<note>\r\n<to>Tove</to>\r\n<from>Jani</from>\r\n<heading>Reminder</heading>\r\n<body>Don't forget me this weekend!</body>\r\n</note>".Length);
            //Assert.AreNotEqual(result.Length, "<note>\r\n<to>Tove</to>\r\n<from>Jani</from>\r\n<heading>Reminder</heading>\r\n<body>Don't forget me this weekend!</body>\r\n</note>".Length);
            //Assert.That( result.Length , Is.Not.Length);
            //Assert.That(result.Length, Does.Exist);
            //сделать проверку на формат файла
        }

        [Test]
        [Ignore("in progress")]
        public void Input_Empty_Xml_File()
        {

        }

        [Test]
        [Ignore("in progress")]
        public void Check_Attribute_Xml()
        {
            //проверка данных самого файла XML 
            //к примеру на наличие атрибута     <soap:Body>

        }

        [Test]
        [Ignore("in progress")]
        public void Check_Schema_Xml()
        {
            //проверить Schema на соотвествие

        }

    }

}