using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using SeleniumWebDriver.Helper;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public class CustomEdge
    {
        [ThreadStatic]
        static IWebDriver driver = new EdgeDriver();

        private ILogger _logger = new TestLogger();

        public IWebDriver EdgeOptions(SeleniumConfiguration configuration)
        {
            var config = BuildConfig(configuration);

            var edgeOptions = new EdgeOptions();
            edgeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            edgeOptions.UseInPrivateBrowsing = true;
            edgeOptions.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;            
            edgeOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            if (config.Headless)
            {                
                edgeOptions.AddAdditionalCapability("RunHeadless", "--headless");
            }

            edgeOptions.StartPage = config.StartUrl;
           
            new DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver(edgeOptions);
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
                MobileDevice = MobileDevices.None
            };


            return config;
        }
    }


}
