using OpenQA.Selenium;
using SeleniumWebDriver.Type;
using SeleniumWebDriver.WebElements;
using System;

namespace SeleniumWebDriver
{
    public class SeleniumDriver : IDriver
    {
        //protected static IWebDriver Driver { get; set; }
        private readonly LocatorBuilder _locatorBuilder;

        protected DriverContext DriverContext { get; set; }

        public SeleniumDriver(DriverContext driverContext, LocatorBuilder locatorBuilder)
        {
            DriverContext = driverContext;
            _locatorBuilder = locatorBuilder;
            //Driver = driverContext.Driver;
        }

        public void ClickElement(Locator locatorType, string locator)
        {
            var ele = _locatorBuilder.BuildLocator(locatorType, locator);
            DriverContext.Current.FindElement((By)ele).Click();
        }

        public void ClickElement(ElementLocator eleLocator)
        {
            var ele = _locatorBuilder.BuildLocator(eleLocator.Kind, eleLocator.Value);
            DriverContext.Current.FindElement((By)ele).Click();           
        }
    
        public void SetText(Locator locatorType, string locator, string text)
        {
            var ele = _locatorBuilder.BuildLocator(locatorType, locator);
            DriverContext.Current.FindElement((By)ele).SendKeys(text);
        }

        public void SetText(ElementLocator eleLocator, string text)
        {
            var ele = _locatorBuilder.BuildLocator(eleLocator.Kind, eleLocator.Value);
            DriverContext.Current.FindElement((By)ele).SendKeys(text);
        }

        public void NavigateTo(string url)
        {            
            DriverContext.Current.Navigate().GoToUrl(url);
        }
    
    }
}
