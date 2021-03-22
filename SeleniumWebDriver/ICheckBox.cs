using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public interface ICheckBox
    {
        void ClickCheckBox(LocatorType locatorType, string locator);

        void ClickCheckBox(LocatorType locatorType, string locator, bool isEnabled);

        bool IsCheckboxChecked(LocatorType locatorType, string locator);

        bool IsCheckboxEnabled(LocatorType locatorType, string locator);

    }
}