using JupiterNunitSeleniumTest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;

namespace SeleniumPromptTest
{ 
    public class StartChromeSelenium
    {
        BrowserOps brow = new BrowserOps();
        //private BrowserOpsOpera brow = new BrowserOpsOpera();
        String test_url = "https://www.selenium.dev/documentation/webdriver/js_alerts_prompts_and_confirmations/";
        IWebDriver _driver;


        [SetUp]
        public void Setup()
        {
            brow.Init_Browser();
            //brow.InitBrowserOpera();
        }


        [Test]
        [Obsolete]
        public void Tab_Cryptography_Test_Sign()
        {
            brow.Goto(test_url);
            _driver = brow.getDriver;


            //wait.Until(ExpectedConditions.AlertIsPresent());
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            //
            //try
            //{
            //
            // 
            //    IWebElement element = _driver.FindElement(By.XPath("//p[6]/a[1]"));
            //    element.Click();
            //
            //    var prompt = wait.Until(ExpectedConditions.AlertIsPresent());
            //
            //    prompt.SendKeys("Hello");
            //    prompt.Accept();
            //    Assert.AreEqual(prompt.Text.ToString(), "Hllo");
            //
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
            //ищем элемент по Xpath
            _driver.FindElement(By.XPath("//p[6]/a[1]")).Click();

            var alert = _driver.SwitchTo().Alert();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.AlertIsPresent());

            alert.SendKeys("Hello");
            //alert.SendKeys("Test");
            //Assert.AreEqual(alert.Text.ToString(), "Hllo");
            alert.Accept();
            //Assert.AreEqual(alert.Text.ToString(), "Hllo");

            //alert.SendKeys("Test");
            //_driver.SwitchTo().Alert().SendKeys("12345678");
            //System.Threading.Thread.Sleep(3000);
            // alert.Accept();



            //IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            //alert.SendKeys("Test");
            //System.Threading.Thread.Sleep(6000);
            //alert.SendKeys("Testdsssssssssssssssssss");
            //System.Threading.Thread.Sleep(6000);
            //
            //alert.Accept();

            //wait.Until(ExpectedConditions.AlertIsPresent());
            //IAlert alert = _driver.SwitchTo().Alert();

            //System.Threading.Thread.Sleep(13000);
            //string text = alert.Text;
            System.Threading.Thread.Sleep(10000);

            //System.Threading.Thread.Sleep(10000);

            //var fieldSignSuccess = _driver.FindElement(By.XPath("//*[@id='SignSuccess']"));
            //Assert.Pass(alert.Text);
            //Assert.Multiple(() =>
            //{
            //    Assert.AreEqual(fieldSignSuccess.Text, "Ge");
            //});


        }

        //[TearDown]
        //public void close_Browser()
        //{
        //    brow.Close();
        //}
        //
    }

}
