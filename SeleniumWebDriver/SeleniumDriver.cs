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

        public void ClickElement(Locator locator)
        {
            throw new NotImplementedException();
        }

        public void ClickElement(Locator type, string locator)
        {
            throw new NotImplementedException();
        }

        public void GetDriver()
        {
            _driver.Start();
        }

        public void SetText(Locator type, string locator, string text)
        {
            throw new NotImplementedException();
        }
    }
}
