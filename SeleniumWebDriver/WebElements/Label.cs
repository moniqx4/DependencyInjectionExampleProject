using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public class Label: ILabel
    {
        private readonly LocatorBuilder _locatorBuilder;
        public Label(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }
        /// <summary>
        /// Clicks on the Label
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        public void ClickOnLabel(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            element.Click();
        }

        /// <summary>
        /// Retrieves text of the Label
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        /// <returns></returns>
        public string GetLabelText(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Text;
        }

        /// <summary>
        /// Determines if label is enabled
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        /// <returns></returns>
        public bool IsLabelEnabled(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Enabled;
        }
    }
}
