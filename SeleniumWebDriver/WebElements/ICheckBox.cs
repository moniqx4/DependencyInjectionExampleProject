using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public interface ICheckBox
    {

        ICheckBox ClickCheckBox(LocatorModel locatorModel);

        ICheckBox ClickCheckBox(LocatorModel locatorModel, bool isEnabled);

        bool IsCheckboxChecked(LocatorModel locatorModel);

        bool IsCheckboxEnabled(LocatorModel locatorModel);

        ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, int timeInSecs = 10);

        ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, bool isEnabled, int timeInSecs = 10);

        bool IsCheckboxChecked(BaseLocatorModel locatorModel, int timeInSecs = 10);

        bool IsCheckboxEnabled(BaseLocatorModel locatorModel, int timeInSecs = 10);


    }
}