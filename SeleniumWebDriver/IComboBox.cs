using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface IComboBox
    {
        void SelectElementByIndex(IWebElement element, int index);

        void SelectElementByValue(IWebElement element, string value);

        void SelectElementByVIsibleText(IWebElement element, string visibleText);

        bool IsComboBoxEnabled(IWebElement element);
    }
}
