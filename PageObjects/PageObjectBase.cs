using OpenQA.Selenium;
using SeleniumWebDriver;
using System;

namespace DependencyInjectionExampleProject.PageObjects
{
    public partial class PageObjectBase
    {
       
        protected static IWebDriver Driver { get; set; }

        protected DriverContext DriverContext { get; set; }
        
        public PageObjectBase(DriverContext driverContext)
        {
            DriverContext = driverContext;
            Driver = driverContext.Driver;
        }

    }
}
