using AutomationServices.LoginService.models;
using AutomationServices.PunchService.enums;
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

        public LoginService(ILoginPage login, INavigationService navigate)
        {
            _login = login;
            _navigate = navigate;
        }
        public void LoginToServiceBureau(string baseUrl, ServiceBureauCreds sbCreds)
        {
            throw new NotImplementedException();
        }

        public void LoginToWebKiosk(string baseUrl, WebKioskEmplLoginCreds loginCreds, string badgeNumber, string pin)
        {
            var pagePath = "";

            _navigate.NavigateViaUrl(baseUrl, pagePath);
        }

        public void LoginToWebKioskWithBadge(string baseUrl, WebKioskEmplLoginCreds loginCreds)
        {
            var pagePath = "";

            _navigate.NavigateViaUrl(baseUrl, pagePath);
            _login.SetBadgeNumberTextBox(loginCreds.BadgeNumber);
        }

        public void LoginToWebKioskAdminLogin(string baseUrl, WebKioskInstanceModel adminCreds)
        {
            throw new NotImplementedException();
        }

        public void LoginToWTEmployeeDashboard(string baseUrl, LoginCredModel loginCred)
        {
            var pagePath = "";

            _GotoPageFillForm(baseUrl, pagePath, loginCred);
        }

        public void LoginToWTSupervisorDashboard(string baseUrl, LoginCredModel loginCred)
        {
            var pagePath = "";
            _GotoPageFillForm(baseUrl, pagePath, loginCred);
        }

        public void LogoutViaUrl(string baseUrl)
        {
            var pagePath = "";

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

        
    }
}
