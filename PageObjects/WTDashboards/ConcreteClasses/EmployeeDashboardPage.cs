using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class EmployeeDashboardPage : IEmployeeDashboard
    {        
    
        private readonly IWebPage _webPage;
        private readonly IBrowser _browser;
     
        public EmployeeDashboardPage(IBrowser browser, IWebPage webPage)
        {            
            _browser = browser;
            _webPage = webPage;
        }
     

        public void ClickFeedbackButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel);
        }

        public void ClickWhatsNewButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel);
        }
    }
}
