using OpenQA.Selenium;
using SeleniumWebDriver;

namespace DependencyInjectionExampleProject.PageObjects.WTDashboards
{
    public partial class PageObjectBase: IDriver
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
