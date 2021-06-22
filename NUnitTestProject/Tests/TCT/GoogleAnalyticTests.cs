using NUnit.Framework;
using System.Collections.Generic;
using TestRunnerLibrary;
using TestContext = TestRunnerLibrary.TestContext;

namespace NUnitTestProject.Tests.TCT
{
    using static TestSetupTeardown;

    public class GoogleAnalyticTests : BaseTest
    {
        private static IEnumerable<TestCaseData> AddCases()
        {
            //yield return new TestCaseData("ValidateClickEventsTests", gaActualPunchData, gaExpectedPunchData);
            yield return new TestCaseData("ValidateClickEventsTests", "area","eventName", "value");
            //yield return new TestCaseData("ValidatePageAccessTests", gaActualPageAccessData, gaExpectedPageAccessData);
            //yield return new TestCaseData("ValidateTests", TimeCorrectionType.Remove, PunchType.ClockIn, "04/15/21", "10:00 AM", "Automated Time Correction Remove Test");
        }

        [Test, TestCaseSource(nameof(AddCases))]
        [Author("YourName or email here")]
        [Category("DashboardTimeCorrectionTests")]
        public void ValidateGoogleAnalyticTest(string testname, string area, string eventName, string value)
        {

            var runner = new TestRunner();
            var testContext = SetTestContext(testname);
            //runner.Execute<ValidateGoogleAnalyticWorkflow>(workflow => { workflow.Execute(area, eventName, value); }, testContext);
        }
    }
}
