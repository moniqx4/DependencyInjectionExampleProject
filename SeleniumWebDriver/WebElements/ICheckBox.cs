using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public interface ICheckBox
    {       

        void ClickCheckBox(LocatorModel locatorModel);

        void ClickCheckBox(LocatorModel locatorModel, bool isEnabled);

        bool IsCheckboxChecked(LocatorModel locatorModel);

        bool IsCheckboxEnabled(LocatorModel locatorModel);

    }
}