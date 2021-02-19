using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public class CustomFirefox
    {       
        IWebDriver driver = new FirefoxDriver();
    
        private FirefoxOptions FirefoxOptions
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
