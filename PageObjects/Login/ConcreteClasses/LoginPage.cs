using DataModelLibrary;


namespace PageObjects.Login.ConcreteClasses
{
    public class LoginPage : BasePageObject, ILoginPage
    { 
        public void ClickSubmitButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "Submit");

            HandleButton(locatorModel);

        }

        public ILoginPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "username");
           
            HandleTextBox(locatorModel, username);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {          
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "password");

            HandleTextBox(locatorModel, password);

            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {

            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "companyId");

            HandleTextBox(locatorModel, companyAlias);

            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "BadgeNumber");

            HandleTextBox(locatorModel, badgeNumber);

            return this;
        }

        public ILoginPage EnterPinWithTouchEnabled(string pin)
        {
            throw new System.NotImplementedException();
        }

        public void ClickWebKioskLoginButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "Submit");

            HandleButton(locatorModel);
        }
       
    }
}
