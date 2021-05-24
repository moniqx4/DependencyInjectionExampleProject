using DataModelLibrary;
using PageObjects.Shared;

namespace AutomationServices.SharedServices.ElementActions
{
    
    public class ElementActions : IElementActions
    {
        private readonly IElement _element;
        public ElementActions(IElement element)
        {
            _element = element;
        }

        public bool CheckCheckboxCurrentState(BaseLocatorModel locator, int waitTimeInSecs)
        {            
            return _element.IsChecked(locator, waitTimeInSecs);
        }     

        public void ClickCheckbox(BaseLocatorModel locator, bool isChecked, int waitTimeInSecs)        {
            
            _element.ClickCheckboxElement(locator, isChecked, waitTimeInSecs);           
        }

        public void ClickElement(LocatorType locatorType, string locator, int waitTimeInSecs)
        {
            var locatorModel = new BaseLocatorModel(locatorType, locator);           

            _element.ClickAnyElement(locatorModel, waitTimeInSecs);
        }

        public void ClickElement(BaseLocatorModel locator, int waitTimeInSecs)
        {            
            _element.ClickAnyElement(locator, waitTimeInSecs);            
        }

        public bool DoesElementExists(BaseLocatorModel locator, int waitTimeInSecs)
        {
            return _element.ElementExists(locator, waitTimeInSecs);          
        }      

        public string GetText(BaseLocatorModel locator, int waitTimeInSecs)
        {
            return _element.GetText(locator, waitTimeInSecs);
        }

        public void SetText(LocatorType locatorType, string locator, string text)
        {
            var locatorModel = new BaseLocatorModel(locatorType, locator);            

            _element.SetTextboxText(locatorModel, text);
        }

        public void SetText(BaseLocatorModel locator, string text, int waitTimeInSecs)
        {            
            _element.SetTextboxText(locator, text, waitTimeInSecs);          
        }
      
    }
}
