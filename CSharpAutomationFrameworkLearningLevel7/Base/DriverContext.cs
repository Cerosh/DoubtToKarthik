﻿using System;
using OpenQA.Selenium;

namespace CSharpAutomationFrameworkLearningLevel7.Base
{
    public static class DriverContext
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get => _driver;
            set => _driver = value;
        }
        public static Browser Browser { get; set; }
    }
}
