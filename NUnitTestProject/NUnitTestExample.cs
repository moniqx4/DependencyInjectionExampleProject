using NUnit.Framework;
using NUnitTestProject.Workflows;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch;
using TestRunnerLibrary;

namespace NUnitTestProject
{
    public class NuniTestExample
    {
        [TestFixture]
        public class EmployeeDashboardTests : BaseTest
        {

            [Test]
            [Category("RCSmokeTest")]
            public void RunMyTest()
            {

                var runner = new TestRunner();

                var testContext = SetTestContext(nameof(RunMyTest));

                runner.Execute<ExampleTestWorkflow>(workflow => { workflow.Execute(); }, testContext);
            }

            [Test]
            [Category("EmployeeDashboard")]
            public void ValidateRegularPunch()
            {

                var runner = new TestRunner();

                var testContext = SetTestContext(nameof(ValidateRegularPunch));

                runner.Execute<ValidatePunchWorkflow>(workflow => { workflow.Execute(); }, testContext);
            }
        }

    }
}