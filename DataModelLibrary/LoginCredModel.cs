namespace DataModelLibrary
{
    public class LoginCredModel
    {

        public LoginCredModel(string companyId, string username, string password, EmployeeType employeeType)
        {

            CompanyId = companyId;
            Username = username;
            Password = password;
            EmployeeType = employeeType;
        }


        public string CompanyId { get;}

        public string Username { get; }
        public string Password { get;}

        public EmployeeType EmployeeType { get; }
        
    }
}
