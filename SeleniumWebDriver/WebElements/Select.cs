using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Type;
using System;

namespace SeleniumWebDriver.WebElements
{
    public class Select : ISelect
    {        
        private readonly ILogger _logger;
        private readonly LocatorBuilder _locatorBuilder;

        public Select(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }

        public Select(ILogger logger)
        {            
            _logger = logger;           
        }

        public SelectElement SelectElement(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return new SelectElement(element);
        }

        public void SelectByText(string selectValue, double timeout, LocatorType locatorType, string locator)
        {
            var ele = _locatorBuilder.BuildLocator(locatorType, locator);
            var element = WaitUntilDropdownIsPopulated(timeout, ele);

            var selectElement = new SelectElement(element);

            try
            {
                selectElement.SelectByText(selectValue);
            }
            catch (NoSuchElementException e)
            {
                _logger.Error("unable to select value by text: {0}", selectValue);
                _logger.Error(e.Message);
               
            }
        }

        /// <summary>
        /// Select value in dropdown using index.
        /// </summary>
        /// <param name="index">Index value to be selected.</param>
        /// <param name="timeout">The timeout.</param>
        public void SelectByIndex(int index, double timeout, LocatorType locatorType, string locator)
        {
            timeout = timeout.Equals(0) ? BaseConfig.MediumTimeout : timeout;
            var ele = _locatorBuilder.BuildLocator(locatorType, locator);

            var element = WaitUntilDropdownIsPopulated(timeout, ele);

            var selectElement = new SelectElement(element);

            try
            {
                selectElement.SelectByIndex(index);
            }
            catch (NoSuchElementException e)
            {
                _logger.Error("unable to select given index: {0}", index);
                _logger.Error(e.Message);
            }
        }

        /// <summary>
        /// Select value in dropdown using value attribute.
        /// </summary>
        /// <param name="selectValue">Value to be selected.</param>
        /// <param name="timeout">The timeout.</param>
        public void SelectByValue(string selectValue, double timeout, LocatorType locatorType, string locator)
        {
            var ele = _locatorBuilder.BuildLocator(locatorType, locator);
            var element = WaitUntilDropdownIsPopulated(timeout, ele);

            var selectElement = new SelectElement(element);

            try
            {
                selectElement.SelectByValue(selectValue);
            }
            catch (NoSuchElementException e)
            {
                _logger.Error("unable to select given value: {0}", selectValue);
                _logger.Error(e.Message);
            }
        }

        /// <summary>
        /// Determines whether text is available in dropdown.
        /// </summary>
        /// <param name="option">The text.</param>
        /// <returns>
        /// True or False depends if text is available in dropdown.
        /// </returns>
        public bool IsSelectOptionAvailable(LocatorType locatorType, string locator)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            return IsSelectOptionAvailable(element, BaseConfig.MediumTimeout);
        }

        /// <summary>
        /// Determines whether text is available in dropdown.
        /// </summary>
        /// <param name="option">The text.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns>
        /// True or False depends if text is available in dropdown.
        /// </returns>
        public bool IsSelectOptionAvailable(IWebElement element, double timeout)
        {           
            var selectElement = new SelectElement(element);
            WaitUntilDropdownIsPopulated(timeout, element);
            
            var numEl = selectElement.AllSelectedOptions.Count;

            if (numEl > 0)
                return false;
            else
            {
                return true;
            }             
        }

        /// <summary>
        /// Waits the until dropdown is populated.
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        /// <returns>Web element when dropdown populated.</returns>
        private IWebElement WaitUntilDropdownIsPopulated(double timeout, IWebElement element)
        {            
            var selectElement = new SelectElement(element);
            var isPopulated = false;
            try
            {
                new WebDriverWait((IWebDriver)element, TimeSpan.FromSeconds(timeout)).Until(
                    x =>
                    {
                        var size = selectElement.Options.Count;
                        if (size > 1)
                        {
                            isPopulated = true;
                        }

                        return isPopulated;
                    });
            }
            catch (NoSuchElementException e)
            {
                _logger.Error("unable to select given index: {0}", selectElement);
                _logger.Error(e.Message);
            }

            return element;
        }
      
    }
}

