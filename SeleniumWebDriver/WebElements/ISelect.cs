using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver
{
    public interface ISelect
    {
        SelectElement SelectElement(BaseLocatorModel locator, int waitTimeInSecs = 10);

        void SelectByText(string selectValue, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10);

        void SelectByIndex(int index, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10);

        void SelectByValue(string selectValue, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10);

        bool IsSelectOptionAvailable(BaseLocatorModel locator, int waitTimeInSecs = 10);

        bool IsSelectOptionAvailable(IWebElement element, double timeout);

    }
}
