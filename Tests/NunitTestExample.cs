using NUnit.Framework;
using NUnit.Extension.DependencyInjection;
using NUnit.Extension.DependencyInjection.Abstractions;

using DependencyInjectionExampleProject.Tests.Workflows;

namespace DependencyInjectionExampleProject.Tests
{
    public class NunitTestExample
    {
        
        [TestFixture]
        public class EmployeeDashboardTests
        {            

            [Test]
            [Category("RCSmokeTest")]
            public void RunMyTest()
            {
                var runner = new TestRunner(nameof(RunMyTest));

                runner.Execute<TestWorkflow>(workflow => { workflow.Execute(); });
            }
        }


        //[TearDown]

       
    }
}
