using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.Login
{
    public class ServiceBureauPage : IServiceBureauPage
    {
        private readonly IWebPage _webPage;

        public ServiceBureauPage(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public IServiceBureauPage SetSBCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, companyAlias);

            return this;
        }

        public IServiceBureauPage ClickSearchButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel);

            return this;
        }

        public IServiceBureauPage SetLoginCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, companyAlias);

            return this;
        }

        public IServiceBureauPage SetLoginUsernameTextBox(string username)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, username);

            return this;
        }

        public IServiceBureauPage SetLoginPasswordTextBox(string password)
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

        public void ClickLoginButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel);
        }

        public void ClickCompanyAliasLink(string companyAlias)
        {

            // TODO, need to pass the companyAlias into the locator
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.Link
            };

            _webPage.ClickElement(locatorModel);
        }


    }
}
