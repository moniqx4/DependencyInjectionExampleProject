using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public static class CustomFirefox
    {
        [ThreadStatic]
        static IWebDriver driver = new FirefoxDriver();
    
        private static FirefoxOptions FirefoxOptions
        {
            get
            {
                var firefoxOptions = new FirefoxOptions
                {
                    PageLoadStrategy = PageLoadStrategy.Eager                   
                };

                new DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver(FirefoxOptions);
                return (FirefoxOptions)driver;
            }
        }
    }
}
