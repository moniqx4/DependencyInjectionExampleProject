using SeleniumWebDriver;
using DataModelLibrary;

namespace PageObjects.Login
{
    public class WebKioskAdminLoginPage : IWebKioskAdminLoginPage
    {
        private readonly IWebPage _webPage;

        public WebKioskAdminLoginPage(IWebPage webPage)
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

        public IWebKioskAdminLoginPage SetCompanyId(string companyId)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "CompanyId",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, companyId);

            return this;
        }

        public IWebKioskAdminLoginPage SetInstanceName(string instanceName)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, instanceName);

            return this;
        }

        public IWebKioskAdminLoginPage SetInstancePassword(string instancePassword)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, instancePassword);

            return this;
        }
    }
}
