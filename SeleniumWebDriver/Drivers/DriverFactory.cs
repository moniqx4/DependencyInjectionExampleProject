using System;
using DataModelLibrary;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using SeleniumWebDriver.Drivers;
using SeleniumWebDriver.Types;

namespace DependencyInjectionExampleProject.SeleniumWebDriver.Drivers
{

    public class DriverFactory
    {
        public static void Build(SeleniumConfiguration configuration)
        {
            //var browserType = ConfigReader.GetConfigValue("BrowserType");

            if (configuration.RunType == RunType.Local)
            {
                switch (configuration.Browser)
                {
                    case BrowserType.Chrome:
                        new CustomChrome().ChromeOptions(configuration);                       
                        break;
                    case BrowserType.Firefox:
                        new CustomFirefox().FirefoxOptions(configuration);
                        break;
                    case BrowserType.Edge:
                        new CustomEdge().EdgeOptions(configuration);
                        break;
                    case BrowserType.InternetExplorer:
                        new CustomInternetExplorer().InternetExplorerOptions(configuration);
                        break;
                    default:
                        throw new ArgumentException($"{configuration.Browser} is not supported locally.");
                }
            }

            else if (configuration.RunType == RunType.Remote)
            {
                BuildRemoteDriver(configuration.Browser);
            }

            else
            {
                throw new ArgumentException($"{configuration.RunType} is invalid. Choose 'Local' or 'Remote'.");
            }
        }


        private static RemoteWebDriver BuildRemoteDriver(BrowserType browser)
        {
            var DOCKER_GRID_HUB_URI = new Uri("http://localhost:4444/wd/hub");

            RemoteWebDriver driver;

            switch (browser)
            {
                case BrowserType.Chrome:
                    var chromeOptions = new ChromeOptions
                    {
                        BrowserVersion = "",
                        PlatformName = "LINUX",
                    };

                    chromeOptions.AddArgument("--start-maximized");

                    driver = new RemoteWebDriver(DOCKER_GRID_HUB_URI, chromeOptions.ToCapabilities());
                    break;

                case BrowserType.Firefox:
                    var firefoxOptions = new FirefoxOptions
                    {
                        BrowserVersion = "",
                        PlatformName = "LINUX",
                    };

                    driver = new RemoteWebDriver(DOCKER_GRID_HUB_URI, firefoxOptions.ToCapabilities());
                    break;

                case BrowserType.InternetExplorer:
                    var internetexplorerOptions = new InternetExplorerOptions
                    {
                        BrowserVersion = "",
                        PlatformName = "LINUX",
                    };

                    driver = new RemoteWebDriver(DOCKER_GRID_HUB_URI, internetexplorerOptions.ToCapabilities());
                    break;

                case BrowserType.Edge:
                    var edgeOptions = new EdgeOptions
                    {
                        BrowserVersion = "",
                        PlatformName = "LINUX",
                    };

                    driver = new RemoteWebDriver(DOCKER_GRID_HUB_URI, edgeOptions.ToCapabilities());
                    break;

                default:
                    throw new ArgumentException($"{browser} is not supported remotely.");
            }

            return driver;
        }
   
    }
}