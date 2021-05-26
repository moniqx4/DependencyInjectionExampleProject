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

        private IDriverLogger _logger = new DriverLogger();

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
            return new EdgeDriver(edgeOptions);            

        }

        private SeleniumConfiguration BuildConfig(SeleniumConfiguration configuration)
        {
            _logger.Info($"New Driver for Test: {configuration.TestName} | {Guid.NewGuid()}");
            _logger.Info($"Driver Configuration: {configuration.ConfigName}");
            _logger.Info($"Browser: {configuration.BrowserType}");
            _logger.Info($"RunType: {configuration.RunType}");

            var config = new SeleniumConfiguration
            (
                configuration.ConfigName,
                configuration.Active,
                configuration.BrowserType,
                configuration.IsMobileEnabled,
                configuration.MobileDevices,
                configuration.Headless,
                configuration.StartUrl,
                configuration.TestName,
                configuration.RunType,
                configuration.Environment,
                configuration.Teams,
                configuration.TestCategory

             );


            return config;
        }
    }


}
