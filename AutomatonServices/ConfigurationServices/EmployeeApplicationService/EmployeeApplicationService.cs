namespace AutomationServices.EmployeeApplicationService
{    

    public class EmployeeApplicationService: IEmployeeApplicationServices
    {
        private readonly IEmployeeDashboard _emplDashboard;
        private readonly IAttestationPrompts _prompts;

        public EmployeeApplicationService(IEmployeeDashboard emplDashboard, IAttestationPrompts prompts)
        {
            _emplDashboard = emplDashboard;
            _prompts = prompts;
        }

        public IAttestationPrompts AddNewPrompts(string promptName)
        {
            return _prompts.AddNewPrompts(promptName);
        }

        public void ClickApply()
        {
            throw new System.NotImplementedException();
        }

        public void ClickCancel()
        {
            throw new System.NotImplementedException();
        }

        public IAttestationPrompts DeactivePrompts()
        {
            return DeactivePrompts();
        }

        public IAttestationPrompts EnablePrompt()
        {
            return _prompts.EnablePrompt();
        }
    }
}
