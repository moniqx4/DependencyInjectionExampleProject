using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WebKiosk.ConcreteClasses
{
    public class WebKioskDetails : IWebKioskDetails
    {

        private readonly IWebPage _webPage;
        private readonly string recentActivityCheckboxLocator;
        private readonly string timeCorrectionCheckboxLocator;

        public WebKioskDetails(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public IWebKioskDetails SetRecentActivityCheckbox(bool isChecked)
        {

            var locator = SetLocator(LocatorType.Id, recentActivityCheckboxLocator);

            ClickCheckbox(locator, isChecked);

            return this;
            
        }

        public IWebKioskDetails SetTimeCorrectionCheckbox(bool isChecked)
        {
            var locator = SetLocator(LocatorType.Id, timeCorrectionCheckboxLocator);

            ClickCheckbox(locator, isChecked);

            return this;
        }
       
    }
}
