using AutomationServices.EmployeeTimecardService;
using AutomationServices.PunchService.enums;
using DataModelLibrary;
using DataModelLibrary.WebTimeModels;
using PageObjects.WTDashboards;
using PageObjects.WTDashboards.Models.Enums;
using System.Collections.Generic;

namespace AutomationServices.PunchService
{
    public class PunchService : IPunchService    {
        
        private readonly IEmployeeTImeCardService _employeeTimecard;
        private readonly IDashboardCards _dashboard;
        public PunchService(IEmployeeTImeCardService employeeTimecard, IDashboardCards dashboard)
        {            
            _employeeTimecard = employeeTimecard;
            _dashboard = dashboard;
        }

        public void CreatePunch(PunchModel punch)
        {
            if (punch.PunchMethod == PunchMethod.Regular)
            {
                CreateRegularPunch(punch);
            }
            else
            {
                CreateManualPunch(punch);
            }
        }

        public void CreateRegularPunch(PunchType punchType, string notes = null, List<string> costCenters = null)
        {
            _SetPunchType(punchType, PunchMethod.Regular);

            if (!string.IsNullOrEmpty(notes))
            {               
                _dashboard.SetNotesText(notes, PunchMethod.Regular);
            }
           

            if (costCenters != null)           
            {
                _dashboard.SetCostCenters(costCenters, PunchMethod.Regular);
            }
        }

        public void CreateTransferPunch(PunchModel punch)
        {
            // click Transfer punch button

            CreateManualPunch(punch);
        }

        public void CreateManualPunch(PunchModel punch)
        {            
            _SetPunchType(punch.PunchType, PunchMethod.Manual);

            if (string.IsNullOrEmpty(punch.PunchDate)) { }
            else
            {
               
            }

            if (string.IsNullOrEmpty(punch.Notes)) { }
            else
            {
                _dashboard.SetNotesText(punch.Notes, PunchMethod.Manual);
            }

            if (punch.CostCenters == null) { }
            else
            {
                _dashboard.SetCostCenters(punch.CostCenters, PunchMethod.Manual);
            }

        }

        public void ClearPunches(Location clearLocation, string payPeriod)
        {
            switch (clearLocation)
            {
                case Location.EmployeeTimecard:
                    //clear all punches method, EmployeeTImeCardService
                    _employeeTimecard.ClearAllPunches(payPeriod);
                    break;
                case Location.EmployeeTimesheet:
                    break;
                default:
                    break;
            }
            
        }

        public void CreateRegularPunch(PunchModel punch)
        {
            _dashboard.ClickPunchButton(punch.PunchMethod, punch.PunchType);
        }

        private void _SetPunchType(PunchType punchType, PunchMethod punchMethod)
        {
            if (punchMethod == PunchMethod.Regular)
            {

            }
            else
            {

            }
        }
      
    }
}
