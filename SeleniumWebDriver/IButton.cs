using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface IButton
    {
        bool IsButtonEnabled(IWebElement element);

        void ClickButton(IWebElement element);

        string GetButtonText(IWebElement element);
    }
}
