using AutomationServices.LoginService.models;
using AutomationServices.PunchService.enums;
using PageObjects.WTDashboards.Models;

namespace AutomationServices.LoginService
{
    public interface ILoginService
    {
        void LoginToWebKiosk(string baseUrl, WebKioskEmplLoginCreds loginCreds);

        void LoginToWTEmployeeDashboard(string baseUrl, LoginCredModel loginCreds);

        void LoginToWTSupervisorDashboard(string baseUrl, LoginCredModel loginCreds);

        void LoginToServiceBureau(string baseUrl, ServiceBureauCreds sbCreds);

        void LoginToWebKioskAdminLogin(string baseUrl,WebKioskInstanceModel adminCreds);

        void LogoutViaUserProfile(Location location);

        void LogoutViaUrl(string baseUrl);


    }
}
