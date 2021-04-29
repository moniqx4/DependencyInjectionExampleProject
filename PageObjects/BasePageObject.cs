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

        //This empty constructor is to allow the BasePageObject to be inherited with the injection
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

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.SetText(locatorModel, text);

        }

        public IWebPage SetTextBox(BaseLocatorModel locator, string text)
        {

            var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
            return _webPage.SetText(locatorModel, text);

        }


        public string HandleGetTextElement(LocatorModel locator)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.GetElementText(locatorModel);

        }

        public string GetTextElement(BaseLocatorModel locator)
        {

            var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
            return _webPage.GetElementText(locatorModel);

        }

        public IWebPage HandleClickElement(LocatorModel locator)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.ClickElement(locatorModel);

        }

        public IWebPage ClickElement(BaseLocatorModel locator)
        {

            var locatorModel = SetLocator(locator.LocatorType, locator.Locator);
            return _webPage.ClickEle(locatorModel);

        }

        public IWebPage HandleCheckbox(LocatorModel locator, bool isChecked)
        {
            var LocatorModel =  SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.CheckCheckbox(LocatorModel, isChecked);
        }

        public IWebPage ClickCheckbox(BaseLocatorModel locator, bool isChecked)
        {
            var LocatorModel = SetLocator(locator.LocatorType, locator.Locator);

            return _webPage.CheckCheckbox(LocatorModel, isChecked);

        }


        public class T
        {
        }
    }

}
