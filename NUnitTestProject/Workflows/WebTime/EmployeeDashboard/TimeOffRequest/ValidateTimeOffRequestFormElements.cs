using AutomationServices.SharedServices.BrowserActions;
using AutomationServices.SharedServices.ElementActions;
using DataModelLibrary;
using System;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.TimeOffRequest
{
    public class ValidateTimeOffRequestFormElements
    {
        private readonly IElementActions _element;
        private readonly IBrowserActions _browser;
        public ValidateTimeOffRequestFormElements(IElementActions element, IBrowserActions browser)
        {
            _element = element;
            _browser = browser;
        }

        public void Execute(string startDate, string endDate)
        {

            AccessTimeOffRequestForm();
            EnterInStartDate(startDate);
            EnterInEndDate(endDate);
            ClickSubmit();

            ValidateFormResponse();

        }

        private void ValidateFormResponse()
        {
            //if expecting error, then you would get text on expected element and validate that message was displayed
            //if expecting the form to be submitted without error, then you would check for success message, or/and check for the page that should displayed after form is submitted
            throw new NotImplementedException();
        }

        private void ClickSubmit()
        {
            _element.ClickElement(LocatorType.DataAutomationId, "");
        }

        private void EnterInEndDate(string endDate)
        {
            _element.SetText(LocatorType.DataAutomationId, "", endDate);           
        }

        private void EnterInStartDate(string startDate)
        {
            _element.SetText(LocatorType.DataAutomationId, "", startDate);
        }

        private void AccessTimeOffRequestForm()
        {
            var url = BaseUrl.Url + "PagePath";
            _browser.NavigateToPageUrl(url);
        }
    }
}
