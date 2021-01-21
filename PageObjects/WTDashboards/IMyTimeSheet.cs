using PageObjects.WTDashboards.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.WTDashboards
{
    public interface IMyTimeSheet
    {
        void ClearTimeEntries(); // clear all timesheet entries

        List<TimeEntryDto> GetTimeEntry();  // shoud be of type TimeEntry and return that

        void DeleteTimeEntry(); // removed a single time entry using the opt
    }
}
