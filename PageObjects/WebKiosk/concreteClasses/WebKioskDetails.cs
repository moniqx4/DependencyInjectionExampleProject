using DataModelLibrary;
using SeleniumWebDriver;
using SeleniumWebDriver.WebElements;

namespace PageObjects.WebKiosk.ConcreteClasses
{
    public class WebKioskDetails : IWebKioskDetails
    {

        private readonly IWebPage _webPage;
        private readonly ICheckBox _checkBox;
        private readonly string recentActivityCheckboxLocator;
        private readonly string timeCorrectionCheckboxLocator;

        public WebKioskDetails(IWebPage webPage, ICheckBox checkBox)
        {
            _webPage = webPage;
            _checkBox = checkBox;
        }

        public IWebKioskDetails SetRecentActivityCheckbox(bool isChecked)
        {

            var locator = new BaseLocatorModel(LocatorType.Id, "");

            _checkBox.ClickCheckBox(locator, isChecked);

            return this;
            
        }

        public IWebKioskDetails SetTimeCorrectionCheckbox(bool isChecked)
        {
            
            var locator = new BaseLocatorModel(LocatorType.Id, timeCorrectionCheckboxLocator);
            _checkBox.ClickCheckBox(locator, isChecked);


            return this;
        }
       
    }
}
