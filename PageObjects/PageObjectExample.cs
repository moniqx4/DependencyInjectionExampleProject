using DataModelLibrary;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class PageObjectExample: BasePageObject
    {       

        public void ClickSubmitButton()
        {
           
            var locator = SetLocator(ElementType.Button, LocatorType.CSS, "#feedback-submit");

            HandleClickElement(locator);
        }
    }
}
