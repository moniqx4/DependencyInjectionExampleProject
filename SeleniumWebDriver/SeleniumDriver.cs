using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Drivers;
using SeleniumWebDriver.Types;
using System;

namespace SeleniumWebDriver
{
    public static class SeleniumDriver
    {
        [ThreadStatic]
        private static IWebDriver _browser;

        [ThreadStatic]
        private static IWebDriver _browserWait;
        

        public static IWebDriver Browser
        {
            get
            {
                if (_browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized.");
                }
                return _browser;
            }
            set
            {
                _browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (_browserWait == null || _browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized.");
                }
                return (WebDriverWait)_browserWait;
            }
            private set
            {
                _browserWait = (IWebDriver)value;
            }
        }

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

        //public static IWebElement FindElement(By by, string elementName)
        //{
        //    return new Element(Browser.FindElement(by), elementName)
        //    {
        //        FoundBy = by
        //    };
        //}

        //public static Elements FindElements(By by)
        //{
        //    return new Elements(Browser.FindElements(by))
        //    {
        //        FoundBy = by
        //    };
        //}


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

        /// <summary>
        /// Stops & Quits current WebDriver instance
        /// </summary>
        public static void StopBrowser()
        {
            Browser.Quit();
            Browser.Dispose();
            Browser = null;
            BrowserWait = null;
        }

    }
}
