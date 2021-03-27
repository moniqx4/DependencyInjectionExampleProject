using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IComboBox
    {      

        void SelectElementByIndex(LocatorType locatorType, string locator, int index, int locatorIndex =0);        

        void SelectElementByValue(LocatorType locatorType, string locator, string value, int index=0);        

        void SelectElementByVisibleText(LocatorType locatorType, string locator, string visibleText, int index=0);

        bool IsComboBoxEnabled(LocatorType locatorType, string locator, int index=0);
    }
}
