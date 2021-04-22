using DataModelLibrary;
using SeleniumWebDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects
{
    public abstract class BasePageObject
    {
        protected IWebPage _webPage;

        public LocatorModel SetLocator(ElementType elementType, LocatorType locatorType, string locator)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = locatorType,
                Locator = locator,
                ElementType = elementType
            };

            return locatorModel;
        }
       
    }
}
