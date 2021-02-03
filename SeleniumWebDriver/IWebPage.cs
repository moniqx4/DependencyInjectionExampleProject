using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IWebPage
    {
        void ClickElement(Locator type, string locator);

        void SetText(Locator type, string locator, string text);
    }
}
