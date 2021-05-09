using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public interface ICheckBox
    {
        ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, int timeInSecs = 10);

        ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, bool isEnabled, int timeInSecs = 10);

        bool IsCheckboxChecked(BaseLocatorModel locatorModel, int timeInSecs = 10);

        bool IsCheckboxEnabled(BaseLocatorModel locatorModel, int timeInSecs = 10);

    }
}