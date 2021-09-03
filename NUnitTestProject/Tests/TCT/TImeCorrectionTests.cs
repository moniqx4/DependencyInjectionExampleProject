using DataModelLibrary.Enums;
using NUnit.Framework;
using NUnitTestProject.Tests.TCT.TestData;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Activity;
using PageObjects.WTDashboards.Models.Enums;
using System.Collections.Generic;
using TestRunnerLibrary;
using TestContext = TestRunnerLibrary.TestContext;

namespace NUnitTestProject.Tests.TCT
{

    using static TestSetupTeardown;

    public class TImeCorrectionTests : BaseTest
    {
        private static IEnumerable<TestCaseData> AddCases()
        {
            yield return new TestCaseData("ValidateAddTimeCorrectionTests", TimeCorrectionType.Add, PunchType.ClockIn, "04/15/21", "8:00 AM", "Automated Time Correction Add Test");
            yield return new TestCaseData("ValidateEditTimeCorrectionTests", TimeCorrectionType.Edit, PunchType.ClockIn, "04/15/21", "10:00 AM", "Automated Time Correction Edit Test");
            yield return new TestCaseData("ValidateRemoveTimeCorrectionTests", TimeCorrectionType.Remove, PunchType.ClockIn, "04/15/21", "10:00 AM", "Automated Time Correction Remove Test");
        }

        //[Test, TestCaseSource(nameof(AddCases))]
        //[Test, TestCaseSource(typeof(PunchTestData), "TestCases")] // this way calls it from external class
        [Test, TestCaseSource(typeof(PunchDataCSV), "GetTestCases", new object[] { "somecsvfile.csv" })] // this way calls it from a csv file
        [Author("YourName or email here")]
        [EEDashboard] // see Nunit Custom Catgory for adding more as needed       
        public void ValidateTimeCorrectionTest(string testname, TimeCorrectionType tcType, string punchDate, string punchTime, string reason)
        {

            var runner = new TestRunner();
            var testContext = SetTestContext(testname);
            runner.Execute<ValidateTimeCorrectionsWorkflow>(workflow => { workflow.Execute(tcType, punchDate, punchTime, reason); }, testContext);
        }
    }
}
