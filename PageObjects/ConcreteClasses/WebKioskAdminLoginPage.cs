using DataModelLibrary;

namespace PageObjects.Login
{
    public class WebKioskAdminLoginPage : BasePageObject, IWebKioskAdminLoginPage
    {
        
        public void ClickSubmitButton()
        {
            var locatorModel = SetLocator(LocatorType.Id, "Submit");

            HandleClickElement(locatorModel);

        }

        public IWebKioskAdminLoginPage SetCompanyId(string companyId)
        {
            var locatorModel = SetLocator(LocatorType.Id, "username");

            HandleTextBox(locatorModel, companyId);

            return this;
        }

        public IWebKioskAdminLoginPage SetInstanceName(string instanceName)
        {
            var locatorModel = SetLocator(LocatorType.Id, "");

            HandleTextBox(locatorModel, instanceName);

            return this;
        }

        public IWebKioskAdminLoginPage SetInstancePassword(string instancePassword)
        {
            var locatorModel = SetLocator(LocatorType.Id, "");

            HandleTextBox(locatorModel, instancePassword);

            return this;
        }
    }
}
