using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public class Button : IButton
    {
        private readonly LocatorBuilder _locatorBuilder;        

        public Button(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;           
        }

        /// <summary>
        /// Clicks on specified button
        /// </summary>
        /// <param locatorType="locatorType">Type of Element</param>
        /// <param locator="locator">The Locator for the Element</param>
        public void ClickButton(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            element.Click();
        }

        /// <summary>
        /// Retrieve text displayed on specified button
        /// </summary>
        /// <param locatorType="locatorType">Type of Element</param>
        /// <param locator="locator">The Locator for the Element</param>
        /// <returns>Button Text</returns>
        public string GetButtonText(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);            
            return element.Text;
        }

        /// <summary>
        /// Determines if the element is enabled or not 
        /// </summary>
        /// <param locatorType="locatorType">Type of Element</param>
        /// <param locator="locator">The Locator for the Element</param>
        /// <returns>Return True if button is enabled else False</returns>
        public bool IsButtonEnabled(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Enabled;
        }

        /// <summary>
        /// Determines if the element is Present in the DOM
        /// </summary>
        /// <param locatorType="locatorType">Type of Element</param>
        /// <param locator="locator">The Locator for the Element</param>
        /// <returns>Return True if button is present else False</returns>
        public bool IsButtonPresent(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Displayed;
        }

        /* ----- Multiple locators methods -----*/
    }
}
