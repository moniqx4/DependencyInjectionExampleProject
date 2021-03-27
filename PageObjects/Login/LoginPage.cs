using SeleniumWebDriver;
using DataModelLibrary;


namespace PageObjects.Login
{
    public class LoginPage : ILoginPage
    {       
        private readonly ITextBox _textbox;
        private readonly IButton _button;

        public LoginCredModel loginCred { get; set; }

        public LoginPage(ITextBox textbox, IButton button)
        {           
            _textbox = textbox;
            _button = button;
        }   
       

        public void ClickSubmitButton()
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "Submit",
                ElementType = ElementType.Button
            };

            _button.ClickButton(LocatorModel.LocatorType, LocatorModel.Locator);

        }

        public ILoginPage SetUsernameTextBox(string username)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "username",
                ElementType = ElementType.TextBox
            };
           
            _textbox.TypeInTextBox(LocatorModel.LocatorType, LocatorModel.Locator, username);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "password",
                ElementType = ElementType.TextBox
            };

            _textbox.TypeInTextBox(LocatorModel.LocatorType, LocatorModel.Locator, password);          

            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "companyId",
                ElementType = ElementType.TextBox
            };

            _textbox.TypeInTextBox(LocatorModel.LocatorType, LocatorModel.Locator, companyAlias);

            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "BadgeNumer",
                ElementType = ElementType.TextBox
            };

            _textbox.TypeInTextBox(LocatorModel.LocatorType, LocatorModel.Locator, badgeNumber);

            return this;
        }

        public ILoginPage EnterPinWithTouchEnabled(string pin)
        {
            throw new System.NotImplementedException();
        }

        public void ClickWebKioskLoginButton()
        {
            var LocatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = "Submit",
                ElementType = ElementType.Button
            };
            
            _button.ClickButton(LocatorModel.LocatorType, LocatorModel.Locator);
        }
       
    }
}
