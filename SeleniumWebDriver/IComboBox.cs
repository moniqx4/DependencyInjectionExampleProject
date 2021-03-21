
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IComboBox
    {
        void SelectElementByIndex(LocatorType locatorType, string locator, int index);

        void SelectElementByValue(LocatorType locatorType, string locator, string value);

        void SelectElementByVIsibleText(LocatorType locatorType, string locator, string visibleText);

        bool IsComboBoxEnabled(LocatorType locatorType, string locator);
    }
}
