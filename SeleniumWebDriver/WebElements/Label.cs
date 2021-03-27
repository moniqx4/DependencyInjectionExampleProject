using SeleniumWebDriver.Models;
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

        public void ClickOnLabel(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel.LocatorType, locatorModel.Locator);
            element.Click();
        }

        public void ClickOnLabel(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel.LocatorType, locatorModel.Locator, index);
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

        public string GetLabelText(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel.LocatorType, locatorModel.Locator);
            return element.Text;
        }

        public string GetLabelText(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel.LocatorType, locatorModel.Locator, index);
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

        public bool IsLabelEnabled(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel.LocatorType, locatorModel.Locator);
            return element.Enabled;
        }

        public bool IsLabelEnabled(LocatorModel locatorModel, int index)
        {
            var element = _locatorBuilder.LocatorByIndex(locatorModel.LocatorType, locatorModel.Locator, index);
            return element.Enabled;
        }

        /// <summary>
        /// Determines if label is enabled
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        /// <returns></returns>
        public bool IsLabelPresent(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return element.Displayed;
        }

        public bool IsLabelPresent(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel.LocatorType, locatorModel.Locator);
            return element.Displayed;
        }
       
        public bool IsLabelPresent(LocatorModel locatorModel, int index)
        {
            var elements = _locatorBuilder.LocatorByIndex(locatorModel.LocatorType, locatorModel.Locator, index);
            return elements.Displayed;
        }
    }
}
