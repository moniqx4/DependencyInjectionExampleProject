using System;
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

        private ILogger _logger = new TestLogger();


        public CustomChrome()
        {          
        }

        public IWebDriver ChromeOptions(SeleniumConfiguration configuration, string testName)
        {
            var config = BuildConfig(configuration, testName);

            var chromeOptions = new ChromeOptions();
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            chromeOptions.AddArguments("--incognito");
            chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            if (config.Headless)
            {
                chromeOptions.AddArgument("--headless");
            }
            //chromeOptions.EnableMobileEmulation(),
            //chromeOptions.AddLocalStatePreference("local", preferenceValue);  setup for local from config
            //chromeOptions.PerformanceLoggingPreferences.IsCollectingPageEvents = true;           
            //chromeOptions.BrowserVersion = "";
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver(chromeOptions);
           
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
