using PageObjects.WTDashboards.Models;
using PageObjects.WTDashboards.Models.Enums;
using SeleniumWebDriver;
using System;
using System.Collections.Generic;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class PunchComponent : IPunchComp
    {
        private readonly IWebPage _webPage;
        public PunchComponent(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public IPunchComp AddManualPunch(PunchModel punchDetails)
        {
            // clicks the ... button
            //_webPage.ClickElement()
            SetPunchType(punchDetails.PunchType, PunchMethod.Manual);

            if (string.IsNullOrEmpty(punchDetails.PunchDate)) { }
            else
            {

            }

            if (string.IsNullOrEmpty(punchDetails.PunchStartTime)) { }
            else
            {

            }

            if (string.IsNullOrEmpty(punchDetails.PunchEndTime)) { }
            else
            {

            }


            if (string.IsNullOrEmpty(punchDetails.Notes)) { }
            else
            {

            }

            if (punchDetails.CostCenters == null) { }
            else
            {

            }

            return this;
        }

        public IPunchComp AddRegularPunch(PunchModel punchDetails)
        {
            SetPunchType(punchDetails.PunchType, PunchMethod.Regular);

            if(string.IsNullOrEmpty(punchDetails.Notes)) { }
            else
            {

            }

            if (punchDetails.CostCenters == null) { }
            else
            {

            }

            return this;
        }

        public void ClearPunches()
        {
            throw new NotImplementedException();
        }

        private void SetPunchType(PunchType punchType, PunchMethod punchMethod)
        {
            if(punchMethod == PunchMethod.Manual)
            {

            }
            else
            {

            }
        }

        private void SetCostCenters(IList<string> costCenters, PunchMethod punchMethod)
        {
            if (punchMethod == PunchMethod.Manual)
            {

            }
            else
            {

            }
        }

        private void SetStartTime(string startTime)
        {

        }

        private void SetEndTime()
        {

        }

        private void SetNotes(string notes, PunchMethod punchMethod)
        {
            if (punchMethod == PunchMethod.Manual)
            {

            }
            else
            {

            }
        }
       
    }
}
