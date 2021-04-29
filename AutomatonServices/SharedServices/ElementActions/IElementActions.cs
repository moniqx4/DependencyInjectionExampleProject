using DataModelLibrary;

namespace AutomationServices.SharedServices.ElementActions
{
    public interface IElementActions
    {
        void ClickElement(LocatorType locatorType, string locator);

        string GetText(LocatorType locatorType, string locator);

        void SetText(LocatorType locatorType, string locator, string text);

       

        void ClickCheckbox(LocatorType locatorType, string locator, bool isChecked);

        bool CheckCheckboxCurrentState(LocatorType locatorType, string locator);

    }
}
