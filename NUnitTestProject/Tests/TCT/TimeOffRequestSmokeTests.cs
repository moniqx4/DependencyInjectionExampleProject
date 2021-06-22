using NUnit.Framework;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.TimeOffRequest;
using TestRunnerLibrary;
using TestContext = TestRunnerLibrary.TestContext;

namespace NUnitTestProject.Tests.TCT
{

    using static TestSetupTeardown;

        public class TimeOffRequestSmokeTests : BaseTest
        {
            public TestContext TestContext { get; set; }

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