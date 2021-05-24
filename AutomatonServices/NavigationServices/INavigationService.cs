namespace PageObjects.SharedServices
{
    public interface INavigationService
    {
        void OpenToWTEmployeeDashboard(string baseUrl);

        void OpenToWTSupervisorDashboard(string baseUrl);

        void OpenToWebKioskLoginPage(string baseUrl);

        void OpenToWebKioskAdminLoginPage(string baseUrl);       

        void NavigateViaUrl(string baseUrl, string path);

        void NavigateViaWTTopMenu(string topMenu, string menuOption=null);

        void NavigateViaSideMenu(string menuOption);
    }
}
