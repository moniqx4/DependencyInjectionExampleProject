namespace AutomationServices.DashboardServices.EmployeeDashboardService
{
    public interface IEmployeeDashboardService
    {
        IEmployeeDashboardService NavigateToEmployeeDashboard();
        void SubmitFeedbackForm(string topicText, string feedbackText);

        void AccessWhatsNew();

        void CloseUserPrefsModal();

        IEmployeeDashboardService OpenFeedbackModal();

        void LogoutOfEmployeeDashboardPage();
    }
}
