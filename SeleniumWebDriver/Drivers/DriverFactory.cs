using System;
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
        public static void Build(string type, BrowserType browser)
        {
            //var browserType = ConfigReader.GetConfigValue("BrowserType");

            if (type == "local")
            {
                switch (browser)
                {
                    case BrowserType.Chrome:
                        new CustomChrome();                        
                        break;
                    case BrowserType.Firefox:
                        new CustomFirefox();
                        break;
                    case BrowserType.Edge:
                        new CustomEdge();
                        break;
                    case BrowserType.InternetExplorer:
                        new CustomInternetExplorer();
                        break;
                    default:
                        throw new ArgumentException($"{browser} is not supported locally.");
                }
            }

            else if (type == "remote")
            {
                BuildRemoteDriver(browser);
            }

            else
            {
                throw new ArgumentException($"{type} is invalid. Choose 'local' or 'remote'.");
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