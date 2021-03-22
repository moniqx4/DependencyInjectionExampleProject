using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public class TextBox : ITextBox
    {        
        private LocatorBuilder _locatorBuilder;

        public TextBox(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }

        public void ClearTextBox(LocatorType locatorType, string locator)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorType, locator);
            eleType.Clear();     
        }

        public string GetTextBoxText(LocatorType locatorType, string locator)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorType, locator);
            return eleType.Text;
        }

        public bool IsTextBoxDisplayed(LocatorType locatorType, string locator)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorType, locator);
            return eleType.Displayed;
        }     

        public void TypeInTextBox(LocatorType locatorType, string locator, string text)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorType, locator);
            eleType.SendKeys(text);
        }

        public void ClickIntoTextBox(LocatorType locatorType, string locator)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorType, locator);
            eleType.Click();
        }

        /* ----- Multiple locators methods -----*/
        public void ClearTextBox(LocatorType locatorType, string locator, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
            eleType.Clear();
        }

        public string GetTextBoxText(LocatorType locatorType, string locator, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
            return eleType.Text;
        }

        public bool IsTextBoxDisplayed(LocatorType locatorType, string locator, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
            return eleType.Displayed;
        }

        public void TypeInTextBox(LocatorType locatorType, string locator, string text, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
            eleType.SendKeys(text);
        }

        public void ClickIntoTextBox(LocatorType locatorType, string locator, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
            eleType.Click();
        }
    }
}
