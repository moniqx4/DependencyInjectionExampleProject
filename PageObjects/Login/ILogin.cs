using PageObjects.WTDashboards.Models;

namespace PageObjects.Login
{
    public interface ILogin
    {
        public LoginCredModel loginCred { get; set; }
        void LoginToEmployeeDashboard(LoginCredModel loginCred);

        void LoginToWebKiosk(LoginCredModel loginCred);
    }
}
