using PageObjects.Login;
using PageObjects.SharedServices;
using PageObjects.WTDashboards;
using PageObjects.WTDashboards.Models;
using System;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch
{
    public class VerifyPunchWorkflow
    {
        private readonly IEmployeeDashboard _employeeDashboard;      
        private readonly IValidationService _validate;
        private readonly IMyTimeSheet _myTimeSheet;
        private readonly INavigationService _navigationService;
        private readonly IPunchComp _punchCard;
        private readonly ILogin _login;

        public VerifyPunchWorkflow(
            IEmployeeDashboard employeeDashboard,
            IValidationService validate,
            IMyTimeSheet myTimeSheet,
            INavigationService navigationService,
            IPunchComp punchCard,
            ILogin login)
        {
            _employeeDashboard = employeeDashboard;
            _validate = validate;
            _myTimeSheet = myTimeSheet;
            _navigationService = navigationService;
            _punchCard = punchCard;
            _login = login;
        }

        public void Execute()
        {

            LoginCredModel loginCred = new LoginCredModel()
            {
                Username = "marcyemployee",
                Password = "somepassword",
                CompanyId = "100496"
            };

            Login(loginCred);
            AddPunch(); // pass in punch details, punchType (regular or manual), punchTypes ( clockin, etc)
            //var actualPunchDetails = 
            ValidatePunch(); // pass in the expected punch details
            ClearPunch(); // clear out added punch

        }

        private void Login(LoginCredModel loginCred)
        {

            _navigationService.OpenToWTEmployeeDashboard();
            _login.LoginToEmployeeDashboard(loginCred);            
        }

        private void AddPunch()
        {
            // based on if reg or manual, set the required options, and submit
            //_punchCard.AddRegularPunch(PunchTypes.ClockIn);
            throw new NotImplementedException();
        }

        private void AddNotes()
        {
            throw new NotImplementedException();
        }

        private bool ValidatePunch()
        {
            //get the punch details and then verify them against the expected punchdetails
           // _validate.ValidateDataObject() PunchActivityDto
           //returns a false for failed and true for passed
            throw new NotImplementedException();
        }

        private void ClearPunch()
        {
            // need to goto MyTimesheet to remove the punch
            throw new NotImplementedException();
        }


    }
}
