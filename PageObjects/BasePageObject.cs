using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects
{
    public abstract class BasePageObject
    {
        private readonly IWebPage _webPage;

        public BasePageObject(IWebPage webPage)
        {
            _webPage = webPage;
        }

        //This empty constructor is to allow the BasePageObject to be inherited with the injection
        public BasePageObject()
        {
        }

        public LocatorModel SetLocator(ElementType elementType, LocatorType locatorType, string locator)
        {
            var locatorModel = new LocatorModel()
            {
                ElementType = elementType,
                BaseLocator = {
                    Locator = locator,
                    LocatorType = locatorType
                }
                             
            };

            return locatorModel;
        }

        public BaseLocatorModel SetLocator(LocatorType locatorType, string locator)
        {
            var locatorModel = new BaseLocatorModel() 
            {
                
                LocatorType = locatorType,
                Locator = locator
            };

            return locatorModel;
        }

        public IWebPage HandleTextBox(LocatorModel locator, string text)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.BaseLocator.LocatorType, locator.BaseLocator.Locator);
            return _webPage.SetText(locatorModel, text);

        }

        public IWebPage SetTextBox(BaseLocatorModel locator, string text, int waitTimeInSec = 10)
        {

            var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
            return _webPage.SetText(locatorModel, text, waitTimeInSec);

        }


        public string HandleGetTextElement(LocatorModel locator)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.BaseLocator.LocatorType, locator.BaseLocator.Locator);
            return _webPage.GetElementText(locatorModel);

        }

        public string GetTextElement(BaseLocatorModel locator, int waitTimeInSec = 10)
        {

            var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
            return _webPage.GetElementText(locatorModel, waitTimeInSec);

        }

        public IWebPage HandleClickElement(LocatorModel locator)
        {          
            return _webPage.ClickElement(locator);
        }

        public IWebPage ClickElement(BaseLocatorModel locator, int waitTimeInSec = 10)
        {

            var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
            return _webPage.ClickElement(locatorModel, waitTimeInSec);

        }

        public IWebPage HandleCheckbox(LocatorModel locator, bool isChecked)
        {            
            return _webPage.CheckCheckbox(locator, isChecked);
        }

        public IWebPage ClickCheckbox(BaseLocatorModel locator, bool isChecked, int waitTimeInSec = 10)
        {
            var LocatorModel = SetLocator(locator.LocatorType, locator.Locator);

            return _webPage.CheckCheckbox(LocatorModel, isChecked, waitTimeInSec);

        }


        public class T
        {
        }
    }

}
