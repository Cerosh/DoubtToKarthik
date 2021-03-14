using System;
using OpenQA.Selenium;

namespace CSharpAutomationFrameworkLearningLevel7.Base
{
    public class Base
    {
        
        public BasePage CurrentPage { get; set; }
        private IWebDriver _driver { get; set; }
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            _driver = DriverContext.Driver;

            return pageInstance;
        }
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }


    }
}
