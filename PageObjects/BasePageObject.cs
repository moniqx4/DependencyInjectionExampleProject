using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects
{
    public class BasePageObject
    {
        private readonly IWebPage _webPage;

        public BasePageObject(IWebPage webPage)
        {
            _webPage = webPage;
        }

        //this empty constructor is to allow the BasePageObject to be inherited with the injection
        public BasePageObject()
        {
        }

        public LocatorModel SetLocator(ElementType elementType, LocatorType locatorType, string locator)
        {
            var locatorModel = new LocatorModel()
            {
                ElementType = elementType,
                LocatorType = locatorType,
                Locator = locator                
            };

            return locatorModel;
        }

        public IWebPage HandleTextBox(LocatorModel locator, string text)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.SetText(locatorModel, text);

        }
       

        public string HandleGetTextElement(LocatorModel locator)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.GetElementText(locatorModel);

        }

        public IWebPage HandleClickElement(LocatorModel locator)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.ClickElement(locatorModel);

        }
      

        public class T
        {
        }
    }

}
