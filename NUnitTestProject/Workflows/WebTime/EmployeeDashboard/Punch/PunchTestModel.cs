using DataModelLibrary.WebTimeModels;
using System.Collections.Generic;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch
{
    public class PunchTestModel
    {
        private List<string> _punchDetails = new List<string>();
        public void Add(string punch)
        {
            _punchDetails.Add(punch);
        }

        public PunchModel PunchDataModel { get; set; }

        public ExpectedPunchData ExpectedPunchData { get; set; }

        public bool ValidatePunch { get; set; }
    }
}
