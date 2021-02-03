using PageObjects.WTDashboards.Models;

namespace PageObjects.Login
{
    public interface ILogin
    {
        public LoginCredModel loginCred { get; set; }
        void LoginToEmployeeDashboard();

        void LoginToWebKiosk();
    }
}
