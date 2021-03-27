using DataModelLibrary;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.WebElements
{
    public class ComboBox: IComboBox
    {
        private static SelectElement select;
        private readonly LocatorBuilder _locatorBuilder;

        public ComboBox(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }
      
        public bool IsComboBoxEnabled(LocatorType locatorType, string locator, int index=0)
        {
            if(index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorType, locator);
                return element.Enabled;
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
                return elements.Enabled;
            }
           
        }


        public void SelectElementByIndex(LocatorType locatorType, string locator, int index, int locatorIndex=0)
        {
            if (locatorIndex == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorType, locator);
                select = new SelectElement(element);
                select.SelectByIndex(index);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorType, locator, locatorIndex);
                select = new SelectElement(elements);
                select.SelectByIndex(index);
            }
           
        }


        public void SelectElementByValue(LocatorType locatorType, string locator, string value, int index=0)
        {
            if(index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorType, locator);
                select = new SelectElement(element);
                select.SelectByValue(value);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
                select = new SelectElement(elements);
                select.SelectByValue(value);
            }
            
        }


        public void SelectElementByVisibleText(LocatorType locatorType, string locator, string visibleText, int index=0)
        {

            if (index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorType, locator);
                select = new SelectElement(element);
                select.SelectByText(visibleText);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
                select = new SelectElement(elements);
                select.SelectByText(visibleText);
            }

            
        }
    }
}
