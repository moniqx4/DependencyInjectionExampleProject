using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface ILink
    {
        bool IsLinkEnabled(LocatorType locatorType, string locator);

        string GetLinkText(LocatorType locatorType, string locator);

        void ClickLink(LocatorType locatorType, string locator);
    }
}
