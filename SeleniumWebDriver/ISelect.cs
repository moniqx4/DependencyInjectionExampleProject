using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver
{
    public interface ISelect
    {
        SelectElement SelectElement();

        void SelectByText(string selectValue);

        void SelectByText(string selectValue, double timeout);

        void SelectByIndex(int index);

        void SelectByIndex(int index, double timeout);

        void SelectByValue(string selectValue);

        void SelectByValue(string selectValue, double timeout);

        bool IsSelectOptionAvailable(IWebElement option);

        bool IsSelectOptionAvailable(IWebElement element, double timeout);

    }
}
