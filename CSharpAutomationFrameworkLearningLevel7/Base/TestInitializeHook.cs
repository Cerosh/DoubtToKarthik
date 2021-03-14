using System;
using static CSharpAutomationFrameworkLearningLevel7.Base.Browser;
using CSharpAutomationFrameworkLearningLevel7.Helpers;
using CSharpAutomationFrameworkLearningLevel7.Config;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace CSharpAutomationFrameworkLearningLevel7.Base
{
    public abstract class TestInitializeHook 
    {
        public readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }
        public  void InitializeSettings()
        {
            System.Console.WriteLine("Inside InitializeSettings");
            ConfigReader.SetFrameworkSettings();
            LogHelper.CreateLogFile();
            OpenBrowser(Browser);
            LogHelper.Write("Initialised framework");
        }
        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    break;
            }
        }
        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelper.Write("Opened the browser");
        }
    }
}
