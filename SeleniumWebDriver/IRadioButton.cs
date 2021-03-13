using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface IRadioButton
    {
        bool IsRadioButtonSelected(IWebElement element);

        bool IsRadioButtonEnabled(IWebElement element);

        void ClickOnRadioButton(IWebElement element);
    }
}
