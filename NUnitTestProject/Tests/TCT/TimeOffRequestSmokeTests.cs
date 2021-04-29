using NUnit.Framework;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.TimeOffRequest;
using TestRunnerLibrary;

namespace NUnitTestProject.Tests.TCT
{
    public class TimeOffRequestSmokeTests
    {
        [TestFixture]
        public class EmployeeDashboardTests: BaseTest
        {

            [Test]
            [Author("YourName or email here")]
            [Category("RCSmokeTest")]
            public void ValidateTimeOffRequestTest()
            {

                var runner = new TestRunner();

                var testContext = SetTestContext(nameof(ValidateTimeOffRequestTest));

                runner.Execute<ValidateTimeOffRequest>(workflow => { workflow.Execute(); }, testContext);
            }

        }



    }
}