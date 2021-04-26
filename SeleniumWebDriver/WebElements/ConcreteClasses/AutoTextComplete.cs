using DataModelLibrary;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumWebDriver.WebElements
{
    public class AutoTextComplete : IAutoTextComplete
    {
        private readonly ILocatorBuilder _locatorBuilder;
        private readonly IDriverLogger _logger;

        public AutoTextComplete(IDriverLogger logger, ILocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
            _logger = logger;
        }

        /// <summary>
        /// Selects an item from a Autosuggest drop down
        /// </summary>
        /// <param name="locatorModel">Element details</param>
        /// <param name="dropDownListEntriesLocator">item listing index in drop down after entering search char</param>
        /// <param name="searchChar">search characters</param>
        /// <param name="itemToClick"> item to click </param>
        /// <param name="locatorDD">Dropdown element details</param>
        public void SelectItemInList(LocatorModel locatorModel, string searchChar, string itemToClick, string dropDownListEntriesLocator, LocatorModel locatorDD)
        {
            _logger.Info("Selecting an item from an AutoComplete Text box");

            var element = _locatorBuilder.BuildLocator(locatorModel);
            //supply initial char
            element.SendKeys(searchChar);
            Thread.Sleep(2000);            

            //wait for auto suggest list
            IList<IWebElement> elements = _locatorBuilder.GetLocators(locatorDD);

            foreach (var ele in elements)
            {
                if (ele.Text.Equals(itemToClick))
                {
                    ele.Click();
                    break;
                }
            }
        }

        /* ----- Multiple locators methods -----*/
    }
}
