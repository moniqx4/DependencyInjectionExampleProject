
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IComboBox
    {
        void SelectElementByIndex(LocatorType locatorType, string locator, int index);

        void SelectElementByIndex(LocatorType locatorType, string locator, int index, int locatorIndex);

        void SelectElementByValue(LocatorType locatorType, string locator, string value);

        void SelectElementByValue(LocatorType locatorType, string locator, string value, int index);

        void SelectElementByVIsibleText(LocatorType locatorType, string locator, string visibleText);

        void SelectElementByVIsibleText(LocatorType locatorType, string locator, string visibleText, int index);

        bool IsComboBoxEnabled(LocatorType locatorType, string locator);

        bool IsComboBoxEnabled(LocatorType locatorType, string locator, int index);
    }
}
