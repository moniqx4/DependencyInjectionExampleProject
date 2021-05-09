using DataModelLibrary;
using DependencyInjectionExampleProject.SeleniumWebDriver.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using System;


namespace SeleniumWebDriver
{
    public class SeleniumDriver
    {
        //[ThreadStatic]
        public static IWebDriver _browser;

        [ThreadStatic]
        private static IWebDriver _browserWait;
        

        public SeleniumDriver(SeleniumConfiguration config)
        {
            _browser = Driver.Build(config);
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
      

        /// <summary>
        /// Stops & Quits current WebDriver instance
        /// </summary>
        public static void StopBrowser()
        {
            _browser.Close();
            _browser.Quit();
            _browser.Dispose();
            
        }

    }
}
