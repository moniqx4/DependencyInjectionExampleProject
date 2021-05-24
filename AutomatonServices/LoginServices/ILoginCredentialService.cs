using DataModelLibrary;

namespace AutomationServices.LoginService
{
    public interface ILoginCredentialService
    {
        LoginCredModel GetEmployeeCredentials();

        LoginCredModel GetAdminCredentials();

        LoginCredModel GetSupervisorCredentials();

        LoginCredModel GetSuperUserCredentials();
    }
}
