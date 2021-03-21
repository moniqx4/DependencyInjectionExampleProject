using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IWebPage
    {
        void SetText(LocatorType type, string locator, string text);

        string GetText(LocatorType type, string locator);

        void ClickElement(LocatorType type, string locator, ElementType elementType);
    }
}
