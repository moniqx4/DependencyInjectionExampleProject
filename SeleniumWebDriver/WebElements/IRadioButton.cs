using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IRadioButton
    {     

        bool IsRadioButtonSelected(LocatorModel locatorModel);

        bool IsRadioButtonEnabled(LocatorModel locatorModel);

        void ClickOnRadioButton(LocatorModel locatorModel, int index = 0);
    }
}
