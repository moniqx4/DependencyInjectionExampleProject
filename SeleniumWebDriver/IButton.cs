using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IButton
    {
        bool IsButtonEnabled(LocatorType locatorType, string locator);

        void ClickButton(LocatorType locatorType, string locator);

        string GetButtonText(LocatorType locatorType, string locator);

        bool IsButtonPresent(LocatorType locatorType, string locator);
    }
}
