using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.Login.ConcreteClasses
{
    public class LoginPage : ILoginPage
    {
        private readonly IWebPage _webPage;
        private readonly string submitButtonLocator = LoginElements.BTN_SUBMIT_ID;
        private readonly string usernameTextboxLocator = LoginElements.TXTBOX_USERNAME_ID;
        private readonly string passwordTextboxLocator = LoginElements.TXTBOX_PASSWORD_ID;
        private readonly string companyAliasTextboxLocator = LoginElements.TXTBOX_COMPANYALIAS_ID;
        private readonly string badgeNumberTextboxLocator = LoginElements.TXTBOX_BADGENUMBER_ID;
        private readonly string webKioskLoginButtonLocator = "";


        public LoginPage(IWebPage webPage)
        {
            _webPage = webPage;
        }


        public void ClickSubmitButton()
        {            
            var locator = new BaseLocatorModel(LocatorType.Id, submitButtonLocator);

            var element = _webPage.GetElement(locator);

            element.Click();
                  
        }

        public ILoginPage SetUsernameTextBox(string username)
        {
            var locator = new BaseLocatorModel(LocatorType.Id, usernameTextboxLocator);

            var element = _webPage.GetElement(locator);

            element.SendKeys(username);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {          
            var locator = new BaseLocatorModel(LocatorType.Id, passwordTextboxLocator);

            var element = _webPage.GetElement(locator);

            element.SendKeys(password);

            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {

            var locator = new BaseLocatorModel(LocatorType.Id, companyAliasTextboxLocator);

            var element = _webPage.GetElement(locator);

            element.SendKeys(companyAlias);

            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            var locator = new BaseLocatorModel(LocatorType.Id, badgeNumberTextboxLocator);

            var element = _webPage.GetElement(locator);

            element.SendKeys(badgeNumber);


            return this;

        }

        public string GetBadgeNumberElementText()
        {
            var locator = new BaseLocatorModel(LocatorType.Id, badgeNumberTextboxLocator);
            var element = _webPage.GetElement(locator);
            return element.Text;           

        }

        public ILoginPage EnterPinWithTouchEnabled(string pin)
        {
            throw new System.NotImplementedException();
        }

        public void ClickWebKioskLoginButton()
        {
            var locator = new BaseLocatorModel(LocatorType.Id, webKioskLoginButtonLocator);

            var element = _webPage.GetElement(locator);

            element.Click();

        }

    }
}
