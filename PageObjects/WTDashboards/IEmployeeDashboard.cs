namespace PageObjects.WTDashboards
{
    public interface IEmployeeDashboard
    {
        void LoginToEmployeeDashboard();

        void NavigateToMyAdjustments();

        void NavigateMyTimeSheet();

        void NavigateToEmployeeDashboardHome(string version);

        void LogoutOfEmployeeDashboard();

    }
}
