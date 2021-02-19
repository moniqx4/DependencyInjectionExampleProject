using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using SeleniumWebDriver.Helper;
using SeleniumWebDriver.Type;
using SeleniumWebDriver.Types;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public class CustomEdge
    {
        [ThreadStatic]
        static IWebDriver driver = new EdgeDriver();
      
        private static EdgeOptions EdgeOptions
        {
            get
            {

                var edgeOptions = new EdgeOptions
                {
                    PageLoadStrategy = PageLoadStrategy.Eager                   
                };

                new DriverManager().SetUpDriver(new EdgeConfig());
                driver = new EdgeDriver(edgeOptions);
                return (EdgeOptions)driver;
            }
        }
    }


}
