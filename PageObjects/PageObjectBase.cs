using DependencyInjectionExampleProject.SeleniumWebDriver.Drivers;
using OpenQA.Selenium;
using SeleniumWebDriver;
using SeleniumWebDriver.Types;

namespace DependencyInjectionExampleProject.PageObjects
{
    public partial class PageObjectBase
    {

        protected static IWebDriver Driver { get; set; }

        private DriverFactory _driverFactory;
        private DriverContext _driverContext { get; set; }
        
        public PageObjectBase(DriverContext driverContext, DriverFactory driverFactory)
        {
            _driverContext = driverContext;
            _driverFactory = driverFactory;
            //Driver = driverContext.Driver;
        }

        //public DriverContext SetupDriver(string type, BrowserType browser)
        //{
        //    //var factory = DriverFactory();

        //    //_driverContext = _driverFactory.Build(type, browser);

        //    //return _driverContext;
        //}

    }
}
