using DataModelLibrary;

namespace PageObjects.Login
{
    public class SupervisorDBPage : BasePageObject, ISupervisorDBPage
    { 

        public void ClickSubmitButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "");

            HandleElement(locatorModel);
        }

        public ISupervisorDBPage SetCompanyIdTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "");
            
            HandleElement(locatorModel, companyAlias);

            return this;
        }

        public ISupervisorDBPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "");

            HandleElement(locatorModel, username);

            return this;
        }

        public ISupervisorDBPage SetPasswordTextBox(string password)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleElement(locatorModel, password);

            return this;
        }
    }
}
