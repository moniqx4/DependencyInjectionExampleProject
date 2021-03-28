using DataModelLibrary;
using PageObjects.WTDashboards.Constants;
using PageObjects.WTDashboards.Models.Enums;
using SeleniumWebDriver;
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

        public IPunchComp ClickPunchButton(PunchMethod punchMethod, PunchType punchType)
        {
            if (punchMethod == PunchMethod.Regular)
            {
                //var locatorModel = new LocatorModel()
                //{
                //    LocatorType = LocatorType.DataAutomationId,
                //    Locator = PunchElements
                //};

                //_webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator);
            }
            else
            {
                
            }

            return this;
            
        }

        public IPunchComp ClickManualPunchTypeOption()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = PunchElements.ManualPunchTypeOption,
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator, locatorModel.ElementType);           

            return this;
        }

        public IPunchComp ClickManualPunchNoteOption()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = PunchElements.ManualPunchNoteOption,
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator, locatorModel.ElementType);

            return this;
        }

        public IPunchComp ClickManualPunchCostCenterOption()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = PunchElements.ManualPunchCostCenterOption,
                ElementType = ElementType.Option
            };

            _webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator, locatorModel.ElementType);          

            return this;
        }

        public IPunchComp ClickManualPunchSubmitButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = PunchElements.ManualPunchSubmitButton,
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator, locatorModel.ElementType);

            return this;
        }

        public IPunchComp SetManualPunchCostCenterSearchText(string text)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = PunchElements.CostCenterSearchTextBox,
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel.LocatorType, locatorModel.Locator, text);

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

            }
            else
            {

            }

            return this;
        }
       
    }
}
