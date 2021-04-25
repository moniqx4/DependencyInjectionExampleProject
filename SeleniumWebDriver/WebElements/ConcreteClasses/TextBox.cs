using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public class TextBox : ITextBox
    {        
        private readonly LocatorBuilder _locatorBuilder;

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

        public bool IsTextBoxDisplayed(LocatorModel locatorModel)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel.LocatorType, locatorModel.Locator);
            return eleType.Displayed;
        }

        public bool IsTextBoxDisplayed(LocatorModel locatorModel, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel.LocatorType, locatorModel.Locator, index);
            return eleType.Displayed;
        }

        public void TypeInTextBox(LocatorType locatorType, string locator, string text)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorType, locator);
            eleType.SendKeys(text);
        }

        public void TypeInTextBox(LocatorModel locatorModel, string text)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel.LocatorType, locatorModel.Locator);
            eleType.SendKeys(text);
        }

        public void TypeInTextBox(LocatorModel locatorModel, string text, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel.LocatorType, locatorModel.Locator, index);
            eleType.SendKeys(text);
        }

        public void ClickIntoTextBox(LocatorType locatorType, string locator)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorType, locator);
            eleType.Click();
        }

     
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
      

        public string GetTextBoxText(LocatorModel locatorModel)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel);
            return eleType.Text;
        }

        public string GetTextBoxText(LocatorModel locatorModel, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index);
            return eleType.Text;
        }

        public void ClearTextBox(LocatorModel locatorModel)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel);
            eleType.Clear();
        }

        public void ClearTextBox(LocatorModel locatorModel, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index);
            eleType.Clear();
        }

        public void ClickIntoTextBox(LocatorModel locatorModel)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel);
            eleType.Click();
        }

        public void ClickIntoTextBox(LocatorModel locatorModel, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index);
            eleType.Click();
        }
    }
}
