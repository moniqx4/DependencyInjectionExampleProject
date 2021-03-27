using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface ILink
    {
        bool IsLinkEnabled(LocatorType locatorType, string locator);

        string GetLinkText(LocatorType locatorType, string locator);

        void ClickLink(LocatorType locatorType, string locator);

        bool IsLinkEnabled(LocatorModel locatorModel);

        string GetLinkText(LocatorModel locatorModel);

        void ClickLink(LocatorModel locatorModel);

        bool IsLinkEnabled(LocatorModel locatorModel, int index);

        string GetLinkText(LocatorModel locatorModel, int index);

        void ClickLink(LocatorModel locatorModel, int index);
    }
}
