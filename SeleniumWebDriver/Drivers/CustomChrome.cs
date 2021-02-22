using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public class CustomChrome
    {
        [ThreadStatic]
        static IWebDriver driver = new ChromeDriver();

        public CustomChrome()
        {

        }
       
        private static ChromeOptions ChromeOptions
        {
            get
            {
                var chromeOptions = new ChromeOptions
                {
                    PageLoadStrategy = PageLoadStrategy.Eager,
                    Arguments = { }
                };

                new DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver(chromeOptions);
                return (ChromeOptions)driver;

            }
        }
    }


}
