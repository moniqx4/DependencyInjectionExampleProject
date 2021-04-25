using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace SeleniumWebDriver
{
    public class Browser : IBrowser
    {
        /// <summary>
        /// Maximize the browser
        /// </summary>
        public void BrowserMaximize()
        {
            SeleniumDriver.Browser.Manage().Window.Maximize();
        }

        /// <summary>
        /// Minimize browser
        /// </summary>
        public void BrowserMinimize()
        {
            SeleniumDriver.Browser.Manage().Window.Minimize();
        }

        /// <summary>
        /// Refreshes browser
        /// </summary>
        public void BrowserRefresh()
        {
            SeleniumDriver.Browser.Navigate().Refresh();
        }

        /// <summary>
        /// Retrieves browser title 
        /// </summary>
        /// <returns>Browser Title</returns>
        public string GetBrowserTitle()
        {
            return SeleniumDriver.Browser.Title;
        }

        /// <summary>
        /// Retrieves browser's current URL
        /// </summary>
        /// <returns>URL</returns>
        public string GetBrowserUrl()
        {
            return SeleniumDriver.Browser.Url;
        }

        /// <summary>
        /// Moves backward in the browser
        /// </summary>
        public void MoveBackward()
        {
            SeleniumDriver.Browser.Navigate().Back();
        }

        /// <summary>
        /// Moves forward in the browser
        /// </summary>
        public void MoveForward()
        {
            SeleniumDriver.Browser.Navigate().Forward();
        }

        public void NavigateTo(string url)
        {
            SeleniumDriver.Browser.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Switches webdriver to specified iframe component
        /// </summary>
        /// <param name="frameElement">IFrame WebElement</param>
        public void SwitchToFrame(IWebElement frameElement)
        {
            SeleniumDriver.Browser.SwitchTo().Frame(frameElement);
        }

        /// <summary>
        /// Switches to the parent window 
        /// </summary>
        public void SwitchToParent()
        {
            var windowids = SeleniumDriver.Browser.WindowHandles;

            for (int i = windowids.Count - 1; i > 0; i--)
            {
                SeleniumDriver.Browser.SwitchTo().Window(windowids[i]);
                SeleniumDriver.Browser.Close();
            }
            SeleniumDriver.Browser.SwitchTo().Window(windowids[0]);
        }

        /// <summary>
        /// Switches to specified window
        /// </summary>
        /// <param name="index">Window index</param>
        public void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = SeleniumDriver.Browser.WindowHandles;

            if ((windows.Count - 1) < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }

            SeleniumDriver.Browser.SwitchTo().Window(windows[index]);
        }

        public IBrowser SwitchToAlert()
        {
            SeleniumDriver.Browser.SwitchTo().Alert();

            return this;
        }

        public string GetAlertText()
        {
            return SeleniumDriver.Browser.SwitchTo().Alert().Text;
        }

        public IBrowser SetTextInAlert(string text)
        {
            SeleniumDriver.Browser.SwitchTo().Alert().SendKeys(text);

            return this;
        }

        public void ClickAlertAcceptButton()
        {
            SeleniumDriver.Browser.SwitchTo().Alert().Accept();
        }

        public void DismissAlert()
        {
            SeleniumDriver.Browser.SwitchTo().Alert().Dismiss();
        }

        public void Close()
        {            
            SeleniumDriver.Browser.Close();
            SeleniumDriver.Browser.Dispose();
        }
    }
}
