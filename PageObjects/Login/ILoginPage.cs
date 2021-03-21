namespace PageObjects.Login
{
    public interface ILoginPage
    {
        void ClickSubmitButton();

        ILoginPage SetUsernameTextBox(string username);

        ILoginPage SetPasswordTextBox(string password);

        ILoginPage SetCompanyAliasTextBox(string companyAlias);

        ILoginPage SetBadgeNumberTextBox(string badgeNumber);

        ILoginPage EnterPinWithTouchEnabled(string pin);

        void ClickWebKioskLoginButton();
    }
}
