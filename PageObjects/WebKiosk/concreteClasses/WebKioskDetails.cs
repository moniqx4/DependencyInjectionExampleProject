using PageObjects.WTDashboards.Models;
using SeleniumWebDriver.Type;
using SeleniumWebDriver.WebElements;

namespace PageObjects.WebKiosk.concreteClasses
{
    public class WebKioskDetails : IWebKioskDetails
    {
      
        private readonly ICheckBox _checkbox;

        public WebKioskDetails(ICheckBox checkbox)
        {           
            _checkbox = checkbox;
        }

        public void SetRecentActivityCheckbox(bool isEnabled)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "wdc-enable-recactivity",
                ElementType = ElementType.Checkbox
            };

            _checkbox.ClickCheckBox(locatorModel.LocatorType, locatorModel.Locator, isEnabled);
        }

        public void SetTimeCorrectionCheckbox(bool isEnabled)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "wdc-enable-recactivity",
                ElementType = ElementType.Checkbox
            };

            _checkbox.ClickCheckBox(locatorModel.LocatorType, locatorModel.Locator, isEnabled);
        }
       
    }
}
