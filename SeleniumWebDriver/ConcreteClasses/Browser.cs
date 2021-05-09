using DataModelLibrary;
using OpenQA.Selenium;
using SeleniumWebDriver.ConcreteClasses;
using System.Collections.ObjectModel;

namespace SeleniumWebDriver
{
    public class Browser : SeleniumDriver, IBrowser
    {
        
        public Browser(SeleniumConfiguration config) : base(config)
        {           
        }

        /// <summary>
        /// Maximize the browser
        /// </summary>
        public void BrowserMaximize()
        {           
            _browser.Manage().Window.Maximize();
        }

        /// <summary>
        /// Minimize browser
        /// </summary>
        public void BrowserMinimize()
        {
            _browser.Manage().Window.Minimize();
        }

        /// <summary>
        /// Refreshes browser
        /// </summary>
        public INavigation BrowserRefresh()
        {
            _browser.Navigate().Refresh();

            return (INavigation)this;
        }

        /// <summary>
        /// Retrieves browser title 
        /// </summary>
        /// <returns>Browser Title</returns>
        public string GetBrowserTitle()
        {
            return _browser.Title;
        }

        /// <summary>
        /// Retrieves browser's current URL
        /// </summary>
        /// <returns>URL</returns>
        public string GetBrowserUrl()
        {
            return _browser.Url;
        }

        /// <summary>
        /// Moves backward in the browser
        /// </summary>
        public INavigation MoveBackward()
        {
           _browser.Navigate().Back();

            return (INavigation)this;
        }

        /// <summary>
        /// Moves forward in the browser
        /// </summary>
        public INavigation MoveForward()
        {
            _browser.Navigate().Forward();

            return (INavigation)this;
        }

        public INavigation NavigateTo(string url)
        {
            _browser.Navigate().GoToUrl(url);

            return (INavigation)this;
        }

        /// <summary>
        /// Switches webdriver to specified iframe component
        /// </summary>
        /// <param name="frameElement">IFrame WebElement</param>
        public ITargetLocator SwitchToFrame(IWebElement frameElement)
        {
            _browser.SwitchTo().Frame(frameElement);

            return (ITargetLocator)this;
        }

        /// <summary>
        /// Switches to the parent window 
        /// </summary>
        public ITargetLocator SwitchToParent()
        {
            var windowids = _browser.WindowHandles;

            for (int i = windowids.Count - 1; i > 0; i--)
            {
                _browser.SwitchTo().Window(windowids[i]);
                _browser.Close();
            }
            _browser.SwitchTo().Window(windowids[0]);

            return (ITargetLocator)this;
        }

        /// <summary>
        /// Switches to specified window
        /// </summary>
        /// <param name="index">Window index</param>
        public ITargetLocator SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = _browser.WindowHandles;

            if ((windows.Count - 1) < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }

            _browser.SwitchTo().Window(windows[index]);

            return (ITargetLocator)this;
        }

        public IBrowser SwitchToAlert()
        {
            _browser.SwitchTo().Alert();

            return this;
        }

        public string GetAlertText()
        {
            return _browser.SwitchTo().Alert().Text;
        }

        public IBrowser SetTextInAlert(string text)
        {
            _browser.SwitchTo().Alert().SendKeys(text);

            return this;
        }

       
        public void ClickAlertAcceptButton()
        {
            _browser.SwitchTo().Alert().Accept();
        }

        public void DismissAlert()
        {
            _browser.SwitchTo().Alert().Dismiss();
        }

        public void Close()
        {
            _browser.Close();
            _browser.Dispose();
        }

        //private ITargetLocator SwitchTo()
        //{
        //    //return (ITargetLocator)new DriverEventListener(config).Navigate(this);
        //}
    }
}
