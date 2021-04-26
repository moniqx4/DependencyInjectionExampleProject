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


        public void ClickLink(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            element.Click();
        }

        public void ClickLink(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index);
            element.Click();
        }
       

        public string GetLinkText(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            return element.Text;
        }

        public string GetLinkText(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index);
            return element.Text;
        }       

        public bool IsLinkEnabled(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            return element.Enabled;
        }
       

        public bool IsLinkEnabled(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel, index);
            return element.Enabled;
        }
    }
}
