
using PageObjects.WTDashboards.Models.Enums;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch
{
    public abstract class GenericPunchBuilder
    {
        public abstract PunchTestModel BuildPunchA();
        public abstract PunchTestModel BuildPunchB();
        public abstract PunchTestModel GetPunchDetails();
    }

    public class ClockInOutBuilder : GenericPunchBuilder
    {
        private PunchTestModel _punchTestData = new PunchTestModel();

        public override PunchTestModel BuildPunchA()
        {
            return _punchTestData.Add(PunchType.ClockIn.ToString());            
        }

        public override PunchTestModel BuildPunchB()
        {
            throw new System.NotImplementedException();
        }

        public override PunchTestModel GetPunchDetails()
        {

            return _punchTestData;
            
        }
    }
}
