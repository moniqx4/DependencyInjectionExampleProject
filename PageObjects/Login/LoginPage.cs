using DataModelLibrary;


namespace PageObjects.Login.ConcreteClasses
{
    public class LoginPage : BasePageObject, ILoginPage
    { 
        public void ClickSubmitButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, LoginElements.BTN_SUBMIT_ID);

            HandleClickElement(locatorModel);
        }

        public ILoginPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, LoginElements.TXTBOX_USERNAME_ID);
           
            HandleTextBox(locatorModel, username);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {          
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, LoginElements.TXTBOX_PASSWORD_ID);

            HandleTextBox(locatorModel, password);

            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {

            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, LoginElements.TXTBOX_COMPANYALIAS_ID);

            HandleTextBox(locatorModel, companyAlias);

            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, LoginElements.TXTBOX_BADGENUMBER_ID);

            HandleTextBox(locatorModel, badgeNumber);

            return this;
        }

        public ILoginPage EnterPinWithTouchEnabled(string pin)
        {
            throw new System.NotImplementedException();
        }

        public void ClickWebKioskLoginButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, LoginElements.BTN_SUBMIT_ID);

            HandleClickElement(locatorModel);
        }
       
    }
}
