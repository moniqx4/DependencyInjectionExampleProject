namespace AutomationServices.ConfigurationServices.EmployeeApplicationService
{
    public interface IEASAttestationPrompts
    {
        IEASAttestationPrompts AddNewPrompts(string promptName);

        IEASAttestationPrompts EnablePrompt();

        IEASAttestationPrompts DeactivePrompts();


    }
}
