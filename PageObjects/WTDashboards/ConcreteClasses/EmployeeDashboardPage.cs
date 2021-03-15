using SeleniumWebDriver;
using SeleniumWebDriver.Type;
using System;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class EmployeeDashboardPage : IEmployeeDashboard
    {        
    
        private readonly IWebPage _webPage;
        private readonly IBrowser _browser;
     
        public EmployeeDashboardPage(IBrowser browser, IWebPage webPage)
        {            
            _browser = browser;
            _webPage = webPage;
        }

        public void LoginToEmployeeDashboard()
        {
            throw new NotImplementedException();
        }

        public void LogoutOfEmployeeDashboard()
        {
            throw new NotImplementedException();
        }

        public void NavigateMyTimeSheet()
        {
            throw new NotImplementedException();
        }

        public void NavigateToEmployeeDashboardHome(string version = "2")
        {
            string path;

            if(version == "V2")
            {
                path = "";
            }else
            {
                path = "";
            }

            _browser.NavigateTo(BaseConfig.Url + path);            
        }

        public void NavigateToMyAdjustments()
        {
            throw new NotImplementedException();
        }

        public void SetNotesText(string text)
        {
            //NotesTextField.SendKeys(text);
            _webPage.SetText(LocatorType.Id, "", text);
        }


        //private IWebElement NotesTextField
        //{
        //    get
        //    {
        //        return _browser.FindElement(By.Id("sb_form_q"));               
        //    }            

        //}
    }
}
