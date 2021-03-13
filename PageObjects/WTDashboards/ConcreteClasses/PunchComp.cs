using OpenQA.Selenium;
using PageObjects.Shared;
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

        //public void ValidateButtonState(ExpectedButtons buttons)
        //{
        //    var actualButtons = GetPunchButtonState();           

        //    return CommonTasks.DoesListContain(actualButtons, buttons[0].Text);
        //}

        //private List<T> GetPunchButtonState()
        //{
        //    //get all elements and add to a list

        //    var LocatorModel = new LocatorModel()
        //    {
        //        LocatorType = Locator.Id,
        //        Locator = "[data-automation-id^='punch-button']"
        //    };

        //    _webPage.ClickElement(LocatorModel.LocatorType, LocatorModel.Locator);

        //    var actualPunchButton = _webPage.GetAllElements(LocatorModel.LocatorType, LocatorModel.Locator);

        //    for (int i = 0; i < actualPunchButton.Count; i++)
        //    {
        //        actualPunchButton.Add(actualPunchButton[i].Text);
        //    }

        //    return actualPunchButton;
        //}

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
