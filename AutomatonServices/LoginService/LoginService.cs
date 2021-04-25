using AutomationServices.LoginService.models;
using AutomationServices.PunchService.enums;
using DataModelLibrary;
using DataModelLibrary.Constants;
using PageObjects.Login;
using PageObjects.SharedServices;
using PageObjects.WTDashboards.Models;
using System;


namespace AutomationServices.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly ILoginPage _login;
        private readonly INavigationService _navigate;
        private readonly IWebKioskAdminLoginPage _wkAdminLogin;
        private readonly IWebKioskDBLoginPage _wkDBLogin;
        private readonly ISupervisorDBPage _supervisiorDB;
        private readonly IServiceBureauPage _serviceBureau;

        public LoginService(ILoginPage login,
            INavigationService navigate,
            IWebKioskAdminLoginPage wkAdminLogin,
            IServiceBureauPage serviceBureau,
            IWebKioskDBLoginPage wkDBLogin,
            ISupervisorDBPage supervisiorDB)
        {
            _login = login;
            _navigate = navigate;
            _wkAdminLogin = wkAdminLogin;
            _serviceBureau = serviceBureau;
            _wkDBLogin = wkDBLogin;
            _supervisiorDB = supervisiorDB;
        }
        public void LoginToServiceBureau(string baseUrl, ServiceBureauCreds sbCreds)
        {
            _serviceBureau.SetLoginCompanyAliasTextBox(sbCreds.CompanyAlias)
                .SetLoginUsernameTextBox(sbCreds.Username)
                .SetLoginPasswordTextBox(sbCreds.Password)
                .ClickLoginButton();

            //TODO check these steps
            _serviceBureau.SetSBCompanyAliasTextBox(sbCreds.CompanyAlias)
                .ClickSearchButton()
                .ClickCompanyAliasLink(sbCreds.CompanyAlias);
        }

        public void LoginToWebKiosk(string baseUrl, WebKioskEmplLoginCreds loginCreds, string badgeNumber, string pin)
        {
            var pagePath = PagePaths.WebKioskLoginPage;

            _navigate.NavigateViaUrl(baseUrl, pagePath);
        }

        public void LoginToWebKioskWithBadge(string baseUrl, WebKioskEmplLoginCreds loginCreds)
        {
            var pagePath = PagePaths.WebKioskLoginPage;

            _navigate.NavigateViaUrl(baseUrl, pagePath);
            _login.SetBadgeNumberTextBox(loginCreds.BadgeNumber);
        }

        public void LoginToWebKioskAdminLogin(string baseUrl, WebKioskInstanceModel adminCreds)
        {
            _navigate.OpenToWebKioskAdminLoginPage(baseUrl);
            _FillWebKioskAdminPageForm(adminCreds.CompanyId, adminCreds.InstanceName, adminCreds.InstancePassword);
        }

        public void LoginToWTEmployeeDashboard(string baseUrl, LoginCredModel loginCred)
        {
            var pagePath = PagePaths.WTEmployeeDashboardPage;

            _GotoPageFillForm(baseUrl, pagePath, loginCred);
        }

        public void LoginToWTSupervisorDashboard(string baseUrl, LoginCredModel loginCred)
        {
            var pagePath = PagePaths.WTSupervisorDashboardPage;
            _GotoPageFillForm(baseUrl, pagePath, loginCred);
        }

        public void LogoutViaUrl(string baseUrl)
        {
            var pagePath = PagePaths.Logout;

            _navigate.NavigateViaUrl(baseUrl, pagePath);
        }

        public void LogoutViaUserProfile(Location location)
        {
            throw new NotImplementedException();
        }

        public void LoginToWebKiosk(string baseUrl, WebKioskEmplLoginCreds loginCreds)
        {
            throw new NotImplementedException();
        }

        private void _GotoPageFillForm(string baseUrl, string pagePath, LoginCredModel loginCred)
        {
            _navigate.NavigateViaUrl(baseUrl, pagePath);
            _FillLoginPageForm(loginCred);
        }

        private void _FillLoginPageForm(LoginCredModel loginCred)
        {
            _login.SetCompanyAliasTextBox(loginCred.CompanyId)
                .SetUsernameTextBox(loginCred.Username)
                .SetPasswordTextBox(loginCred.Password)
                .ClickSubmitButton();           
        }

        private void _FillWebKioskAdminPageForm(string companyId, string instanceName, string instancePassword)

        {
            _wkAdminLogin.SetCompanyId(companyId)
                .SetInstanceName(instanceName)
                .SetInstancePassword(instancePassword)
                .ClickSubmitButton();           
        }


    }
}
