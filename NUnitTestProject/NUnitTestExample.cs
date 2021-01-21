using NUnit.Framework;
using NUnitTestProject.Workflows;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch;

namespace NUnitTestProject
{
    public class Tests
    {
        [TestFixture]
        public class EmployeeDashboardTests
        {

            [Test]
            [Category("RCSmokeTest")]
            public void RunMyTest()
            {

                var runner = new TestRunner(nameof(RunMyTest));

                runner.Execute<ExampleTestWorkflow>(workflow => { workflow.Execute(); });
            }

            [Test]
            [Category("EmployeeDashboard")]
            public void VerifyRegularPunch()
            {

                var runner = new TestRunner(nameof(VerifyRegularPunch));

                runner.Execute<VerifyPunchWorkflow>(workflow => { workflow.Execute(); });
            }
        }

    }
}