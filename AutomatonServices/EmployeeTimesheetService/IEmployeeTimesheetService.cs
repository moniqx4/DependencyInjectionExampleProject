using PageObjects.WTDashboards.Models;
using System.Collections.Generic;

namespace AutomationServices.EmployeeTimesheetService
{
    public interface IEmployeeTimesheetService
    {
        void ClearAllPunches(string payPeriod);       

        List<TimeEntryModel> GetTimeEntry();  // shoud be of type TimeEntry and return that

        void DeleteTimeEntry(); // removed a single time entry using the opt
    }
}
