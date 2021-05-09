namespace AutomationServices.EmployeeApplicationService
{
    public interface IEmployeeApplicationServices: IEmployeePreferences, IAttestationPrompts, IEmployeeDashboard, IPayTypes, ICostCenters
    {
        void ClickCancel();

        void ClickApply();
    }
}
