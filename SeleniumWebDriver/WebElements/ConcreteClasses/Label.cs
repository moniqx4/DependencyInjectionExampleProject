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

        public void ClickOnLabel(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            element.Click();
        }

        public void ClickOnLabel(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index);
            element.Click();
        }

       
        public string GetLabelText(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            return element.Text;
        }

        public string GetLabelText(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index);
            return element.Text;
        }
      

        public bool IsLabelEnabled(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            return element.Enabled;
        }

        public bool IsLabelEnabled(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index);
            return element.Enabled;
        }
       

        public bool IsLabelPresent(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            return element.Displayed;
        }
       
        public bool IsLabelPresent(LocatorModel locatorModel, int index)
        {
            var elements = _locatorBuilder.LocatorByIndex(locatorModel, index);
            return elements.Displayed;
        }
    }
}
