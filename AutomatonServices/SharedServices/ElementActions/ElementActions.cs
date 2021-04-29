using DataModelLibrary;
using PageObjects.Shared;
using System;

namespace AutomationServices.SharedServices.ElementActions
{
    
    public class ElementActions : IElementActions
    {
        private readonly IElement _element;
        public ElementActions(IElement element)
        {
            _element = element;
        }
     
        public bool CheckCheckboxCurrentState(LocatorType locatorType, string locator)
        {
            throw new NotImplementedException();
        }

        public void ClickCheckbox(LocatorType locatorType, string locator, bool isChecked)
        {
            var locatorModel = new BaseLocatorModel
            {
                LocatorType = locatorType,
                Locator = locator
            };

            _element.ClickCheckboxElement(locatorModel, isChecked);
        }

        public void ClickElement(LocatorType locatorType, string locator)
        {
            var locatorModel = new BaseLocatorModel
            {
                LocatorType = locatorType,
                Locator = locator
            };

            _element.ClickEle(locatorModel);
        }

        public string GetText(LocatorType locatorType, string locator)
        {
            var locatorModel = new BaseLocatorModel
            {
                LocatorType = locatorType,
                Locator = locator
            };

            return _element.GetText(locatorModel);
        }

        public void SetText(LocatorType locatorType, string locator, string text)
        {
            var locatorModel = new BaseLocatorModel
            {
                LocatorType = locatorType,
                Locator = locator
            };

            _element.SetTextboxText(locatorModel, text);
        }
    }
}
