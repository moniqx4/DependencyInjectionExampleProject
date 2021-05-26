﻿using DataModelLibrary;
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
        private readonly IDriverLogger _logger = new DriverLogger();
       
        public IWebDriver FirefoxOptions(SeleniumConfiguration configuration)
        {
            var config = BuildConfig(configuration);

            var ffOptions = new FirefoxOptions
            {
                PageLoadStrategy = PageLoadStrategy.Eager,
                UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss
            };

            ffOptions.AddAdditionalCapability("RunType", config.RunType);
            ffOptions.AddAdditionalCapability("TestName", config.TestName);
            
            ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            
            //ffOptions.BrowserVersion = "";
            //ffOptions.Profile();
            //ffOptions.BrowserExecutableLocation();
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver(ffOptions);           

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