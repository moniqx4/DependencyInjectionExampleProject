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

                PunchLogic pl = new PunchLogic();
                var punchData1 = pl.GetPunchTest1Details();
                var punchData2 = pl.GetPunchTest2Details();

                runner.Execute<ValidatePunchWorkflow>(workflow => { workflow.Execute(punchData1); }, testContext);
            }
        }

    }
}