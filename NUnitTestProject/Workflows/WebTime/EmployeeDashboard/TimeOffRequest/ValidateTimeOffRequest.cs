using AutomationServices.LoginService;
using AutomationServices.ScheduleService;
using AutomationServices.TimeOffService;
using PageObjects.SharedServices;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.TimeOffRequest
{
    public class ValidateTimeOffRequest
    {
        private readonly INavigationService _navigate;
        private readonly ILoginService _login;
        private readonly ILoginCredentialService _loginCreds;
        private readonly ITimeoffService _torService;
        private readonly ITimeOffValidationService _validateTOR;
        private readonly IScheduleValidationService _validateSchedule;        

        public ValidateTimeOffRequest(
            INavigationService navigate,
            ILoginService login,
            ITimeoffService torService,
            ITimeOffValidationService validateTOR,
            IScheduleValidationService validateSchedule,
            ILoginCredentialService loginCreds)
        {
            _navigate = navigate;
            _login = login;
            _torService = torService;
            _validateTOR = validateTOR;
            _validateSchedule = validateSchedule;
            _loginCreds = loginCreds;
        }

        public void Execute()
        {
            var baseUrl = "";

            LoginToEmployeeDashboard(baseUrl); // need login creds            
            FillSubmitTimeOffRequestForm();  // need the form details
            ValidateTimeOffRequestOnScheduleCard(); //pass in the ExpectedTORData
            ValidateTimeOffRequestOnStatusTab(); //pass in the ExpectedTORData

            LogoutOfEmployeeDashboard(baseUrl);

            //DeleteTimeOffRequest(); if able to do as a DB call, could do outside of the logout step

        }

        private void LogoutOfEmployeeDashboard(string baseUrl)
        {
            _login.LogoutViaUrl(baseUrl);
        }

        private void FillSubmitTimeOffRequestForm()
        {
            _torService.CreateTimeOffRequest();           
        }

        private void ValidateTimeOffRequestOnStatusTab()
        {
            _validateTOR.ValidateStatusTabEntry(); // pass in the expectedData
        }

        private void ValidateTimeOffRequestOnScheduleCard()
        {
            _validateSchedule.ValidateScheduleTOREntry(); // pass in the expectedData
        }

        private void LoginToEmployeeDashboard(string baseUrl)
        {
            var emplCreds = _loginCreds.GetEmployeeCredentials();
            _login.LoginToWTEmployeeDashboard(baseUrl, emplCreds);
        }
    }
}
