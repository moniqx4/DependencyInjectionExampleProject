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
        [ThreadStatic]
        static IWebDriver driver = new InternetExplorerDriver();

        private ILogger _logger = new TestLogger();


        public IWebDriver InternetExplorerOptions(SeleniumConfiguration configuration, string testName)
        {
            var config = BuildConfig(configuration, testName);

            var ieOptions = new InternetExplorerOptions();
            ieOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            ieOptions.EnsureCleanSession = true;
            ieOptions.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;
            ieOptions.EnableNativeEvents = true;
            ieOptions.EnablePersistentHover = true;            
            ieOptions.AddAdditionalCapability("runType", config.RunType);
            ieOptions.AddAdditionalCapability("testName", testName); 
            ieOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            //ieOptions.InitialBrowserUrl = config.
            //ieOptions.FileUploadDialogTimeout = 
            //ieOptions.BrowserVersion = "";
            new DriverManager().SetUpDriver(new InternetExplorerConfig());
            return new InternetExplorerDriver(ieOptions);

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
