using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IRadioButton
    {
        bool IsRadioButtonSelected(LocatorType locatorType, string locator);

        bool IsRadioButtonEnabled(LocatorType locatorType, string locator);

        void ClickOnRadioButton(LocatorType locatorType, string locator, int index = 0);

        bool IsRadioButtonSelected(LocatorModel locatorModel);

        bool IsRadioButtonEnabled(LocatorModel locatorModel);

        void ClickOnRadioButton(LocatorModel locatorModel, int index = 0);
    }
}
