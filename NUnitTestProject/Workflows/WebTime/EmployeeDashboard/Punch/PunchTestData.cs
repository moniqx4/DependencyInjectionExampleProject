using DataModelLibrary;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch;
using PageObjects.WTDashboards.Models.Enums;

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
                PunchType = PunchType.ClockIn,
                PunchMethod = PunchMethod.Regular,
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
                PunchType = PunchType.ClockIn,
                PunchMethod = PunchMethod.Regular,
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

        public PunchType PunchType { get; set; }

        public PunchMethod PunchMethod { get; set; }

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