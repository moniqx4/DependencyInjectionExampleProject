using OpenQA.Selenium;
using SeleniumWebDriver.Type;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumWebDriver.WebElements
{
    public class AutoTextComplete : IAutoTextComplete
    {
        private readonly LocatorBuilder _locatorBuilder;

        public AutoTextComplete(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }

        /// <summary>
        /// Selects an item from a Autosuggest drop down
        /// </summary>
        /// <param name="dropDownList">dropdown webelement</param>
        /// <param name="DropDownListEntriesLocator">item listing index in drop down after entering search char</param>
        /// <param name="searchChar">search characters</param>
        /// <param name="itemToClick"> item to click </param>
        public void SelectItemInList(LocatorType locatorType, string locator, string searchChar, string itemToClick, string dropDownListEntriesLocator, LocatorType locatorTypeDD, string locatorDD)
        {
            var element = _locatorBuilder.BuildLocator(locatorType, locator);
            //supply initial char
            element.SendKeys(searchChar);
            Thread.Sleep(2000);            

            //wait for auto suggest list
            IList<IWebElement> elements = _locatorBuilder.GetLocators(locatorTypeDD, locatorDD);

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
