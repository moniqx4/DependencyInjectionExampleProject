using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using SeleniumWebDriver.Helper;
using SeleniumWebDriver.Type;
using SeleniumWebDriver.Types;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver
{
    public partial class DriverContext : IDriverContext
    {
        private IWebDriver _driver;

        public string TestTitle { get; set; }
        public string CurrentDirectory { get; set; }

        private readonly Collection<ErrorDetail> verifyMessages = new Collection<ErrorDetail>();


        /// <summary>
        /// Gets driver Handle.
        /// </summary>
        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [test failed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [test failed]; otherwise, <c>false</c>.
        /// </value>
        public bool IsTestFailed { get; set; }

        private static Dictionary<IWebDriver, bool> driversAngularSynchronizationEnable =
            new Dictionary<IWebDriver, bool>();

        /// <summary>
        /// Method return true or false is driver is synchronized with angular.
        /// </summary>
        /// <param name="driver">Provide driver.</param>
        /// <returns>If driver is synchornized with angular return true if not return false.</returns>
        public static bool IsDriverSynchronizationWithAngular(IWebDriver driver)
        {
            return driversAngularSynchronizationEnable.ContainsKey(driver) && driversAngularSynchronizationEnable[driver];
        }

        /// <summary>
        /// Set angular synchronization for driver.
        /// </summary>
        /// <param name="driver">Provide driver.</param>
        /// <param name="enable">Set true to enable.</param>
        public static void SetAngularSynchronizationForDriver(IWebDriver driver, bool enable)
        {
            if (!enable && driversAngularSynchronizationEnable.ContainsKey(driver))
            {
                driversAngularSynchronizationEnable.Remove(driver);
            }

            if (enable && !driversAngularSynchronizationEnable.ContainsKey(driver))
            {
                driversAngularSynchronizationEnable.Add(driver, true);
            }

            if (enable && driversAngularSynchronizationEnable.ContainsKey(driver))
            {
                driversAngularSynchronizationEnable[driver] = true;
            }
        }

        public string ScreenShotFolder
        {
            get
            {
                return FilesHelper.GetFolder(BaseConfig.ScreenShotFolder, this.CurrentDirectory);
            }
        }


        private FirefoxOptions FirefoxOptions
        {
            get
            {

                var firefoxOptions = new FirefoxOptions
                {
                    PageLoadStrategy = PageLoadStrategy.Eager,
                };

                new DriverManager().SetUpDriver(new FirefoxConfig());
                _driver = new FirefoxDriver(firefoxOptions);
                return (FirefoxOptions)_driver;
            }
        }

        private ChromeOptions ChromeOptions
        {
            get
            {

                var chromeOptions = new ChromeOptions
                {
                    PageLoadStrategy = PageLoadStrategy.Eager,
                    Arguments = { }
                };

                new DriverManager().SetUpDriver(new ChromeConfig());
                _driver = new ChromeDriver(chromeOptions);
                return (ChromeOptions)_driver;
            }
        }

        private EdgeOptions EdgeOptions
        {
            get
            {

                var edgeOptions = new EdgeOptions
                {
                    PageLoadStrategy = PageLoadStrategy.Eager,
                    UseInPrivateBrowsing = true,

                };

                new DriverManager().SetUpDriver(new EdgeConfig());
                _driver = new EdgeDriver(edgeOptions);
                return (EdgeOptions)_driver;
            }
        }

        private InternetExplorerOptions InternetExplorerOptions
        {
            get
            {

                InternetExplorerOptions internetOptions = new InternetExplorerOptions
                {
                    PageLoadStrategy = PageLoadStrategy.Eager,
                    EnsureCleanSession = true,
                    IgnoreZoomLevel = true,
                };

                new DriverManager().SetUpDriver(new InternetExplorerConfig());
                _driver = new InternetExplorerDriver(internetOptions);
                return (InternetExplorerOptions)_driver;
            }
        }

        /// <summary>
        /// Takes the screenshot.
        /// </summary>
        /// <returns>An image of the page currently loaded in the browser.</returns>
        public Screenshot TakeScreenshot()
        {
            try
            {
                var screenshotDriver = (ITakesScreenshot)_driver;
                var screenshot = screenshotDriver.GetScreenshot();
                return screenshot;
            }
            catch (NullReferenceException)
            {
                //Logger.Error("Test failed but was unable to get webdriver screenshot."); TODO 
            }
            catch (UnhandledAlertException)
            {
                //Logger.Error("Test failed but was unable to get webdriver screenshot."); TODO
            }

            return null;
        }

        /// <summary>
        /// Maximizes the current window if it is not already maximized.
        /// </summary>
        public void WindowMaximize()
        {
            _driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Deletes all cookies from the page.
        /// </summary>
        public void DeleteAllCookies()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
        }

        /// <summary>
        /// Starts the specified Driver.
        /// </summary>
        public void Start()
        {
            switch (BaseConfig.Browser)
            {

                case BrowserType.Chrome:                  
                    _driver = new ChromeDriver(ChromeOptions);
                    break;
                case BrowserType.Edge:
                    _driver = new EdgeDriver(EdgeOptions);
                    break;
                case BrowserType.Firefox:
                    _driver = new FirefoxDriver(FirefoxOptions);
                    break;
                case BrowserType.InternetExplorer:
                    _driver = new InternetExplorerDriver(InternetExplorerOptions);
                    break;
                default:
                    throw new Exception("Invalid BrowserType, can't start Browser");

            }
        }

        //private void SetupRemoteWebDriver()
        //{
        //    NameValueCollection driverCapabilitiesConf = new NameValueCollection();
        //    NameValueCollection settings = new NameValueCollection();

        //    //driverCapabilitiesConf = ConfigurationManager.GetSection("DriverCapabilities") as NameValueCollection;
        //    //settings = ConfigurationManager.GetSection("environments/" + this.CrossBrowserEnvironment) as NameValueCollection; //net4.x

        //    driverCapabilitiesConf = BaseConfig.GetNameValueCollectionFromAppsettings("DriverCapabilities");
        //    settings = BaseConfig.GetNameValueCollectionFromAppsettings("environments:" + CrossBrowserEnvironment);

        //   var browserType = GetBrowserTypeForRemoteDriver(settings);

        //    switch (browserType)
        //    {
        //        case BrowserType.Firefox:
        //            FirefoxOptions firefoxOptions = new FirefoxOptions();
        //            firefoxOptions.Proxy = this.CurrentProxy();
        //            this.SetRemoteDriverBrowserOptions(driverCapabilitiesConf, settings, firefoxOptions);
        //            this.driver = new RemoteWebDriver(BaseConfig.RemoteWebDriverHub, this.SetDriverOptions(firefoxOptions).ToCapabilities());
        //            break;
        //        case BrowserType.Android:
        //        case BrowserType.Chrome:
        //            ChromeOptions chromeOptions = new ChromeOptions();
        //            chromeOptions.Proxy = this.CurrentProxy();
        //            this.SetRemoteDriverBrowserOptions(driverCapabilitiesConf, settings, chromeOptions);
        //            this.driver = new RemoteWebDriver(BaseConfig.RemoteWebDriverHub, this.SetDriverOptions(chromeOptions).ToCapabilities());
        //            break;
        //        case BrowserType.Iphone:
        //        case BrowserType.Safari:
        //            SafariOptions safariOptions = new SafariOptions();
        //            this.SetRemoteDriverOptions(driverCapabilitiesConf, settings, safariOptions);
        //            this.driver = new RemoteWebDriver(BaseConfig.RemoteWebDriverHub, this.SetDriverOptions(safariOptions).ToCapabilities());
        //            break;
        //        case BrowserType.Edge:
        //            EdgeOptions egEdgeOptions = new EdgeOptions();
        //            this.SetRemoteDriverOptions(driverCapabilitiesConf, settings, egEdgeOptions);
        //            this.driver = new RemoteWebDriver(BaseConfig.RemoteWebDriverHub, this.SetDriverOptions(egEdgeOptions).ToCapabilities());
        //            break;
        //        case BrowserType.IE:
        //        case BrowserType.InternetExplorer:
        //            InternetExplorerOptions internetExplorerOptions = new InternetExplorerOptions();
        //            internetExplorerOptions.Proxy = this.CurrentProxy();
        //            this.SetRemoteDriverBrowserOptions(driverCapabilitiesConf, settings, internetExplorerOptions);
        //            this.driver = new RemoteWebDriver(BaseConfig.RemoteWebDriverHub, this.SetDriverOptions(internetExplorerOptions).ToCapabilities());
        //            break;
        //        default:
        //            throw new NotSupportedException(
        //                string.Format(CultureInfo.CurrentCulture, "Driver {0} is not supported", this.CrossBrowserEnvironment));
        //    }
        //}
    }
}
