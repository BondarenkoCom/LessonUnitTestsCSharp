using System;
using System.Reflection;
using NUnitLite;
using OpenQA.Selenium.Chrome;

namespace SeleniumNUnitConsoleTestLauncher
{
    class Program
    {
        static int Main(string[] args)
        {
            //return  new AutoRun(Assembly.GetAssembly(typeof(SeleniumNUnitConsoleTestLoad.Tests))).Execute(new string[0]);
            return new AutoRun(Assembly.GetAssembly(typeof(SeleniumNUnitConsoleTestLoad.Tests))).Execute(args);
        }
    }
}
