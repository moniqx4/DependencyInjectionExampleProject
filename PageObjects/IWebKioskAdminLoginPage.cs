namespace PageObjects.Login
{
    public interface IWebKioskAdminLoginPage
    {
        IWebKioskAdminLoginPage SetCompanyId(string companyId);

        IWebKioskAdminLoginPage SetInstanceName(string instanceName);

        IWebKioskAdminLoginPage SetInstancePassword(string instancePssword);

        void ClickSubmitButton();
    }
}
