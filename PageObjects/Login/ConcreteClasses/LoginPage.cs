using SeleniumWebDriver;
using DataModelLibrary;


namespace PageObjects.Login.ConcreteClasses
{
    public class LoginPage : BasePageObject, ILoginPage
    {  

        public LoginPage(IWebPage webPage)
        {            
            _webPage = webPage;
        }


        public void ClickSubmitButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "Submit");
                    
            _webPage.ClickElement(locatorModel);

        }

        public ILoginPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "username");
                        
            _webPage.SetText(locatorModel, username);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {          
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "password");

            _webPage.SetText(locatorModel, password);

            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {

            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "companyId");
          
            _webPage.SetText(locatorModel, companyAlias);

            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.Id, "BadgeNumber");
           
            _webPage.SetText(locatorModel, badgeNumber);

            return this;
        }

        public ILoginPage EnterPinWithTouchEnabled(string pin)
        {
            throw new System.NotImplementedException();
        }

        public void ClickWebKioskLoginButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "Submit");
          
            _webPage.ClickElement(locatorModel);
        }
       
    }
}
