
using AutomationServices.PunchService.enums;
using DataModelLibrary.WebTimeModels;
using PageObjects.WTDashboards.Models.Enums;
using System.Collections.Generic;

namespace AutomationServices.PunchService
{
    public interface IPunchService
    {
        void CreatePunch(PunchModel punch);

        void CreateRegularPunch(PunchType punchType, string notes = null, List<string> costCenters = null);

        void CreateRegularPunch(PunchModel punch);

        void CreateManualPunch(PunchModel punch);

        void CreateTransferPunch(PunchModel punch);

        void ClearPunches(Location clearLocation, string payPeriod);
    }
}
