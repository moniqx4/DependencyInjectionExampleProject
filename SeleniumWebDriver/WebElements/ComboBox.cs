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
      
        public bool IsComboBoxEnabled(LocatorModel locatorModel, int index=0)
        {
            if(index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel);
                return element.Enabled;
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index);
                return elements.Enabled;
            }
           
        }


        public void SelectElementByIndex(LocatorModel locatorModel, int index, int locatorIndex=0)
        {
            if (locatorIndex == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel);
                select = new SelectElement(element);
                select.SelectByIndex(index);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, locatorIndex);
                select = new SelectElement(elements);
                select.SelectByIndex(index);
            }
           
        }


        public void SelectElementByValue(LocatorModel locatorModel, string value, int index=0)
        {
            if(index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel);
                select = new SelectElement(element);
                select.SelectByValue(value);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index);
                select = new SelectElement(elements);
                select.SelectByValue(value);
            }
            
        }


        public void SelectElementByVisibleText(LocatorModel locatorModel, string visibleText, int index=0)
        {

            if (index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel);
                select = new SelectElement(element);
                select.SelectByText(visibleText);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index);
                select = new SelectElement(elements);
                select.SelectByText(visibleText);
            }

            
        }
    }
}
