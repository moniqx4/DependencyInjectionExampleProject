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

        public void ClearTextBox(BaseLocatorModel locatorModel, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSec);
            eleType.Click();            
        }

        public void ClearTextBox(BaseLocatorModel locatorModel, int index, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSec);
            eleType.Clear();
        }

        public bool IsTextBoxDisplayed(BaseLocatorModel locatorModel, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSec);
            return eleType.Displayed;
        }

        public bool IsTextBoxDisplayed(BaseLocatorModel locatorModel, int index, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSec);
            return eleType.Displayed;
        }

        public void TypeInTextBox(BaseLocatorModel locatorModel, string text, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSec);
            eleType.SendKeys(text);
        }

        public void TypeInTextBox(BaseLocatorModel locatorModel, string text, int index, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel,index, waitTimeInSec);
            eleType.SendKeys(text);
        }

        public string GetTextBoxText(BaseLocatorModel locatorModel, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSec);
            return eleType.Text;
        }

        public string GetTextBoxText(BaseLocatorModel locatorModel, int index, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSec);
            return eleType.Text;
        }

        public void ClickIntoTextBox(BaseLocatorModel locatorModel, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSec);
            eleType.Click();
        }

        public void ClickIntoTextBox(BaseLocatorModel locatorModel, int index, int waitTimeInSec)
        {
            var eleType = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSec);
            eleType.Click();
        }
    }
}
