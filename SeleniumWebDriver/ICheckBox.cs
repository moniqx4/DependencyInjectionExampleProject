using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public interface ICheckBox
    {
        void ClickCheckBox(LocatorType locatorType, string locator);

        bool IsCheckboxChecked(LocatorType locatorType, string locator);

        bool IsCheckboxEnbaled(LocatorType locatorType, string locator);
    }
}