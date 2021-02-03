using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Type;
using System;

namespace SeleniumWebDriver.WebElements
{
    public class Select : RemoteWebElement
    {
        private readonly IWebElement webElement;
        private readonly ILogger _logger;

        public Select(IWebElement webElement, ILogger logger)
            : base(webElement as RemoteWebDriver, null)
        {
            _logger = logger;
        }

        public SelectElement SelectElement()
        {
            return new SelectElement(webElement);
        }

        public void SelectByText(string selectValue)
        {
            SelectByText(selectValue, BaseConfig.MediumTimeout);
        }

        public void SelectByText(string selectValue, double timeout)
        {
            var element = WaitUntilDropdownIsPopulated(timeout);

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
        public void SelectByIndex(int index)
        {
            SelectByIndex(index, BaseConfig.MediumTimeout);
        }

        /// <summary>
        /// Select value in dropdown using index.
        /// </summary>
        /// <param name="index">Index value to be selected.</param>
        /// <param name="timeout">The timeout.</param>
        public void SelectByIndex(int index, double timeout)
        {
            timeout = timeout.Equals(0) ? BaseConfig.MediumTimeout : timeout;

            var element = this.WaitUntilDropdownIsPopulated(timeout);

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
        public void SelectByValue(string selectValue)
        {
            this.SelectByValue(selectValue, BaseConfig.MediumTimeout);
        }

        /// <summary>
        /// Select value in dropdown using value attribute.
        /// </summary>
        /// <param name="selectValue">Value to be selected.</param>
        /// <param name="timeout">The timeout.</param>
        public void SelectByValue(string selectValue, double timeout)
        {
            var element = this.WaitUntilDropdownIsPopulated(timeout);

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
        public bool IsSelectOptionAvailable(IWebElement option)
        {
            return IsSelectOptionAvailable(option, BaseConfig.MediumTimeout);
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
            WaitUntilDropdownIsPopulated(timeout);
            
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
        private IWebElement WaitUntilDropdownIsPopulated(double timeout)
        {
            var selectElement = new SelectElement(webElement);
            var isPopulated = false;
            try
            {
                new WebDriverWait((IWebDriver)webElement, TimeSpan.FromSeconds(timeout)).Until(
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

            return webElement;
        }
      
    }
}

