using OpenQA.Selenium;
using SeleniumWebDriver;

namespace DependencyInjectionExampleProject.PageObjects
{
    public partial class PageObjectBase
    {
        protected IWebDriver Driver { get; set; }

        protected DriverContext DriverContext { get; set; }
        
        public PageObjectBase(DriverContext driverContext)
        {
            DriverContext = driverContext;
            Driver = driverContext.Driver;
        }

    }
}
