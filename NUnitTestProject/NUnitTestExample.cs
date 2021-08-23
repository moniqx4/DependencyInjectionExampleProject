using NUnit.Framework;
using NUnitTestProject.Workflows;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Punch;
using PageObjects.WTDashboards.Models.Enums;
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

                PunchDataFactory pl = new PunchDataFactory();
                var punchData1 = pl.GetPunchTest1Details();
                var punchData2 = pl.GetPunchTest2Details();

                //var punchBuilder = new PunchBuilder();                
                //var punchDetails = punchBuilder.Build();
                //punchDetails.PunchDataModel.PunchType = PageObjects.WTDashboards.Models.Enums.PunchType.ClockIn; // then pass the punchDetails through the execute

                PunchBuilder punchBuilder = new PunchBuilder();
                PunchTestModel clockinPunch = punchBuilder.AddPunchType(PunchType.ClockIn)
                                                    .AddPunchMethod(DataModelLibrary.PunchMethod.Regular)
                                                    .Build();

                runner.Execute<ValidatePunchWorkflow>(workflow => { workflow.Execute(pl); }, testContext);
            }
        }

    }
}