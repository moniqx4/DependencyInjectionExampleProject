using AutomationServices.ConfigurationServices.EmployeeApplicationService;
using System;

namespace AutomationServices.EmployeeApplicationService
{
    public class AttestationPromptService: IEASAttestationPrompts
    {
        public AttestationPromptService()
        {

        }

        public IEASAttestationPrompts AddNewPrompts(string promptName)
        {
            throw new NotImplementedException();
        }

        public IEASAttestationPrompts DeactivePrompts()
        {
            throw new NotImplementedException();
        }

        public IEASAttestationPrompts EnablePrompt()
        {
            throw new NotImplementedException();
        }
    }
}
