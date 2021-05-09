using DataModelLibrary;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace SeleniumWebDriver.WebElements
{
    public interface ILocatorBuilder
    {
        IWebElement BuildLocator(LocatorModel locatorModel);

        IWebElement LocatorByIndex(LocatorModel locatorModel, int index);

        ReadOnlyCollection<IWebElement> GetLocators(LocatorModel locator);

        IWebElement BuildLocator(BaseLocatorModel locator, int waitTimeInSecs = 10);

        IWebElement LocatorByIndex(BaseLocatorModel locator, int index, int waitTimeInSecs = 10);

        ReadOnlyCollection<IWebElement> GetLocators(BaseLocatorModel locator, int waitTimeInSecs = 10);
    }
}
