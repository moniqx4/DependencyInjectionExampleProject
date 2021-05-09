using DataModelLibrary;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace SeleniumWebDriver.WebElements
{
    public interface ILocatorBuilder
    {
        IWebElement BuildLocator(BaseLocatorModel locator, int waitTimeInSecs = 10);

        IWebElement LocatorByIndex(BaseLocatorModel locator, int index, int waitTimeInSecs = 10);

        ReadOnlyCollection<IWebElement> GetLocators(BaseLocatorModel locator, int waitTimeInSecs = 10);
    }
}
