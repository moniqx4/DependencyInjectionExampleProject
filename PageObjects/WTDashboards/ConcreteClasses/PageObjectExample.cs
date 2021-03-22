using PageObjects.WTDashboards.Models;
using SeleniumWebDriver;
using SeleniumWebDriver.Type;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class PageObjectExample
    {
        private readonly IWebPage _webPage;

        public PageObjectExample(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public void ClickSubmitButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "#feedback-submit",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator, locatorModel.ElementType);
        }
    }
}
