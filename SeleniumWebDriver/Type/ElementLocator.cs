using DataModelLibrary;
using OpenQA.Selenium;
using System;

namespace SeleniumWebDriver.Type
{
    /// <summary>
    /// Class that helps to define Kind and value for html elements.
    /// </summary>
    public class ElementLocator
    {      

        /// <summary>
        /// Gets or sets the kind of element locator.
        /// </summary>
        /// <value>
        /// Kind of element locator (Id, Xpath, ...).
        /// </value>
        public LocatorType Kind { get; set; }
       

        internal By ToBy(LocatorType kind)
        {
            throw new NotImplementedException();
        }
    }
}
