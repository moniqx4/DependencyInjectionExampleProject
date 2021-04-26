using DataModelLibrary;
using OpenQA.Selenium;
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
        public void BrowserRefresh()
        {
            _browser.Navigate().Refresh();
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
        public void MoveBackward()
        {
            _browser.Navigate().Back();
        }

        /// <summary>
        /// Moves forward in the browser
        /// </summary>
        public void MoveForward()
        {
            _browser.Navigate().Forward();
        }

        public void NavigateTo(string url)
        {
            _browser.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Switches webdriver to specified iframe component
        /// </summary>
        /// <param name="frameElement">IFrame WebElement</param>
        public void SwitchToFrame(IWebElement frameElement)
        {
            _browser.SwitchTo().Frame(frameElement);
        }

        /// <summary>
        /// Switches to the parent window 
        /// </summary>
        public void SwitchToParent()
        {
            var windowids = _browser.WindowHandles;

            for (int i = windowids.Count - 1; i > 0; i--)
            {
                _browser.SwitchTo().Window(windowids[i]);
                _browser.Close();
            }
            _browser.SwitchTo().Window(windowids[0]);
        }

        /// <summary>
        /// Switches to specified window
        /// </summary>
        /// <param name="index">Window index</param>
        public void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = _browser.WindowHandles;

            if ((windows.Count - 1) < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }

            _browser.SwitchTo().Window(windows[index]);
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
    }
}
