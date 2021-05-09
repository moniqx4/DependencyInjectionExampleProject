using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface ILabel
    {      

        bool IsLabelEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        string GetLabelText(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        void ClickOnLabel(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        bool IsLabelEnabled(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);

        string GetLabelText(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);

        void ClickOnLabel(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);

        bool IsLabelPresent(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        bool IsLabelPresent(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);
    }
}
