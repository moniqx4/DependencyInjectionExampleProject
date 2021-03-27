using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver
{
    public interface ISelect
    {
        SelectElement SelectElement(LocatorType locatorType, string locator);

        void SelectByText(string selectValue, double timeout, LocatorType locatorType, string locator);

        void SelectByIndex(int index, double timeout, LocatorType locatorType, string locator);

        void SelectByValue(string selectValue, double timeout, LocatorType locatorType, string locator);

        bool IsSelectOptionAvailable(LocatorType locatorType, string locator);

        bool IsSelectOptionAvailable(IWebElement element, double timeout);

    }
}
