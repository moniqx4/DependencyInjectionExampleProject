using DataModelLibrary;

namespace PageObjects.Login
{
    public class ServiceBureauPage : BasePageObject, IServiceBureauPage
    { 
        private readonly string sBCompanyAliasTextBoxLocator = "";
        private readonly string companyAliasTextBoxLocator = "";
        private readonly string searchButtonLocator = "";
        private readonly string usernameTextBoxLocator = "";
        private readonly string passwordTextBoxLocator = "";
        private readonly string loginButtonLocator = "";
        private readonly string companyAliasLinkLocator = "";

        public IServiceBureauPage SetSBCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(LocatorType.CSS, sBCompanyAliasTextBoxLocator);

            SetTextBox(locatorModel, companyAlias);

            return this;
        }

        public IServiceBureauPage ClickSearchButton()
        {
            var locatorModel = SetLocator(LocatorType.CSS, searchButtonLocator);

            ClickElement(locatorModel);

            return this;
        }

        public IServiceBureauPage SetLoginCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(LocatorType.CSS, companyAliasTextBoxLocator);

            SetTextBox(locatorModel, companyAlias);

            return this;
        }

        public IServiceBureauPage SetLoginUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(LocatorType.CSS, usernameTextBoxLocator);

            SetTextBox(locatorModel, username);

            return this;
        }

        public IServiceBureauPage SetLoginPasswordTextBox(string password)
        {
            var locatorModel = SetLocator(LocatorType.CSS, passwordTextBoxLocator);

            SetTextBox(locatorModel, password);

            return this;
        }

        public void ClickLoginButton()
        {
            var locatorModel = SetLocator(LocatorType.CSS, loginButtonLocator);

            ClickElement(locatorModel);
        }

        public void ClickCompanyAliasLink(string companyAlias)
        {
            // TODO, need to pass the companyAlias into the locator
            var locatorModel = SetLocator(LocatorType.CSS, companyAliasLinkLocator);

            ClickElement(locatorModel);
        }


    }
}
