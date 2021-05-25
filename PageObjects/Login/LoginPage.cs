using DataModelLibrary;


namespace PageObjects.Login.ConcreteClasses
{
    public class LoginPage : BasePageObject, ILoginPage
    {

        private readonly string submitButtonLocator = LoginElements.BTN_SUBMIT_ID;
        private readonly string usernameTextboxLocator = LoginElements.TXTBOX_USERNAME_ID;
        private readonly string passwordTextboxLocator = LoginElements.TXTBOX_PASSWORD_ID;
        private readonly string companyAliasTextboxLocator = LoginElements.TXTBOX_COMPANYALIAS_ID;
        private readonly string badgeNumberTextboxLocator = LoginElements.TXTBOX_BADGENUMBER_ID;
        private readonly string webKioskLoginButtonLocator = "";
       

        public LoginPage()
        {           
        }


        public void ClickSubmitButton()
        {            
            var locator = SetLocator(LocatorType.Id, submitButtonLocator);

            ClickElement(locator);            
        }

        public ILoginPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(LocatorType.Id, usernameTextboxLocator);
           
            SetTextBox(locatorModel, username);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {          
            var locatorModel = SetLocator(LocatorType.Id, passwordTextboxLocator);

            SetTextBox(locatorModel, password);

            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {

            var locatorModel = SetLocator(LocatorType.Id, companyAliasTextboxLocator);

            SetTextBox(locatorModel, companyAlias);            

            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            var locatorModel = SetLocator(LocatorType.Id, badgeNumberTextboxLocator);

            SetTextBox(locatorModel, badgeNumber);

            return this;

        }

        public string GetBadgeNumberElementText()
        {
            var locatorModel = SetLocator(LocatorType.Id, badgeNumberTextboxLocator);

            return GetTextElement(locatorModel);           

        }

        public ILoginPage EnterPinWithTouchEnabled(string pin)
        {
            throw new System.NotImplementedException();
        }

        public void ClickWebKioskLoginButton()
        {
            var locator = SetLocator(LocatorType.Id, webKioskLoginButtonLocator);

            ClickElement(locator);

        }

    }
}
