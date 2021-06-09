﻿using DataModelLibrary;
using DependencyInjectionExampleProject.SeleniumWebDriver.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace SeleniumWebDriver
{
    public class SeleniumDriver
    {
        [ThreadStatic]
        public static IWebDriver _driver;

        [ThreadStatic]
        private static IWebDriver _browserWait;
        

        public SeleniumDriver(SeleniumConfiguration config, IOptions options)
        {
            _driver = Driver.Build(config, options);
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (_browserWait == null || _driver == null)
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
            _driver.Close();
            _driver.Quit();
            _driver.Dispose();
            
        }

    }
}