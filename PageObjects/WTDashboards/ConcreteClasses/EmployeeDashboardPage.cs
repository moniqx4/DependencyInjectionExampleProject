using OpenQA.Selenium;
using SeleniumWebDriver;
using SeleniumWebDriver.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class EmployeeDashboardPage : IEmployeeDashboard
    {

        //private readonly IWebDriver _browser;
        
        private readonly IDriver _driver;
     
        public EmployeeDashboardPage(IDriver driver)
        {            
            _driver = driver;
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

        public void NavigateToEmployeeDashboardHome()
        {
            
            throw new NotImplementedException();
        }

        public void NavigateToMyAdjustments()
        {
            throw new NotImplementedException();
        }

        public void SetNotesText(string text)
        {
            //NotesTextField.SendKeys(text);
            _driver.SetText(Locator.Id, "", text);
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
