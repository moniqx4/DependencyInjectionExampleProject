using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.Login
{
    public class SupervisorDBPage : ISupervisorDBPage
    {
        private readonly IWebPage _webPage;

        public SupervisorDBPage(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public void ClickSubmitButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel);
        }

        public ISupervisorDBPage SetCompanyIdTextBox(string companyAlias)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, companyAlias);

            return this;
        }

        public ISupervisorDBPage SetUsernameTextBox(string username)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, username);

            return this;
        }

        public ISupervisorDBPage SetPasswordTextBox(string password)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, password);

            return this;
        }
    }
}
