using DataModelLibrary;
using SeleniumWebDriver;


namespace PageObjects.Login
{
    public class WebKioskDBLoginPage : IWebKioskDBLoginPage
    {
        private readonly IWebPage _webPage;

        public WebKioskDBLoginPage(IWebPage webPage)
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

        public WebKioskDBLoginPage SetCompanyIdTextBox(string companyAlias)
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

        public WebKioskDBLoginPage SetUsernameTextBox(string username)
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

        public WebKioskDBLoginPage SetPasswordTextBox(string password)
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

        public IWebKioskDBLoginPage ClickNumberPad(string badgeNumber)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            //TODO this needs to loop through the characters of the badgenumber and then punch each of them

            _webPage.ClickElement(locatorModel);

            return this;
        }

        public IWebKioskDBLoginPage SetBadgeNumber(string badgeNumber)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, badgeNumber);

            return this;
        }

        public void ClickSubmit()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel);
        }

        public IWebKioskDBLoginPage SetPin(string pin)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, pin);

            return this;
        }

        public IWebKioskDBLoginPage ClickSpanishToggle()
        {
            throw new System.NotImplementedException();
        }

        public IWebKioskDBLoginPage ClickEnglishToggle()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel);

            return this;
        }

        public string GetLoginButtonLabelText()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            return _webPage.GetElementText(locatorModel);
        }

        public string GetBadgeNumberTextFieldLabelText()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            return _webPage.GetElementText(locatorModel);
        }

        public string GetPinTextFieldLabelText()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "",
                ElementType = ElementType.Button
            };

            return _webPage.GetElementText(locatorModel);
        }
    }
}
