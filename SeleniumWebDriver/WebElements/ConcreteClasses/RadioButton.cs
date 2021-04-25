using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public class RadioButton : IRadioButton
    {
        private readonly LocatorBuilder _locatorBuilder;
        public RadioButton(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }
        /// <summary>
        /// Clicks on specified radio button 
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        public void ClickOnRadioButton(LocatorType locatorType, string locator, int index=0)
        {
            var isClicked = IsRadioButtonSelected(locatorType, locator);

            if(index == 0)
            {
                if (!isClicked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorType, locator);
                    element.Click();
                }
            }
            else
            {
                if (!isClicked)
                {
                    var element = _locatorBuilder.LocatorByIndex(locatorType, locator, index);
                    element.Click();
                }
            }          
           
        }

        public void ClickOnRadioButton(LocatorModel locatorModel, int index = 0)
        {
            var isClicked = IsRadioButtonSelected(locatorModel);

            if (index == 0)
            {
                if (!isClicked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel);
                    element.Click();
                }
            }
            else
            {
                if (!isClicked)
                {
                    var element = _locatorBuilder.LocatorByIndex(locatorModel, index);
                    element.Click();
                }
            }
        }

        /// <summary>
        /// Determines if the radio button is enabled
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        /// <returns>Returns True if Radio button is enabled else False</returns>
        public bool IsRadioButtonEnabled(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Enabled;
        }

        public bool IsRadioButtonEnabled(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            return element.Enabled;
        }

        /// <summary>
        /// Determines if the Radio button is already selected
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        /// <returns>Return True </returns>
        public bool IsRadioButtonSelected(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return true;
        }

        public bool IsRadioButtonSelected(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return true;
        }
    }
}
