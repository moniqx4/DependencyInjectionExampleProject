using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IAutoTextComplete
    {
        void SelectItemInList(BaseLocatorModel locatorModel, string searchChar, string itemToClick, string dropDownListEntriesLocator, BaseLocatorModel locatorDD, int waitTimeInSecs = 10);
    }
}
