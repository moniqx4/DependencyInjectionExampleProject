
using PageObjects.WTDashboards.Models;
using System.Collections.Generic;

namespace PageObjects.WTDashboards
{
    public interface IScheduleComponent
    {
        List<ShiftModel> GetSingleDayScheduleDetails(int index);

        void ChangePayPeriod();

        string GetShiftStatus();
    }
}
