using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IButton
    {
        bool IsButtonEnabled(LocatorType locatorType, string locator, int index = 0);

        void ClickButton(LocatorType locatorType, string locator);

        void ClickButton(LocatorType locatorType, string locator, int index = 0);

        string GetButtonText(LocatorType locatorType, string locator, int index = 0);

        bool IsButtonPresent(LocatorType locatorType, string locator, int index = 0);
       
    }
}
