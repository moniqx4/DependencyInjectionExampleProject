using DataModelLibrary;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.WebElements
{
    public class ComboBox: IComboBox
    {
        private static SelectElement select;
        private readonly ILocatorBuilder _locatorBuilder;

        public ComboBox(ILocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }
      
        public bool IsComboBoxEnabled(BaseLocatorModel locatorModel, int index=0, int waitTimeInSecs = 10)
        {
            if(index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                return element.Enabled;
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
                return elements.Enabled;
            }
           
        }


        public void SelectElementByIndex(BaseLocatorModel locatorModel, int index, int locatorIndex=0, int waitTimeInSecs = 10)
        {
            if (locatorIndex == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                select = new SelectElement(element);
                select.SelectByIndex(index);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, locatorIndex, waitTimeInSecs);
                select = new SelectElement(elements);
                select.SelectByIndex(index);
            }
           
        }


        public void SelectElementByValue(BaseLocatorModel locatorModel, string value, int index=0, int waitTimeInSecs = 10)
        {
            if(index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                select = new SelectElement(element);
                select.SelectByValue(value);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
                select = new SelectElement(elements);
                select.SelectByValue(value);
            }
            
        }


        public void SelectElementByVisibleText(BaseLocatorModel locatorModel, string visibleText, int index=0, int waitTimeInSecs = 10)
        {

            if (index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                select = new SelectElement(element);
                select.SelectByText(visibleText);
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
                select = new SelectElement(elements);
                select.SelectByText(visibleText);
            }

            
        }
    }
}
