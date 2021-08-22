using AutomationServices.EmployeeTimecardService;
using AutomationServices.LoginService;
using AutomationServices.PunchService;
using AutomationServices.PunchValidationService;
using AutomationServices.WaitService;
using DataModelLibrary;
using DataModelLibrary.WebTimeModels;
using PageObjects.Shared;
using PageObjects.WTDashboards.Models;
using PageObjects.WTDashboards.Models.Enums;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch
{
    public class ValidatePunchWorkflow 
    {            
        private readonly IPunchValidationService _validatePunch;        
        private readonly IEmployeeTImeCardService _employeeTimecardService;
        private readonly IPunchService _punchService;
        private readonly ILoginService _loginService;
        private readonly IWaitService _waitService;
        private readonly IBrowserHandler _browser;

        public ValidatePunchWorkflow(
            ILoginService loginService,
            IPunchService punchService,
            IEmployeeTImeCardService employeeTimecardService,
            IPunchValidationService validatePunch, IWaitService waitService, IBrowserHandler browser)
        {

            _punchService = punchService;
            _employeeTimecardService = employeeTimecardService;
            _validatePunch = validatePunch;
            _loginService = loginService;
            _waitService = waitService;
            _browser = browser;
        }

        public void Execute(PunchDataFactory punchTestData)
        {           
            var baseUrl = "";

            var punchtestData = punchTestData.GetPunchTest1Details();

            Login(baseUrl);
            CreateRegularClockInPunchWithNotes(); // pass in punch details, punchType (regular or manual), punchTypes ( clockin, etc)
            //var actualPunchDetails = 
            //ValidatePunch(clockInPunch); // pass in the expected punch details TODO: need expected Data Model
            ClearPunch(); // clear out added punch
            WaitBetweenPunches();
            CreateRegularClockOutPunchWithNotes(punchtestData);
            //ValidatePunch(clockOutPunch); TODO: need expected Data Model
            Logout(baseUrl);

        }

        private void Logout(string baseUrl)
        {
            _loginService.LogoutViaUrl(baseUrl);
        }

        private void CreateRegularClockOutPunchWithNotes(PunchDataModel punchTestData)
        {
            PunchModel punch = new PunchModel()
            {
                PunchType = PunchType.ClockOut,
                PunchMethod = PunchMethod.Regular,
                Notes = "Automation Punch Note"
            };

            //PunchLogic pl = new PunchLogic();
            //var punchData1 = pl.GetPunchTest1Details();
            //var punchData2 = pl.GetPunchTest2Details();

            //var punchType = punchData1.PunchType;

            var punchType2 = punchTestData.PunchType;

            _punchService.CreatePunch(punch);

           
        }

        private void WaitBetweenPunches()
        {
            _waitService.PauseBetweenPunches();
        }

        private void Login(string baseUrl)
        {
            var loginCred = new LoginCredModel("100496", "marcyemployee", "somepassword", EmployeeType.Employee);
           
            
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
