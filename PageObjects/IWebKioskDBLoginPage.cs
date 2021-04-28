namespace PageObjects.Login
{
    public interface IWebKioskDBLoginPage
    {
        IWebKioskDBLoginPage ClickNumberPad(string badgeNumber);

        IWebKioskDBLoginPage SetBadgeNumber(string badgeNumber);

        void ClickSubmit();

        IWebKioskDBLoginPage SetPin(string pin);

        IWebKioskDBLoginPage ClickSpanishToggle();

        IWebKioskDBLoginPage ClickEnglishToggle();

        string GetLoginButtonLabelText();

        string GetBadgeNumberTextFieldLabelText();
        string GetPinTextFieldLabelText();
    }
}