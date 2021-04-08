using NUnit.Framework;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.TimeOffRequest;

namespace NUnitTestProject.Tests.TCT
{
    public class TimeOffRequestSmokeTests
    {
        [TestFixture]
        public class EmployeeDashboardTests
        {

            [Test]
            [Author("YourName or email here")]
            [Category("RCSmokeTest")]
            public void ValidateTimeOffRequestTest()
            {

                var runner = new TestRunner(nameof(ValidateTimeOffRequestTest));

                runner.Execute<ValidateTimeOffRequest>(workflow => { workflow.Execute(); });
            }

        }



    }
}