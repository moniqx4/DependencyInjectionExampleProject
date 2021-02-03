using PageObjects.WTDashboards.Models.Enums;

namespace PageObjects.WTDashboards.Models
{
    public class LoginCredModel
    {
        public string CompanyId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public EmployeeType Employee { get; set; }
    }
}
