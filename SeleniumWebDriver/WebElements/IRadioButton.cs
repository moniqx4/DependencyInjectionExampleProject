using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IRadioButton
    {  
        bool IsRadioButtonSelected(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        bool IsRadioButtonEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        void ClickOnRadioButton(BaseLocatorModel locatorModel, int index = 0, int waitTimeInSecs = 10);
    }
}
