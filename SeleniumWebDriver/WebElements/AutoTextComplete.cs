﻿using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumWebDriver.WebElements
{
    public class AutoTextComplete
    {
        /// <summary>
        /// Selects an item from a Autosuggest drop down
        /// </summary>
        /// <param name="dropDownList">dropdown webelement</param>
        /// <param name="DropDownListEntriesLocator">item listing index in drop down after entering search char</param>
        /// <param name="searchChar">search characters</param>
        /// <param name="itemToClick"> item to click </param>
        public void SelectItemInList(Element dropDownList, string DropDownListEntriesLocator, string searchChar, string itemToClick)
        {
            //supply initial char
            dropDownList.SendKeys(searchChar);
            Thread.Sleep(2000);

            //wait for auto suggest list
            IList<IWebElement> elements = SeleniumDriver.Browser.FindElements((By.XPath(DropDownListEntriesLocator)));

            foreach (var ele in elements)
            {
                if (ele.Text.Equals(itemToClick))
                {
                    ele.Click();
                    break;
                }
            }
        }
    }
}
