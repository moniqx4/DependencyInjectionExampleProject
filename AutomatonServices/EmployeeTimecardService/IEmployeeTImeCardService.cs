using System;

namespace AutomationServices.EmployeeTimecardService
{
    public interface IEmployeeTImeCardService
    {
        //void AddTimeEntry(TimeEntry timeEntry);
        void ClearAllPunches(string payperiod);

        void ClearSinglePunch(DateTime date);

        void ApproveTimecards();
    }
}
