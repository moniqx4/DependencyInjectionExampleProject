using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver
{
    public interface ISelect
    {
        SelectElement SelectElement(LocatorModel locator);

        void SelectByText(string selectValue, double timeout, LocatorModel locator);

        void SelectByIndex(int index, double timeout, LocatorModel locator);

        void SelectByValue(string selectValue, double timeout, LocatorModel locator);

        bool IsSelectOptionAvailable(LocatorModel locator);

        bool IsSelectOptionAvailable(IWebElement element, double timeout);

    }
}
