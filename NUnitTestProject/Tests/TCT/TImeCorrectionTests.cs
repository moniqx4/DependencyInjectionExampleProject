using DataModelLibrary.Enums;
using NUnit.Framework;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Activity;
using PageObjects.WTDashboards.Models.Enums;
using System.Collections.Generic;
using TestRunnerLibrary;

namespace NUnitTestProject.Tests.TCT
{
    public class TImeCorrectionTests : BaseTest
    {
        public TImeCorrectionTests()
        {

        }
        private static IEnumerable<TestCaseData> AddCases()
        {
            yield return new TestCaseData("ValidateAddTimeCorrectionTests", TimeCorrectionType.Add, PunchType.ClockIn, "04/15/21", "8:00 AM", "Automated Time Correction Add Test");
            yield return new TestCaseData("ValidateEditTimeCorrectionTests", TimeCorrectionType.Edit, PunchType.ClockIn, "04/15/21", "8:00 AM", "Automated Time Correction Edit Test");
            yield return new TestCaseData("ValidateRemoveTimeCorrectionTests", TimeCorrectionType.Remove, PunchType.ClockIn, "04/15/21", "8:00 AM", "Automated Time Correction Remove Test");
        }

        [Test, TestCaseSource(nameof(AddCases))]
        [Author("YourName or email here")]
        [Category("DashboardTimeCorrectionTests")]        
        public void ValidateTimeCorrectionTest(string testname, TimeCorrectionType tcType, string punchDate, string punchTime, string reason)
        {

            var runner = new TestRunner();
            var testContext = SetTestContext(nameof(ValidateTimeCorrectionTest));
            runner.Execute<ValidateTimeCorrectionsWorkflow>(workflow => { workflow.Execute(tcType, punchDate, punchTime, reason); }, testContext);
        }
    }
}
