using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public class Link : ILink
    {
        private readonly ILocatorBuilder _locatorBuilder;

        public Link(ILocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }

        public void ClickLink(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            element.Click();
        }

        public void ClickLink(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
            element.Click();
        }   

        public string GetLinkText(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            return element.Text;
        }

        public string GetLinkText(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
            return element.Text;
        }

        public bool IsLinkEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, waitTimeInSecs);
            return element.Enabled;
        }

        public bool IsLinkEnabled(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
            return element.Enabled;
        }
    }
}
