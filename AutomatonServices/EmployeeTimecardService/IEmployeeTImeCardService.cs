using System;

namespace AutomationServices.EmployeeTimecardService
{
    public interface IEmployeeTImeCardService
    {
        void ClearAllPunches(string payperiod);

        void ClearSinglePunch(DateTime date);

        void ApproveTimecards();
    }
}
