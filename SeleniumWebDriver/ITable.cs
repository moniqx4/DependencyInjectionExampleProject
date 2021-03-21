using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface ITable
    {
        string[][] GetTable(ElementLocator rowLocator, ElementLocator columnLocator, LocatorType locatorType, string locator);

    }
}
