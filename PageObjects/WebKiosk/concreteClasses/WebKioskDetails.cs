using DataModelLibrary;
using SeleniumWebDriver.WebElements;

namespace PageObjects.WebKiosk.ConcreteClasses
{
    public class WebKioskDetails : BasePageObject, IWebKioskDetails
    {
      
        private readonly ICheckBox _checkbox;

        public WebKioskDetails(ICheckBox checkbox)
        {           
            _checkbox = checkbox;
        }

        public IWebKioskDetails SetRecentActivityCheckbox(bool isChecked)
        {

            var locator = SetLocator(LocatorType.Id, "wdc-enable-recactivity");

            HandleCheckbox(locator, isChecked);

            return this;
            
        }

        public IWebKioskDetails SetTimeCorrectionCheckbox(bool isChecked)
        {
            var locator = SetLocator(LocatorType.Id, "");

            HandleCheckbox(locator, isChecked);

            return this;
        }
       
    }
}
