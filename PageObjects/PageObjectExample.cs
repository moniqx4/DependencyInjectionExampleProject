using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class PageObjectExample: BasePageObject
    {
        public PageObjectExample(IWebPage webPage) : base(webPage)
        {
        }

        public void ClickSubmitButton()
        {
           
            var locator = SetLocator(LocatorType.CSS, "#feedback-submit");

            var element = GetElement(locator);

            element.Click();
        }
    }
}
