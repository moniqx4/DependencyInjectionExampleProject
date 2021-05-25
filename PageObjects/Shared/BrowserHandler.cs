using OpenQA.Selenium;
using SeleniumWebDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.Shared
{
    public class BrowserHandler : IBrowserHandler
    {
        private readonly IWebDriver _browser;
        public BrowserHandler(IWebDriver browser)
        {
            _browser = browser;
        }

        public IWebDriver Browser()
        {
            return _browser;
        }
    }
}
