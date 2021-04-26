using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public class TextBox : ITextBox
    {        
        private readonly ILocatorBuilder _locatorBuilder;

        public TextBox(ILocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }
      
        public bool IsTextBoxDisplayed(LocatorModel locatorModel)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel);
            return eleType.Displayed;
        }

        public bool IsTextBoxDisplayed(LocatorModel locatorModel, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index);
            return eleType.Displayed;
        }

        public void TypeInTextBox(LocatorModel locatorModel, string text)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel);
            eleType.SendKeys(text);
        }

        public void TypeInTextBox(LocatorModel locatorModel, string text, int index)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index);
            eleType.SendKeys(text);
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
