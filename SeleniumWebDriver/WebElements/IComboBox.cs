using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IComboBox
    {      

        void SelectElementByIndex(LocatorModel locatorModel, int index, int locatorIndex =0);        

        void SelectElementByValue(LocatorModel locatorModel, string value, int index=0);        

        void SelectElementByVisibleText(LocatorModel locatorModel, string visibleText, int index=0);

        bool IsComboBoxEnabled(LocatorModel locatorModel, int index=0);
    }
}
