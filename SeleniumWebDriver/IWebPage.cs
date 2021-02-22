using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IWebPage
    {
        void ClickElement(Locator type, string locator);

        void ClickElement(ElementLocator eleLocator);

        void SetText(Locator type, string locator, string text);

        void SetText(ElementLocator eleLocator, string text);
    }
}
