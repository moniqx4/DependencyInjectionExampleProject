using DataModelLibrary;

namespace PageObjects.Login
{
    public class ServiceBureauPage : BasePageObject, IServiceBureauPage
    { 

        public IServiceBureauPage SetSBCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleElement(locatorModel, companyAlias);

            return this;
        }

        public IServiceBureauPage ClickSearchButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.CSS, "");

            HandleElement(locatorModel);

            return this;
        }

        public IServiceBureauPage SetLoginCompanyAliasTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");
           
            HandleElement(locatorModel, companyAlias);

            return this;
        }

        public IServiceBureauPage SetLoginUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleElement(locatorModel, username);

            return this;
        }

        public IServiceBureauPage SetLoginPasswordTextBox(string password)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleElement(locatorModel, password);

            return this;
        }

        public void ClickLoginButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.CSS, "");

            HandleElement(locatorModel);
        }

        public void ClickCompanyAliasLink(string companyAlias)
        {
            // TODO, need to pass the companyAlias into the locator
            var locatorModel = SetLocator(ElementType.Link, LocatorType.CSS, "");

            HandleElement(locatorModel);
        }


    }
}
