using DataModelLibrary;
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface ITable
    {

        string[][] GetTable(ElementLocator rowLocator, ElementLocator columnLocator, BaseLocatorModel locatorModel, int waitTimeInSecs = 10);


    }
}
