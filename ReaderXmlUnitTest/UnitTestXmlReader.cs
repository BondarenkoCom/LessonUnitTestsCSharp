using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ReaderXmlFiles;
using FluentAssertions;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ReaderXmlUnitTest
{
    public class XmlTests
    {
        //private string _TestXmlFile =
        //    "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\SampleXML";
        //
        //private string _ExpectedXmlFile =
        //    "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\ExpectedSampleXML";
        //
        //private string _EmptyXmlFile =
        //    "C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\EmptySampleXML";

        private string _NewactualNumber;

       // private XmlDocument document;
       // private ReaderXML _readerXml;
       //
       // [SetUp]
       // public void SetUp()
       // {
       //     this.document = new XmlDocument();
       //     this._readerXml = new ReaderXML();
       //     _NewactualNumber = "1234567890";
       // }

//
//        [Test]
//        public void TestXPath()
//        {
//            //Assert.AreEqual("Jdsf" , _readerXml.ScanXML());
//            Assert.Pass(_readerXml.ScanXML().ToString());
//        }
//
//        [Test]
//        //[TestCase("C:\\Users\\BondarenkoAS\\MyRepos\\LessonBaseCSharp\\ReaderXmlFiles\\SampleXML")]
//        //[Ignore("Temporarily disabled")]
//        public void Input_valid_XML_Lenght()
//        {
//            var _ReaderXML = new ReaderXML();
//            var result = _ReaderXML.ScanXML();
//            var ActResult = _ReaderXML.ScanXML();
//
//            Assert.AreEqual(result.Length, ActResult.Length);
//            //Assert.AreEqual(result.Length, "<note>\r\n<to>Tove</to>\r\n<from>Jani</from>\r\n<heading>Reminder</heading>\r\n<body>Don't forget me this weekend!</body>\r\n</note>".Length);
//        }
//

        [Test]
        public void TestNewFramework()
        {
            //FluentAssertions
            //Should() ���������� ��������  �  ��������� ������
            _NewactualNumber.Should().Be("1234567890");

        }


        [Test]
        public void TestOldFramework_1()
        {
            //Nunit
            Assert.That(_NewactualNumber, Is.EqualTo("1234567890"));

        }

     //   [Test]
     //   public void Input_Broken_Nums_UseRectMethod()
     //   {
     //       var _Rect = new Rect(w: 3, h: 2);
     //       var _RectUseData = new Rect.UseRect();
     //
     //
     //
     //   }



        [Test]
        [Ignore("in progress")]
        public void Input_Empty_Xml_File()
        {

        }

        [Test]
        [Ignore("in progress")]
        public void Check_Attribute_Xml()
        {
            //�������� ������ ������ ����� XML 
            //� ������� �� ������� ��������     <soap:Body>

        }

        [Test]
        [Ignore("in progress")]
        public void Check_Schema_Xml()
        {
            //��������� Schema �� �����������
        }

    }


}
