using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public static class CustomInternetExplorer
    {
        [ThreadStatic]
        static IWebDriver driver = new InternetExplorerDriver();
     
        private static InternetExplorerOptions InternetExplorerOptions
        {
            get
            {
                var internetExplorerOptions = new InternetExplorerOptions
                {
                    PageLoadStrategy = PageLoadStrategy.Eager                   
                };

                new DriverManager().SetUpDriver(new InternetExplorerConfig());
                driver = new InternetExplorerDriver(internetExplorerOptions);
                return (InternetExplorerOptions)driver;
            }
        }
    }


}
