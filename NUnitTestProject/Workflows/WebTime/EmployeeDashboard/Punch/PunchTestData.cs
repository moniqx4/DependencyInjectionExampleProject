using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch
{
    public class PunchTestData
    {
        public PunchDataModel GetPunchTest1Details()
        {
            // In real-time get the employee details from db	 
            //but here we are hard coded the employee details	 
            PunchDataModel punchtest = new PunchDataModel()
            {
                ID = 1,
                PunchType = "Clock In",
                PunchMethod = "Regular",
                Notes = "Test"
            };
            return punchtest;
        }

        public PunchDataModel GetPunchTest2Details()
        {
            // In real-time get the employee details from db	 
            //but here we are hard coded the employee details	 
            PunchDataModel punchtest = new PunchDataModel()
            {
                ID = 2,
                PunchType = "Clock Out",
                PunchMethod = "Regular",
                Notes = "Test"
            };
            return punchtest;
        }
    }
}

namespace NUnitTestProject
{
    public class PunchDataModel
    {
        public int ID { get; set; }

        public string PunchType { get; set; }

        public string PunchMethod { get; set; }

        public string Notes { get; set; }
    }
}

namespace NUnitTestProject
{
    public class PunchDataFactory
    {
        PunchTestData _PunchDataAccess;

        public PunchDataFactory()
        {
            _PunchDataAccess = new PunchTestData();
        }

        public PunchDataModel GetPunchTest1Details()
        {
            return _PunchDataAccess.GetPunchTest1Details();
        }

        public PunchDataModel GetPunchTest2Details()
        {
            return _PunchDataAccess.GetPunchTest2Details();
        }
    }
}