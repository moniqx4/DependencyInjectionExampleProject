using AutomationServices.LoginService;
using System;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Schedule
{
    public class ValidateScheduleEntry
    {
        private readonly ILoginService _loginService;

        public ValidateScheduleEntry(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public void Execute()
        {
            // login to supervisor db : need admin login creds
            LoginToSupervisorDB();

            // create a new schedule entry

            // if schedule card is not on by default, will need to change the setting to enable it

            // logout of supervisor db

            // login to dashboard

            // locate the schedule elements for your entry

            // validate the schedule is displayed as expected : expectedScheduleEntry [ need to have a ScheduleEntryModel]
        }

        private void LoginToSupervisorDB()
        {
            throw new NotImplementedException();
        }
    }
}
