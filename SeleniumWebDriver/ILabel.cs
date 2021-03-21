using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface ILabel
    {
        bool IsLabelEnabled(LocatorType locatorType, string locator);

        string GetLabelText(LocatorType locatorType, string locator);

        void ClickOnLabel(LocatorType locatorType, string locator);
    }
}
