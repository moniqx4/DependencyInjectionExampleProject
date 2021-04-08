using AutomationServices.LoginService;
using System;

namespace NUnitTestProject.Workflows
{
    public class ExampleTestWorkflow
    {
        private readonly ILoginService _loginService;

        public ExampleTestWorkflow(ILoginService loginService)
        {
            _loginService = loginService;
        }

        /* Steps that will be executed must be in the Execute Method */
        public void Execute()
        {
            var baseUrl = "";  // this should come from a test config file or app settings

            Login(baseUrl);
            
        }

        /* All test steps should be private methods, generally void */
        private void Login(string baseUrl)
        {
            throw new Exception("Not Implemented Yet.");          
        }       
    }
}
