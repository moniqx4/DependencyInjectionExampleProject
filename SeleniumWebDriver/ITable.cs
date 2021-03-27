using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface ITable
    {
        //string[][] GetTable(ElementLocator rowLocator, ElementLocator columnLocator, LocatorType locatorType, string locator);

        string[][] GetTable(LocatorModel locatorModel, LocatorType locatorType, string locator);

    }
}
