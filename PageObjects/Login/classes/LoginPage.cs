using SeleniumWebDriver;
using DataModelLibrary;


namespace PageObjects.Login
{
    public class LoginPage : ILoginPage
    {      
        
        private readonly IWebPage _webPage;

        public LoginPage(IWebPage webPage)
        {            
            _webPage = webPage;
        }


        public void ClickSubmitButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "Submit",
                ElementType = ElementType.Button
            };
         
            _webPage.ClickElement(locatorModel);

        }

        public ILoginPage SetUsernameTextBox(string username)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "username",
                ElementType = ElementType.TextBox
            };           
            
            _webPage.SetText(locatorModel, username);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "password",
                ElementType = ElementType.TextBox
            };
            
            _webPage.SetText(locatorModel, password);

            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "companyId",
                ElementType = ElementType.TextBox
            };
          
            _webPage.SetText(locatorModel, companyAlias);

            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "BadgeNumber",
                ElementType = ElementType.TextBox
            };
           
            _webPage.SetText(locatorModel, badgeNumber);

            return this;
        }

        public ILoginPage EnterPinWithTouchEnabled(string pin)
        {
            throw new System.NotImplementedException();
        }

        public void ClickWebKioskLoginButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "Submit",
                ElementType = ElementType.Button
            };
          
            _webPage.ClickElement(locatorModel);
        }
       
    }
}
