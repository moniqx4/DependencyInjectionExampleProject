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
            [Author("Monica S.")]
            [Category("RCSmokeTest")]
            public void ValidateTimeOffRequestTest()
            {

                var runner = new TestRunner(nameof(ValidateTimeOffRequestTest));

                runner.Execute<ValidateTimeOffRequest>(workflow => { workflow.Execute(); });
            }

            //[Test]
            //[Category("EmployeeDashboard")]
            //public void ValidateRegularPunch()
            //{

            //    var runner = new TestRunner(nameof(ValidateRegularPunch));

            //    runner.Execute<ValidatePunchWorkflow>(workflow => { workflow.Execute(); });
            //}
        }

    }
}