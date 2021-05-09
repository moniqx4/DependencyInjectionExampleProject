using AutomationServices.ConfigurationServices.EmployeeApplicationService;
using AutomationServices.LoginService;
using System;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Activity
{
    public class ValidateRecentActivity
    {
        private readonly ILoginService _loginService;
        private readonly IEmployeeApplicationServices _easService;

        public ValidateRecentActivity(ILoginService loginService, IEmployeeApplicationServices easService)
        {
            _loginService = loginService;
            _easService = easService;
        }
       
        public void Execute()
        {
            var baseUrl = "";  // this should come from a test config file or app settings

            Login(baseUrl);
            EnablePrompt();

        }

        private void EnablePrompt()
        {
            _easService.AddNewPrompts("NewPrompt");
        }
        
        private void Login(string baseUrl)
        {
            throw new Exception("Not Implemented Yet.");
        }
    }
}
