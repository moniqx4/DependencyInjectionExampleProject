using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SeleniumWebDriver.Drivers;
using SeleniumWebDriver.Helper;
using SeleniumWebDriver.Type;
using SeleniumWebDriver.Types;

namespace SeleniumWebDriver
{
    public partial class DriverContext
    {
        [ThreadStatic]
        private static IWebDriver _driver;        

        public string TestTitle { get; set; }       

        public string CurrentScreenshotDirectory { get; set; }

        private readonly Collection<ErrorDetail> verifyMessages = new Collection<ErrorDetail>();

        /// <summary>
        /// Gets driver Handle.
        /// </summary>
        public IWebDriver Driver
        {
            get
            {
                return Current;
            }
        }

        public static IWebDriver Current => _driver ?? throw new NullReferenceException();

        public static void Goto()
        {
            Current.Navigate().GoToUrl(BaseConfig.Url);
        }

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
        public static void SetAngularSynchronizationForDriver(bool enable)
        {
            if (!enable && driversAngularSynchronizationEnable.ContainsKey(Current))
            {
                driversAngularSynchronizationEnable.Remove(Current);
            }

            if (enable && !driversAngularSynchronizationEnable.ContainsKey(Current))
            {
                driversAngularSynchronizationEnable.Add(Current, true);
            }

            if (enable && driversAngularSynchronizationEnable.ContainsKey(Current))
            {
                driversAngularSynchronizationEnable[Current] = true;
            }
        }

        public string ScreenShotFolder
        {
            get
            {
                return FilesHelper.GetFolder(BaseConfig.ScreenShotFolder, this.CurrentScreenshotDirectory);
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
                var screenshotDriver = (ITakesScreenshot)Current;
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
            Current.Manage().Window.Maximize();
        }

        /// <summary>
        /// Deletes all cookies from the page.
        /// </summary>
        public void DeleteAllCookies()
        {
            Current.Manage().Cookies.DeleteAllCookies();
        }

        /// <summary>
        /// Starts the specified Driver.
        /// </summary>
        public static void Start()
        {
            switch (BaseConfig.Browser)
            {

                case BrowserType.Chrome:
                    new CustomChrome();                    
                    break;
                case BrowserType.Edge:
                    new CustomEdge();
                    break;
                case BrowserType.Firefox:
                    new CustomFirefox();
                    break;
                case BrowserType.InternetExplorer:
                    new CustomInternetExplorer();
                    break;
                default:
                    throw new Exception("Invalid BrowserType, can't start Browser");

            }
        }

        //private void SetupRemoteWebDriver()
         
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
