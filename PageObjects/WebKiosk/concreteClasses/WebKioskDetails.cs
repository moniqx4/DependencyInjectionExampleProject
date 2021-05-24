using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WebKiosk.ConcreteClasses
{
    public class WebKioskDetails : BasePageObject, IWebKioskDetails
    {

        private readonly IWebPage _webPay;
        private readonly string recentActivityCheckboxLocator;
        private readonly string timeCorrectionCheckboxLocator;

        public WebKioskDetails(IWebPage webPay)
        {
            _webPay = webPay;
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
