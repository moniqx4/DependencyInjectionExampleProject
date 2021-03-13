using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface ILink
    {
        bool IsLinkEnabled(IWebElement element);

        string GetLinkText(IWebElement element);

        void ClickOnLink(IWebElement element);
    }
}
