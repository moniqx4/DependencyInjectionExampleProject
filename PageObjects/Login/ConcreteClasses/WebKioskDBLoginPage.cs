using DataModelLibrary;

namespace PageObjects.Login
{
    public class WebKioskDBLoginPage : BasePageObject, IWebKioskDBLoginPage
    {

        public void ClickSubmitButton()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "");

            HandleButton(locatorModel);

        }

        public WebKioskDBLoginPage SetCompanyIdTextBox(string companyAlias)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleTextBox(locatorModel, companyAlias);
            
            return this;
        }

        public WebKioskDBLoginPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleTextBox(locatorModel, username);

            return this;
        }

        public WebKioskDBLoginPage SetPasswordTextBox(string password)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleTextBox(locatorModel, password);

            return this;
        }

        public IWebKioskDBLoginPage ClickNumberPad(string badgeNumber)
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "");

            //TODO this needs to loop through the characters of the badgenumber and then punch each of them

            _webPage.ClickElement(locatorModel);

            return this;
        }

        public IWebKioskDBLoginPage SetBadgeNumber(string badgeNumber)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleTextBox(locatorModel, badgeNumber);           

            return this;
        }

        public void ClickSubmit()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "");

            HandleButton(locatorModel);
        }

        public IWebKioskDBLoginPage SetPin(string pin)
        {
            var locatorModel = SetLocator(ElementType.TextBox, LocatorType.CSS, "");

            HandleTextBox(locatorModel, pin);

            return this;
        }

        public IWebKioskDBLoginPage ClickSpanishToggle()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "");

            HandleButton(locatorModel);

            return this;
        }

        public IWebKioskDBLoginPage ClickEnglishToggle()
        {

            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "");

            HandleButton(locatorModel);

            return this;
        }

        public string GetLoginButtonLabelText()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "");

            return HandleGetTextElements(locatorModel);

        }

        public string GetBadgeNumberTextFieldLabelText()
        {
            var locatorModel = SetLocator(ElementType.Button, LocatorType.Id, "");

            return HandleGetTextElements(locatorModel);
            
        }

        public string GetPinTextFieldLabelText()
        {
            var locatorModel = SetLocator(ElementType.Label, LocatorType.Id, "");

            return HandleGetTextElements(locatorModel);
        }
    }
}
