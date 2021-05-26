using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace SeleniumWebDriver
{
    public class Browser : IBrowser
    {        

        [ThreadStatic]
        static IWebDriver _driver;

        public Browser()
        {            
        }

        public IWebDriver BrowserAction()
        {
            return _driver;
        }

        /// <summary>
        /// Maximize the browser
        /// </summary>
        public void BrowserMaximize()
        {
            _driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Minimize browser
        /// </summary>
        public void BrowserMinimize()
        {
            _driver.Manage().Window.Minimize();
        }

        /// <summary>
        /// Refreshes browser
        /// </summary>
        public INavigation BrowserRefresh()
        {
            _driver.Navigate().Refresh();

            return (INavigation)this;
        }

        /// <summary>
        /// Retrieves browser title 
        /// </summary>
        /// <returns>Browser Title</returns>
        public string GetBrowserTitle()
        {
            return _driver.Title;
        }

        /// <summary>
        /// Retrieves browser's current URL
        /// </summary>
        /// <returns>URL</returns>
        public string GetBrowserUrl()
        {
            return _driver.Url;
        }

        /// <summary>
        /// Moves backward in the browser
        /// </summary>
        public INavigation MoveBackward()
        {
            _driver.Navigate().Back();

            return (INavigation)this;
        }

        /// <summary>
        /// Moves forward in the browser
        /// </summary>
        public INavigation MoveForward()
        {
            _driver.Navigate().Forward();

            return (INavigation)this;
        }

        public INavigation NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);

            return (INavigation)this;
        }

        /// <summary>
        /// Switches webdriver to specified iframe component
        /// </summary>
        /// <param name="frameElement">IFrame WebElement</param>
        public ITargetLocator SwitchToFrame(IWebElement frameElement)
        {
            _driver.SwitchTo().Frame(frameElement);

            return (ITargetLocator)this;
        }

        /// <summary>
        /// Switches to the parent window 
        /// </summary>
        public ITargetLocator SwitchToParent()
        {
            var windowids = _driver.WindowHandles;

            for (int i = windowids.Count - 1; i > 0; i--)
            {
                _driver.SwitchTo().Window(windowids[i]);
                _driver.Close();
            }
            _driver.SwitchTo().Window(windowids[0]);

            return (ITargetLocator)this;
        }

        /// <summary>
        /// Switches to specified window
        /// </summary>
        /// <param name="index">Window index</param>
        public ITargetLocator SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = _driver.WindowHandles;

            if ((windows.Count - 1) < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }

            _driver.SwitchTo().Window(windows[index]);

            return (ITargetLocator)this;
        }

        public IBrowser SwitchToAlert()
        {
            _driver.SwitchTo().Alert();

            return this;
        }

        public string GetAlertText()
        {
            return _driver.SwitchTo().Alert().Text;
        }

        public IBrowser SetTextInAlert(string text)
        {
            _driver.SwitchTo().Alert().SendKeys(text);

            return this;
        }

       
        public void ClickAlertAcceptButton()
        {
            _driver.SwitchTo().Alert().Accept();
        }

        public void DismissAlert()
        {
            _driver.SwitchTo().Alert().Dismiss();
        }

        public void Close()
        {
            _driver.Close();
            _driver.Dispose();
        }

        //private ITargetLocator SwitchTo()
        //{
        //    //return (ITargetLocator)new DriverEventListener(config).Navigate(this);
        //}
    }
}
