using NUnit.Framework;
using NUnitTestProject.Workflows;

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

                var runner = new TestRunner(nameof(RunMyTest),"V3");

                runner.Execute<ExampleTestWorkflow>(workflow => { workflow.Execute(); });
            }
        }

    }
}