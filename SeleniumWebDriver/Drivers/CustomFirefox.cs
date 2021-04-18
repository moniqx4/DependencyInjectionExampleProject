using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumWebDriver.Helper;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public class CustomFirefox
    {
        [ThreadStatic]
        static IWebDriver driver = new FirefoxDriver();

        private ILogger _logger = new TestLogger();

        //private FirefoxOptions FirefoxOptions
        //{
        //    get
        //    {
        //        var firefoxOptions = new FirefoxOptions
        //        {
        //            PageLoadStrategy = PageLoadStrategy.Eager                   
        //        };

        //        new DriverManager().SetUpDriver(new FirefoxConfig());
        //        driver = new FirefoxDriver(FirefoxOptions);
        //        return (FirefoxOptions)driver;
        //    }
        //}

        public IWebDriver FirefoxOptions(SeleniumConfiguration configuration, string testName)
        {
            var config = BuildConfig(configuration, testName);

            var ffOptions = new FirefoxOptions();
            ffOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            
            ffOptions.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;           
            
            ffOptions.AddAdditionalCapability("RunType", config.RunType);
            ffOptions.AddAdditionalCapability("TestName", testName);
            
            ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            //ffOptions.BrowserVersion = "";
            //ffOptions.Profile();
            //ffOptions.BrowserExecutableLocation();
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver(ffOptions);

        }


        private SeleniumConfiguration BuildConfig(SeleniumConfiguration configuration, string testName)
        {
            _logger.Info($"New Driver for Test: {testName} | {Guid.NewGuid()}");
            _logger.Info($"Driver Configuration: {configuration.Name}");
            _logger.Info($"Browser: {configuration.Browser}");
            _logger.Info($"RunType: {configuration.RunType}");

            var config = new SeleniumConfiguration()
            {
                Browser = configuration.Browser,
                Active = configuration.Active,
                RunType = configuration.RunType,
                Headless = configuration.Headless,
                Name = configuration.Name,
                IsMobile = configuration.IsMobile
            };


            return config;
        }
    }
}
