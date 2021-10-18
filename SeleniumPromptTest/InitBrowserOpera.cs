using OpenQA.Selenium;
using OpenQA.Selenium.Opera;

namespace JupiterNunitSeleniumTest
{
    public class BrowserOpsOpera
    {
        private IWebDriver _webDriver;

        public void InitBrowserOpera()
        {
            OperaDriverService service = OperaDriverService.CreateDefaultService(@"..\..\..\drivers");
            _webDriver = new OperaDriver(service, new OperaOptions());
            _webDriver.Manage().Window.Maximize();

        }

        public IWebDriver getDriver
        {
            get { return _webDriver; }
        }

        public string Title
        {
            get { return _webDriver.Title; }
        }

        public void Goto(string url)
        {
            _webDriver.Url = url;
        }

        public void Close()
        {
            _webDriver.Quit();
        }
    }
}