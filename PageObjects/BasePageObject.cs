using DataModelLibrary;
using OpenQA.Selenium;
using SeleniumWebDriver;

namespace PageObjects
{
    public abstract class BasePageObject
    {
        private readonly IWebPage _webPage;

        public BasePageObject(IWebPage webPage): base()
        {
            _webPage = webPage;
        }

        //This empty constructor is to allow the BasePageObject to be inherited with the injection
        //public BasePageObject()
        //{
        //}       
       

        public BaseLocatorModel SetLocator(LocatorType locatorType, string locator)
        {
            var locatorModel = new BaseLocatorModel(locatorType, locator);         

            return locatorModel;
        }

        public IWebElement GetElement(BaseLocatorModel locator, int waitTimeInSec = 5)
        {
           return _webPage.GetElement(locator, waitTimeInSec);
        }

        //public void HandleTextBox(BaseLocatorModel locator, string text, int waitTimeInSec = 5)
        //{

        //    var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
        //    var element = _webPage.GetElement(locatorModel, waitTimeInSec);
        //    element.SendKeys(text);            

        //}

        //public IWebPage SetTextBox(BaseLocatorModel locator, string text, int waitTimeInSec = 10)
        //{

        //    var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
        //    return _webPage.SetText(locatorModel, text, waitTimeInSec);

        //}


        //public string HandleGetTextElement(BaseLocatorModel locator, int waitTimeInSec = 10)
        //{

        //    var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
        //    return _webPage.GetElementText(locatorModel, waitTimeInSec);

        //}

        //public string GetTextElement(BaseLocatorModel locator, int waitTimeInSec = 10)
        //{

        //    var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
        //    return _webPage.GetElementText(locatorModel, waitTimeInSec);

        //}

        //public IWebPage HandleClickElement(BaseLocatorModel locator, int waitTimeInSec = 10)
        //{          
        //    return _webPage.ClickElement(locator, waitTimeInSec);
        //}

        //public IWebPage ClickElement(BaseLocatorModel locator, int waitTimeInSec = 10)
        //{

        //    var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
        //    return _webPage.ClickElement(locatorModel, waitTimeInSec);

        //}

        public IWebPage HandleCheckbox(BaseLocatorModel locator, bool isChecked, int waitTimeInSec = 5)
        {
            return _webPage.CheckCheckbox(locator, isChecked, waitTimeInSec);
        }

        //public IWebPage ClickCheckbox(BaseLocatorModel locator, bool isChecked, int waitTimeInSec = 10)
        //{
        //    var LocatorModel = SetLocator(locator.LocatorType, locator.Locator);

        //    return _webPage.CheckCheckbox(LocatorModel, isChecked, waitTimeInSec);

        //}

    }
}
