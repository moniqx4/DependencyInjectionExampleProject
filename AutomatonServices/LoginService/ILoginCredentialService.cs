using AutomationServices.LoginService.models;

namespace AutomationServices.LoginService
{
    public interface ILoginCredentialService
    {
        LoginCredsModel GetEmployeeCredentials();

        LoginCredsModel GetAdminCredentials();

        LoginCredsModel GetSupervisorCredentials();

        LoginCredsModel GetSuperUserCredentials();
    }
}
