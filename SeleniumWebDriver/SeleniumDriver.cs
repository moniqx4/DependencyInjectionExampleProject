using OpenQA.Selenium;
using SeleniumWebDriver.Extensions;
using SeleniumWebDriver.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver
{
    public class SeleniumDriver : IDriver
    {
        protected IWebDriver Driver { get; set; }

        protected DriverContext DriverContext { get; set; }

        public SeleniumDriver(DriverContext driverContext)
        {
            DriverContext = driverContext;
            Driver = driverContext.Driver;
        }

        public void ClickElement(Locator locator)
        {
            throw new NotImplementedException();
        }

        public void ClickElement(Locator type, string locator)
        {
            throw new NotImplementedException();
        }

        public void GetDriver()
        {
            DriverContext.Start();
        }

        public void SetText(Locator type, string locator, string text)
        {
            // SearchContextExtensions.GetElement(type, locator, text,60, "Unable to Locate Element");            
         
        }
    }
}
