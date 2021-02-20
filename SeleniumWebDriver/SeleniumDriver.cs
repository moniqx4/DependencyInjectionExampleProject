using OpenQA.Selenium;
using SeleniumWebDriver.Type;
using System;
using SeleniumWebDriver.Extensions;

namespace SeleniumWebDriver
{
    public class SeleniumDriver : IDriver
    {
        //protected static IWebDriver Driver { get; set; }

        protected DriverContext DriverContext { get; set; }

        public SeleniumDriver(DriverContext driverContext)
        {
            DriverContext = driverContext;
            //Driver = driverContext.Driver;
        }

        public void ClickElement(string locatorType, string element)
        {
            //ElementLocator locator
            //locator.Kind = Locator.Id;
            //locator.Value = element;
            //DriverContext.Current.FindElement(by(locatorType), element).Click();
            //DriverContext.Current.FindElement(By.XPath(element)).Click();
            //throw new NotImplementedException();
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
