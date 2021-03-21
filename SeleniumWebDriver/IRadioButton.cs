using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IRadioButton
    {
        bool IsRadioButtonSelected(LocatorType locatorType, string locator);

        bool IsRadioButtonEnabled(LocatorType locatorType, string locator);

        void ClickOnRadioButton(LocatorType locatorType, string locator);
    }
}
