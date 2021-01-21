namespace PageObjects.SharedServices
{
    public interface INavigationService
    {
        void OpenToWTEmployeeDashboard();

        void OpenToWTSupervisorDashboard();

        void NavigateToToggleMenuOpt(string menuOpt);
    }
}
