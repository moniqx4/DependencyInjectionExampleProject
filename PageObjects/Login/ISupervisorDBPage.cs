namespace PageObjects.Login
{
    public interface ISupervisorDBPage
    {
        void ClickSubmitButton();
        ISupervisorDBPage SetCompanyIdTextBox(string companyAlias);
        ISupervisorDBPage SetPasswordTextBox(string password);
        ISupervisorDBPage SetUsernameTextBox(string username);
    }
}