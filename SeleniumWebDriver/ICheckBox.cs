using OpenQA.Selenium;

namespace SeleniumWebDriver.WebElements
{
    public interface ICheckBox
    {
        void ClickCheckBox(IWebElement element);

        bool IsCheckboxChecked(IWebElement element);

        bool IsCheckboxEnbaled(IWebElement element);
    }
}