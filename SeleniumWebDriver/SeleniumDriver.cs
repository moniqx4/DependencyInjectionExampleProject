using DependencyInjectionExampleProject.SeleniumWebDriver.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Drivers;
using System;

namespace SeleniumWebDriver
{
    public static class SeleniumDriver
    {
        [ThreadStatic]
        private static IWebDriver _browser;

        [ThreadStatic]
        private static IWebDriver _browserWait;
        

        public static IWebDriver Browser
        {
            get
            {
                if (_browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized.");
                }
                return _browser;
            }
            set
            {
                _browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (_browserWait == null || _browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized.");
                }
                return (WebDriverWait)_browserWait;
            }
            private set
            {
                _browserWait = (IWebDriver)value;
            }
        }

        public static void Build(string type, SeleniumConfiguration driverConfig)
        {
            //var browserType = ConfigReader.GetConfigValue("BrowserType");

            DriverFactory.Build(driverConfig);
            
        }

        /// <summary>
        /// Stops & Quits current WebDriver instance
        /// </summary>
        public static void StopBrowser()
        {
            Browser.Quit();
            Browser.Dispose();
            Browser = null;
            BrowserWait = null;
        }

    }
}
