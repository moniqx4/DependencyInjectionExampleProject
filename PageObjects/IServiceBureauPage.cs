namespace PageObjects.Login
{
    public interface IServiceBureauPage
    {
        void ClickCompanyAliasLink(string companyAlias);
        void ClickLoginButton();
        IServiceBureauPage ClickSearchButton();
        IServiceBureauPage SetLoginCompanyAliasTextBox(string companyAlias);
        IServiceBureauPage SetLoginPasswordTextBox(string password);
        IServiceBureauPage SetLoginUsernameTextBox(string username);
        IServiceBureauPage SetSBCompanyAliasTextBox(string companyAlias);
    }
}