using PageObjects.SharedServices;
using PageObjects.WTDashboards;
using PageObjects.WTDashboards.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch
{
    public class VerifyPunchWorkflow
    {
        private readonly IEmployeeDashboard _employeeDashboard;
        private readonly IValidationService _validate;
        private readonly IMyTimeSheet _myTimeSheet;
        private readonly INavigationService _navigationService;
        private readonly IPunchComp _punchCard;

        public VerifyPunchWorkflow(
            IEmployeeDashboard employeeDashboard,
            IValidationService validate,
            IMyTimeSheet myTimeSheet,
            INavigationService navigationService,
            IPunchComp punchCard)
        {
            _employeeDashboard = employeeDashboard;
            _validate = validate;
            _myTimeSheet = myTimeSheet;
            _navigationService = navigationService;
            _punchCard = punchCard;
        }

        public void Execute()
        {
            Login(); // passing in employee login credentials
            AddPunch(); // pass in punch details, punchType (regular or manual), punchTypes ( clockin, etc)
            //var actualPunchDetails = 
            ValidatePunch(); // pass in the expected punch details
            ClearPunch(); // clear out added punch

        }

        private void Login()
        {
            // with the passed in credentials, goto the eedashboard page and login
            _navigationService.OpenToWTEmployeeDashboard(); // the LoginDto object should be passed in
            //throw new NotImplementedException();
        }

        private void AddPunch()
        {
            // based on if reg or manual, set the required options, and submit
            //_punchCard.AddRegularPunch(PunchTypes.ClockIn);
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
