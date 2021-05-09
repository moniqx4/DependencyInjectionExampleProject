using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IComboBox
    {      

        void SelectElementByIndex(BaseLocatorModel locatorModel, int index, int locatorIndex =0, int waitTimeInSecs = 10);        

        void SelectElementByValue(BaseLocatorModel locatorModel, string value, int index=0, int waitTimeInSecs = 10);        

        void SelectElementByVisibleText(BaseLocatorModel locatorModel, string visibleText, int index=0, int waitTimeInSecs = 10);

        bool IsComboBoxEnabled(BaseLocatorModel locatorModel, int index=0, int waitTimeInSecs = 10);
    }
}
