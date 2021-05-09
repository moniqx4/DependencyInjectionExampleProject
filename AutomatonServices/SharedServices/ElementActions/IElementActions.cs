using DataModelLibrary;

namespace AutomationServices.SharedServices.ElementActions
{
    public interface IElementActions
    {
        void ClickElement(LocatorType locatorType, string locator, int waitTimeInSecs = 10);        

        void SetText(LocatorType locatorType, string locator, string text);
       

        void ClickElement(BaseLocatorModel locator, int waitTimeInSecs = 10);

        string GetText(BaseLocatorModel locator, int waitTimeInSecs = 10);

        void SetText(BaseLocatorModel locator, string text, int waitTimeInSecs = 10);


        void ClickCheckbox(BaseLocatorModel locator, bool isChecked, int waitTimeInSecs = 10);

        bool CheckCheckboxCurrentState(BaseLocatorModel locator, int waitTimeInSecs = 10);

        bool DoesElementExists(BaseLocatorModel locator, int waitTimeInSecs = 10);

    }
}
