using AutomationServices.EmployeeTimecardService;
using AutomationServices.LoginService;
using AutomationServices.PunchService;
using AutomationServices.PunchValidationService;
using AutomationServices.WaitService;
using DataModelLibrary;
using NUnitTestProject.Services;
using PageObjects.WTDashboards.Models;
using PageObjects.WTDashboards.Models.Enums;
using LoginCredModel = DataModelLibrary.LoginCredModel;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch
{
    public class ValidatePunchWorkflow
    {            
        private readonly IPunchValidationService _validatePunch;
        private readonly IWaitService _waitService;
        private readonly IEmployeeTImeCardService _employeeTimecardService;     
        private readonly ILoginService _loginService;
        private readonly IPunchService _punchService;

        public ValidatePunchWorkflow(

            IValidationService validate,
            ILoginService loginService,
            IPunchService punchService,
            IEmployeeTImeCardService employeeTimecardService,
            IWaitService waitService,
            IPunchValidationService validatePunch)
        {           
            _loginService = loginService;
            _punchService = punchService;
            _employeeTimecardService = employeeTimecardService;
            _waitService = waitService;
            _validatePunch = validatePunch;
        }

        public void Execute()
        {           
            var baseUrl = "";           

            Login(baseUrl);
            CreateRegularClockInPunchWithNotes(); // pass in punch details, punchType (regular or manual), punchTypes ( clockin, etc)
            //var actualPunchDetails = 
            //ValidatePunch(clockInPunch); // pass in the expected punch details TODO: need expected Data Model
            ClearPunch(); // clear out added punch
            WaitBetweenPunches();
            CreateRegularClockOutPunchWithNotes();
            //ValidatePunch(clockOutPunch); TODO: need expected Data Model
            Logout(baseUrl);

        }

        private void Logout(string baseUrl)
        {
            _loginService.LogoutViaUrl(baseUrl);
        }

        private void CreateRegularClockOutPunchWithNotes()
        {
            PunchModel punch = new PunchModel()
            {
                PunchType = PunchType.ClockOut,
                PunchMethod = PunchMethod.Regular,
                Notes = "Automation Punch Note"
            };

            _punchService.CreatePunch(punch);
        }

        private void WaitBetweenPunches()
        {
            _waitService.PauseBetweenPunches();
        }

        private void Login(string baseUrl)
        {
            LoginCredModel loginCred = new LoginCredModel()
            {
                Username = "marcyemployee",
                Password = "somepassword",
                CompanyId = "100496"
            };
            _loginService.LoginToWTEmployeeDashboard(baseUrl, loginCred);
        }

        private void CreateRegularClockInPunchWithNotes()
        {
            PunchModel punch = new PunchModel()
            {
                PunchType = PunchType.ClockIn,               
                PunchMethod = PunchMethod.Regular,
                Notes = "Automation Punch Note"
            };
                      
            _punchService.CreatePunch(punch);
           
        }

        private void ValidatePunch(PunchModel punch)
        {
            //get the punch details and then verify them against the expected punchdetails
           // _validate.ValidateDataObject() PunchActivityDto
           //returns a false for failed and true for passed
           
            _validatePunch.ValidatePunch(punch);
        }

        private void ClearPunch()
        {
            // need to goto MyTimesheet to remove the punch or from supervisor db
            var payperiod = "";
            _employeeTimecardService.ClearAllPunches(payperiod);
        }


    }
}
