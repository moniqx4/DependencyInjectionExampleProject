using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IAutoTextComplete
    {
        void SelectItemInList(LocatorType locatorType, string locator, string searchChar, string itemToClick, string dropDownListEntriesLocator, LocatorType locatorTypeDD, string locatorDD);
    }
}
