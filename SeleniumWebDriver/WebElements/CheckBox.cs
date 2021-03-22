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
        /// Does check to see if checkbox is already checked, if not then checks it
        /// </summary>
        /// <param locatorType="locatorType">Type of Element</param>
        /// <param locator="locator">The Locator for the Element</param>
        public void ClickCheckBox(LocatorType locatorType, string locator)
        {
            var isChecked = IsCheckboxChecked(locatorType, locator);

            if (!isChecked)
            {
                var element = _locatorBuilder.BuildLocator(locatorType, locator);
                element.Click();
            }
            
        }

        /// <summary>
        /// Does check to see if checkbox is in state set by isEnabled, and then sets if not in the state requested
        /// </summary>
        /// <param locatorType="locatorType" type="LocatorType">Type of Element</param>
        /// <param locator="locator" type="string">The Locator for the Element</param>
        /// <param isEnabled="isEnabled" type="bool">Setting to enabled means user wants checkbox checked</param>
        public void ClickCheckBox(LocatorType locatorType, string locator, bool isEnabled)
        {
            var isChecked = IsCheckboxChecked(locatorType, locator);

            if (isEnabled)
            {
                if (!isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorType, locator);
                    element.Click();
                }
            } 
            else
            {
                if (isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorType, locator);
                    element.Click();
                }
            }            

        }

        /// <summary>
        /// Determines if checkbox is Checked
        /// </summary>
        /// <param locatorType="locatorType" type="LocatorType">Type of Element</param>
        /// <param locator="locator" type="string">The Locator for the Element</param>
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
        /// <param locatorType="locatorType" type="LocatorType">Type of Element</param>
        /// <param locator="locator" type="string">The Locator for the Element</param>
        /// <returns>Returns true if checkbox is enabled else False</returns>
        public bool IsCheckboxEnabled(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Enabled;
        }

        /* ----- Multiple locators methods TODO-----*/
    }
}
