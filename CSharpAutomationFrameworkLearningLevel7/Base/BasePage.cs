using System;
using OpenQA.Selenium;

namespace CSharpAutomationFrameworkLearningLevel7.Base
{
    public abstract class BasePage : Base
    {
        public IWebDriver _driver;
        public BasePage()
        {
            _driver = DriverContext.Driver;
        }
    }
}
