namespace AutomationServices.LoginService.models
{
    public class ServiceBureauCreds
    {
        public ServiceBureauCreds(string companyAlias, string companyId, string username, string password)
        {
            CompanyAlias = companyAlias;
            CompanyId = companyId;
            Username = username;
            Password = password;
        }

        public string CompanyAlias { get; }

        public string CompanyId { get;  }

        public string Username { get;  }

        public string Password { get;  }
    }
}
