using DataModelLibrary;
using PageObjects.WTDashboards.Models.Enums;

namespace NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch
{
    public class PunchBuilder
    {
        private PunchTestModel _punchData = new PunchTestModel();
        public PunchTestModel Build() => _punchData;

        public PunchBuilder()
        {
            _punchData = new PunchTestModel();
        }

        public PunchBuilder AddPunchType(PunchType punchType)
        {
            _punchData.PunchDataModel.PunchType = punchType;
            return this;
        }

        public PunchBuilder AddPunchMethod(PunchMethod punchMethod)
        {
            _punchData.PunchDataModel.PunchMethod = punchMethod;
            return this;
        }

        public PunchBuilder AddPunchNotes(string notes)
        {
            _punchData.PunchDataModel.Notes = notes;
            return this;
        }

    }
}
