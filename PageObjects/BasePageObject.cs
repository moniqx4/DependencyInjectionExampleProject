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

        public IWebPage HandleButton(LocatorModel locator)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.ClickElement(locatorModel);

        }

        public IWebPage HandleTextBox(LocatorModel locator, string text)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.SetText(locatorModel, text);

        }

        public void HandleElement(LocatorModel locator, string value = null)
        {
            switch (locator.ElementType)
            {
                case ElementType.Button:
                    _HandleClickElements(locator);
                    break;

                case ElementType.TextBox:
                    _HandleTextBoxElements(locator, value);
                    break;

                case ElementType.Link:
                    _HandleClickElements(locator);
                    break;

                case ElementType.Grid:
                    break;


                case ElementType.Dropdown:                    
                    break;

                case ElementType.Selector:
                    break;

                case ElementType.AutoCompleteSelector:
                    _HandleTextBoxElements(locator, value);
                    break;

                case ElementType.Option:
                    _HandleClickElements(locator);
                    break;

                case ElementType.Alert:
                    _webPage.DismissAlert();

                    break;

                case ElementType.Modal:                    
                    break;

                case ElementType.Label:
                    break;

                case ElementType.Header:

                    break;

                case ElementType.Tab:
                    _HandleClickElements(locator);
                    break;

                case ElementType.Checkbox:
                    _HandleClickElements(locator);
                    break;

                case ElementType.Radio:
                    _HandleClickElements(locator);
                    break;

                case ElementType.Javascript:
                    break;

                case ElementType.MenuOption:
                    _HandleClickElements(locator);
                    break;

                default:
                    break;

            }



        }

        public string HandleGetTextElements(LocatorModel locator)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.GetElementText(locatorModel);

        }

        private IWebPage _HandleClickElements(LocatorModel locator)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.ClickElement(locatorModel);

        }

        private IWebPage _HandleTextBoxElements(LocatorModel locator, string text)
        {

            var locatorModel = SetLocator(locator.ElementType, locator.LocatorType, locator.Locator);
            return _webPage.SetText(locatorModel, text);

        }

      

        public class T
        {
        }
    }

}
