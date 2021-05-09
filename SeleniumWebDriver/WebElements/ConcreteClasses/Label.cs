using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public class Label: ILabel
    {
        private readonly ILocatorBuilder _locatorBuilder;
        public Label(ILocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }       

        public void ClickOnLabel(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            element.Click();
        }

        public void ClickOnLabel(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
            element.Click();
        }

       
        public string GetLabelText(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            return element.Text;
        }

        public string GetLabelText(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
            return element.Text;
        }
      

        public bool IsLabelEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            return element.Enabled;
        }

        public bool IsLabelEnabled(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
            return element.Enabled;
        }
       

        public bool IsLabelPresent(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            return element.Displayed;
        }
       
        public bool IsLabelPresent(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10)
        {
            var elements = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
            return elements.Displayed;
        }
    }
}
