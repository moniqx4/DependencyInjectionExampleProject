using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface ILink
    {      

        bool IsLinkEnabled(LocatorModel locatorModel);

        string GetLinkText(LocatorModel locatorModel);

        void ClickLink(LocatorModel locatorModel);

        bool IsLinkEnabled(LocatorModel locatorModel, int index);

        string GetLinkText(LocatorModel locatorModel, int index);

        void ClickLink(LocatorModel locatorModel, int index);

        bool IsLinkEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        string GetLinkText(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        void ClickLink(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        bool IsLinkEnabled(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);

        string GetLinkText(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);

        void ClickLink(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);
    }
}
