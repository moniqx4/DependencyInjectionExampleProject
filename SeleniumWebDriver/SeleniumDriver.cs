using SeleniumWebDriver.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver
{
    public class SeleniumDriver : IDriver
    {
        private readonly IDriverContext _driver;
        public SeleniumDriver(IDriverContext driver)
        {
            _driver = driver;
        }

       

        public void GetDriver()
        {
            _driver.Start();
        }
      
    }
}
