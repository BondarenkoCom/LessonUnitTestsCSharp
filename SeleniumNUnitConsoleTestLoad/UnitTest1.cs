using System;
using JupiterNunitSeleniumTest;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumNUnitConsoleTestLoad
{
    [TestFixture]
    public class Tests
    {

        BrowserOps brow = new BrowserOps();
        String test_url = "https://jupiter-r.taxcom.ru/";
        IWebDriver _driver;

        [Test]
        public void Test_Selenium_Start()
        {



            brow.Init_Browser();
            brow.Goto(test_url);
            _driver = brow.getDriver;

            var buttonTabList = _driver.FindElement(By.XPath("//li[2]/a[1]"));
            buttonTabList.Click();
            System.Threading.Thread.Sleep(4000);

            var buttonGetAllCertificatesFromStore =
                _driver.FindElement(By.XPath("//*[@id='GetAllCertificatesFromStore']"));
            buttonGetAllCertificatesFromStore.Click();


            var elementAnswer = _driver.FindElement(By.XPath("//table[2]/thead[1]/tr[1]/th[2]"));
            var elementAnswerSerialNum = _driver.FindElement(By.XPath("//table[2]/thead[1]/tr[1]/th[3]"));
            var elementAnswerThump = _driver.FindElement(By.XPath("//table[2]/thead[1]/tr[1]/th[4]"));
            System.Threading.Thread.Sleep(12500);

            Assert.Multiple(() =>
            {
                Assert.That(elementAnswer.Text, Is.EqualTo("Cn"));
                Assert.That(elementAnswerSerialNum.Text, Is.EqualTo("SerialNumber"));
                Assert.That(elementAnswerThump.Text, Is.EqualTo("Thumb"));
            });
            System.Threading.Thread.Sleep(500);
            
        }

        //[TearDown]
        //public void close_Browser()
        //{
        //   brow.Close();
        //}
    }
}