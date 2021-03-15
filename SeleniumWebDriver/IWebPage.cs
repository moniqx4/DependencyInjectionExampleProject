using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IWebPage
    {
        void ClickElement(LocatorType type, string locator);

        void ClickElement(ElementLocator eleLocator);

        void SetText(LocatorType type, string locator, string text);

        void SetText(ElementLocator eleLocator, string text);
    }
}
