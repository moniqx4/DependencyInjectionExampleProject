using System;
using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Helper;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public class CustomChrome
    {
        [ThreadStatic]
        static IWebDriver driver = new ChromeDriver();

        private IDriverLogger _logger = new DriverLogger();


        public CustomChrome()
        {          
        }

        public IWebDriver ChromeOptions(SeleniumConfiguration configuration)
        {
            var config = BuildConfig(configuration);

            var chromeOptions = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Eager
            };
            chromeOptions.AddArguments("--incognito");
            chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            if (config.Headless)
            {
                chromeOptions.AddArgument("--headless");
            }

            if (config.IsMobile)
            {
                chromeOptions.EnableMobileEmulation(config.MobileDevice.ToString());
            }

            //chromeOptions.AddLocalStatePreference("local", preferenceValue);  setup for local from config
            chromeOptions.PerformanceLoggingPreferences.IsCollectingPageEvents = true;           
            //chromeOptions.BrowserVersion = "";
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(chromeOptions);
            return driver;
           
        }

        private SeleniumConfiguration BuildConfig(SeleniumConfiguration configuration)
        {
            _logger.Info($"New Driver for Test: {configuration.TestName} | {Guid.NewGuid()}");
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
               IsMobile = configuration.IsMobile,
               TestName = configuration.TestName,
               MobileDevice = configuration.MobileDevice
             };


            return config;
        }

    }


}
