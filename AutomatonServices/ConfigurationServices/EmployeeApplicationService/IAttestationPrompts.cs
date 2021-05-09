namespace AutomationServices.EmployeeApplicationService
{
    public interface IAttestationPrompts
    {
        IAttestationPrompts AddNewPrompts(string promptName);

        IAttestationPrompts EnablePrompt();

        IAttestationPrompts DeactivePrompts();


    }
}
