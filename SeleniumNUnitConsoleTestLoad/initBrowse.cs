﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace JupiterNunitSeleniumTest
{
    public class BrowserOps
    {
        public IWebDriver webDriver;

        public void Init_Browser()
        {


            //Drop
            //webDriver = new ChromeDriver(@"..\..\..\drivers");
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();


        }
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }

        public string Title
        {
            get { return webDriver.Title; }
        }

        public void Goto(string url)
        {
            webDriver.Url = url;
        }

        //public void Close()
        //{
        //    webDriver.Quit();
        //}


    }
}