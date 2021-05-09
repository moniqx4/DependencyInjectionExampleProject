using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface ILink
    {
        bool IsLinkEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        string GetLinkText(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        void ClickLink(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        bool IsLinkEnabled(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);

        string GetLinkText(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);

        void ClickLink(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);
    }
}
