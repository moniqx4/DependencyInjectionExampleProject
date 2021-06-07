using DataModelLibrary;
using PageObjects.WTDashboards.Constants;
using PageObjects.WTDashboards.Models.Enums;
using SeleniumWebDriver;
using System.Collections.Generic;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class PunchComp : IPunchComp
    {
        private readonly IWebPage _webPage;

        public PunchComp(IWebPage webPage)
        {
            _webPage = webPage;
        }

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
           
            var locator = new BaseLocatorModel(LocatorType.DataAutomationId, PunchElements.ManualPunchTypeOption);

            var element = _webPage.GetElement(locator);

            element.Click();

            return this;
        }

        public IPunchComp ClickManualPunchNoteOption()
        {
            var locator = new BaseLocatorModel(LocatorType.DataAutomationId, PunchElements.ManualPunchNoteOption);

            var element = _webPage.GetElement(locator);

            element.Click();

            return this;
        }

        public IPunchComp ClickManualPunchCostCenterOption()
        {
            var locator = new BaseLocatorModel(LocatorType.DataAutomationId, PunchElements.ManualPunchCostCenterOption);

            var element = _webPage.GetElement(locator);

            element.Click();

            return this;
        }

        public IPunchComp ClickManualPunchSubmitButton()
        {

            var locator = new BaseLocatorModel(LocatorType.DataAutomationId, PunchElements.ManualPunchSubmitButton);

            var element = _webPage.GetElement(locator);

            element.Click();

            return this;
        }

        public IPunchComp SetManualPunchCostCenterSearchText(string text)
        {            

            var locator = new BaseLocatorModel(LocatorType.DataAutomationId, PunchElements.ManualPunchSubmitButton);
            
            var element = _webPage.GetElement(locator);

            element.SendKeys(text);

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
            BaseLocatorModel locator;

            if (punchMethod == PunchMethod.Regular)
            {
                locator = new BaseLocatorModel(LocatorType.DataAutomationId, PunchElements.RegNotesTextBox);              
               
            }
            else
            {
                locator = new BaseLocatorModel(LocatorType.DataAutomationId, PunchElements.ManualPunchButton);               

            }

            var element = _webPage.GetElement(locator);

            element.SendKeys(notes);

            return this;
        }
       
    }
}
