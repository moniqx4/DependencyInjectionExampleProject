using PageObjects.Login;

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
