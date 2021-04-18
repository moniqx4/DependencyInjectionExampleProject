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

        public IWebDriver ChromeOptions(SeleniumConfiguration configuration, string testName)
        {
            var config = BuildConfig(configuration, testName);

            var edgeOptions = new EdgeOptions();
            edgeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            edgeOptions.UseInPrivateBrowsing = true;
            edgeOptions.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;            
            edgeOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            if (config.Headless)
            {                
                edgeOptions.AddAdditionalCapability("RunHeadless", "--headless");
            }

            //edgeOptions.StartPage = "";
            new DriverManager().SetUpDriver(new EdgeConfig());
            return new EdgeDriver(edgeOptions);

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
