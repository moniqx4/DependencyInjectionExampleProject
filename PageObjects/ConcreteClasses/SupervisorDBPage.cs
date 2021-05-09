using DataModelLibrary;

namespace PageObjects.Login
{
    public class SupervisorDBPage : BasePageObject, ISupervisorDBPage
    { 

        public void ClickSubmitButton()
        {
            var locatorModel = SetLocator(LocatorType.Id, "");

            HandleClickElement(locatorModel);
        }

        public ISupervisorDBPage SetCompanyIdTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(LocatorType.Id, "");
            
            HandleTextBox(locatorModel, companyAlias);

            return this;
        }

        public ISupervisorDBPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(LocatorType.Id, "");

            HandleTextBox(locatorModel, username);

            return this;
        }

        public ISupervisorDBPage SetPasswordTextBox(string password)
        {
            var locatorModel = SetLocator(LocatorType.CSS, "");

            HandleTextBox(locatorModel, password);

            return this;
        }
    }
}
