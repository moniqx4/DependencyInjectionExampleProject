using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface ILabel
    {
        bool IsLabelEnabled(IWebElement element);

        string GetLabelText(IWebElement element);

        void ClickOnLabel(IWebElement element);
    }
}
