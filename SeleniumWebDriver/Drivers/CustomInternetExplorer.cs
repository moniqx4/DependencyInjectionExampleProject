using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using SeleniumWebDriver.Helper;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Drivers
{
    public class CustomInternetExplorer
    {
       private IDriverLogger _logger = new DriverLogger();


        public IWebDriver InternetExplorerOptions(SeleniumConfiguration configuration)
        {
            var config = BuildConfig(configuration);

            var ieOptions = new InternetExplorerOptions
            {
                //PageLoadStrategy = PageLoadStrategy.Eager,
                EnsureCleanSession = true,
                UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss,
                EnableNativeEvents = true,
                EnablePersistentHover = true
            };

            //ieOptions.AddAdditionalCapability("runType", config.RunType);
            //ieOptions.AddAdditionalCapability("testName", testName); 
            ieOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            ieOptions.InitialBrowserUrl = config.StartUrl;
            //ieOptions.FileUploadDialogTimeout = 
            //ieOptions.BrowserVersion = "";
            new DriverManager().SetUpDriver(new InternetExplorerConfig());
            return new InternetExplorerDriver("./", ieOptions);           

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
