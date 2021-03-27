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
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "Submit",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(LocatorModel.LocatorType, LocatorModel.Locator, LocatorModel.ElementType);

        }

        public IWebKioskAdminLoginPage SetCompanyId(string companyId)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "CompanyId",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(LocatorModel.LocatorType, LocatorModel.Locator, companyId);

            return this;
        }

        public IWebKioskAdminLoginPage SetInstanceName(string instanceName)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(LocatorModel.LocatorType, LocatorModel.Locator, instanceName);

            return this;
        }

        public IWebKioskAdminLoginPage SetInstancePassword(string instancePassword)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(LocatorModel.LocatorType, LocatorModel.Locator, instancePassword);

            return this;
        }
    }
}
