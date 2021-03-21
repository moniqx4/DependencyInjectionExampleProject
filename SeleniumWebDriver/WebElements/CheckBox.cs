using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public class CheckBox : ICheckBox
    {
        private readonly LocatorBuilder _locatorBuilder;

        public CheckBox(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }
        /// <summary>
        /// Clicks on specified checkbox
        /// </summary>
        /// <param name="element">Checkbox Element</param>
        public void ClickCheckBox(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            element.Click();
        }

        /// <summary>
        /// Determines if checkbox is Checked
        /// </summary>
        /// <param name="element">Checkbox Element</param>
        /// <returns>Returns True if checkbox is checked else False</returns>
        public bool IsCheckboxChecked(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            string flag = element.GetAttribute("checked");
            if (flag == null)
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Determines if checkbox enabled
        /// </summary>
        /// <param name="element">checkbox element</param>
        /// <returns>Returns true if checkbox is enabled else False</returns>
        public bool IsCheckboxEnbaled(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Enabled;
        }
    }
}
