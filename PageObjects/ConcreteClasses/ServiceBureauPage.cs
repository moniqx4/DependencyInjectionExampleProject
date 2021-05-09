using DataModelLibrary;

namespace PageObjects.Login
{
    public class ServiceBureauPage : BasePageObject, IServiceBureauPage
    { 

        public IServiceBureauPage SetSBCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(LocatorType.CSS, "");

            HandleTextBox(locatorModel, companyAlias);

            return this;
        }

        public IServiceBureauPage ClickSearchButton()
        {
            var locatorModel = SetLocator(LocatorType.CSS, "");

            HandleClickElement(locatorModel);

            return this;
        }

        public IServiceBureauPage SetLoginCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(LocatorType.CSS, "");

            HandleTextBox(locatorModel, companyAlias);

            return this;
        }

        public IServiceBureauPage SetLoginUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(LocatorType.CSS, "");

            HandleTextBox(locatorModel, username);

            return this;
        }

        public IServiceBureauPage SetLoginPasswordTextBox(string password)
        {
            var locatorModel = SetLocator(LocatorType.CSS, "");

            HandleTextBox(locatorModel, password);

            return this;
        }

        public void ClickLoginButton()
        {
            var locatorModel = SetLocator(LocatorType.CSS, "");

            HandleClickElement(locatorModel);
        }

        public void ClickCompanyAliasLink(string companyAlias)
        {
            // TODO, need to pass the companyAlias into the locator
            var locatorModel = SetLocator(LocatorType.CSS, "");

            HandleClickElement(locatorModel);
        }


    }
}
