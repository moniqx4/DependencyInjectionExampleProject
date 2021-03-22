using PageObjects.Login;
using PageObjects.WTDashboards;
using PageObjects.WTDashboards.Constants.Enums;
using PageObjects.WTDashboards.Models;
using PageObjects.WTDashboards.Models.Enums;
using System.Collections.Generic;

namespace AutomationServices
{
    /*create interface for all services, and inherit */

    public class ExampleService
    {
        private readonly ILoginPage _login;

        public ExampleService(ILoginPage login)
        {
            _login = login;
        }

        public void Method1()
        {

        }
    }
}
