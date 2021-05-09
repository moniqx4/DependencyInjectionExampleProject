using DataModelLibrary;
using PageObjects.WTDashboards.Constants;
using PageObjects.WTDashboards.Models.Enums;
using System.Collections.Generic;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class PunchComponent : BasePageObject, IPunchComp
    {

        public IPunchComp ClickPunchButton(PunchMethod punchMethod, PunchType punchType)
        {
            if (punchMethod == PunchMethod.Regular)
            {
                //var locatorModel = new BaseLocatorModel()
                //{
                //    LocatorType = LocatorType.DataAutomationId,
                //    Locator = PunchElements
                //};

                //_webPage.ClickElement(locatorModel);
            }
            else
            {
                
            }

            return this;
            
        }

        public IPunchComp ClickManualPunchTypeOption()
        {
           
            var locator = SetLocator(LocatorType.DataAutomationId, PunchElements.ManualPunchTypeOption);

            HandleClickElement(locator);
              

            return this;
        }

        public IPunchComp ClickManualPunchNoteOption()
        {
            var locator = SetLocator(LocatorType.DataAutomationId, PunchElements.ManualPunchNoteOption);

            HandleClickElement(locator);

            return this;
        }

        public IPunchComp ClickManualPunchCostCenterOption()
        {
            var locator = SetLocator(LocatorType.DataAutomationId, PunchElements.ManualPunchCostCenterOption);

            HandleClickElement(locator);

            return this;
        }

        public IPunchComp ClickManualPunchSubmitButton()
        {

            var locator = SetLocator(LocatorType.DataAutomationId, PunchElements.ManualPunchSubmitButton);

            HandleClickElement(locator);

            return this;
        }

        public IPunchComp SetManualPunchCostCenterSearchText(string text)
        {            

            var locator = SetLocator(LocatorType.DataAutomationId, PunchElements.ManualPunchSubmitButton);

            SetTextBox(locator, text);

            return this;
        }  

        public IPunchComp SetCostCenters(List<string> costCenters, PunchMethod punchMethod)
        {
            if (punchMethod == PunchMethod.Regular)
            {

            }
            else
            {

            }

            return this;
        }

        public IPunchComp SetNotesText(string notes, PunchMethod punchMethod)
        {
            if (punchMethod == PunchMethod.Regular)
            {
                //var locator = SetLocator(LocatorType.DataAutomationId, PunchElements.NotesTextBox);

                //SetTextBox(locator, notes);
            }
            else
            {
                var locator = SetLocator(LocatorType.DataAutomationId, PunchElements.ManualPunchButton);
                ClickElement(locator);

                //
                //var locator1 = SetLocator(LocatorType.DataAutomationId, PunchElements.ManualPunchButton);

            }

            return this;
        }
       
    }
}
