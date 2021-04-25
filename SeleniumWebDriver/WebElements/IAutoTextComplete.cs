using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IAutoTextComplete
    {
        void SelectItemInList(LocatorModel locatorModel, string searchChar, string itemToClick, string dropDownListEntriesLocator, LocatorModel locatorDD);
    }
}
