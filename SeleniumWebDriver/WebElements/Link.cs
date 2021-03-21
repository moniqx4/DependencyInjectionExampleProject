using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public class Link : ILink
    {
        private readonly LocatorBuilder _locatorBuilder;

        public Link(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }

        /// <summary>
        /// Clicks on Link
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        public void ClickLink(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);            
            element.Click();
        }

        /// <summary>
        /// Retrieves Link's text
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        /// <returns></returns>
        public string GetLinkText(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Text;
        }

        /// <summary>
        /// Determines if link is enabled 
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        /// <returns></returns>
        public bool IsLinkEnabled(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Enabled;
        }
    }
}
