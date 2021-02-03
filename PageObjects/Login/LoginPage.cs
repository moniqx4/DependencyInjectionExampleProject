using PageObjects.WTDashboards.Models;
using SeleniumWebDriver;
using SeleniumWebDriver.Type;


namespace PageObjects.Login
{
    public class LoginPage : ILogin
    {
        private readonly IWebPage _webPage;

        public LoginCredModel loginCred { get; set; }

        public LoginPage(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public void LoginToEmployeeDashboard(LoginCredModel loginCred)
        {
            FillLoginPageForm(loginCred);
        }

        public void LoginToWebKiosk(LoginCredModel loginCred)
        {
            FillLoginPageForm(loginCred);
        }

        private void FillLoginPageForm(LoginCredModel loginCred)
        {  
            SetUsername(loginCred.Username);
            SetPassword(loginCred.Password);
            SetCompanyAlias(loginCred.CompanyId);
            ClickSubmitButton();
        }

        private void ClickSubmitButton()
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = Locator.Id,
                Locator = "Submit"
            };

            _webPage.ClickElement(LocatorModel.LocatorType, LocatorModel.Locator);
        }

        private void SetUsername(string username)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = Locator.Id,
                Locator = "Submit"
            };

            _webPage.SetText(LocatorModel.LocatorType, LocatorModel.Locator, username);
        }

        private void SetPassword(string password)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = Locator.Id,
                Locator = "Submit"
            };

            _webPage.SetText(LocatorModel.LocatorType, LocatorModel.Locator, password);
        }

        private void SetCompanyAlias(string companyAlias)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = Locator.Id,
                Locator = "Submit"
            };

            _webPage.SetText(LocatorModel.LocatorType, LocatorModel.Locator, companyAlias);
        }
    }
}
