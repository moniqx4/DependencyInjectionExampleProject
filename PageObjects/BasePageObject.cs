using DataModelLibrary;
using SeleniumWebDriver;

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
