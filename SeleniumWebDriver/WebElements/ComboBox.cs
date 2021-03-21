using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Type;

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

        public bool IsComboBoxEnabled(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Enabled;
        }


        public void SelectElementByIndex(LocatorType locatorType, string locator, int index)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }


        public void SelectElementByValue(LocatorType locatorType, string locator, string value)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            select = new SelectElement(element);
            select.SelectByValue(value);
        }


        public void SelectElementByVIsibleText(LocatorType locatorType, string locator, string visibleText)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            select = new SelectElement(element);
            select.SelectByText(visibleText);
        }
    }
}
