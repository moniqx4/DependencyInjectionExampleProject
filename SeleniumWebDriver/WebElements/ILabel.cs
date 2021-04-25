using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface ILabel
    {
        bool IsLabelEnabled(LocatorType locatorType, string locator);

        string GetLabelText(LocatorType locatorType, string locator);

        void ClickOnLabel(LocatorType locatorType, string locator);

        bool IsLabelEnabled(LocatorModel locatorModel);

        string GetLabelText(LocatorModel locatorModel);

        void ClickOnLabel(LocatorModel locatorModel);

        bool IsLabelEnabled(LocatorModel locatorModel, int index);

        string GetLabelText(LocatorModel locatorModel, int index);

        void ClickOnLabel(LocatorModel locatorModel, int index);

        bool IsLabelPresent(LocatorType locatorType, string locator);

        bool IsLabelPresent(LocatorModel locatorModel);

        bool IsLabelPresent(LocatorModel locatorModel, int index);
    }
}
