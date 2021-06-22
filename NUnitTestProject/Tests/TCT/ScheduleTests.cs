﻿using NUnit.Framework;
using NUnitTestProject.Workflows.WebTime.EmployeeDashboard.Schedule;
using TestRunnerLibrary;
using TestContext = TestRunnerLibrary.TestContext;

namespace NUnitTestProject.Tests.TCT
{
    using static TestSetupTeardown;

    public class ScheduleTests : BaseTest
    {


        [Test]
        [Author("YourName or email here")]
        [Category("RCSmokeTest")]
        public void ValidateScheduleEntryTest()
        {

            var runner = new TestRunner();

            var testContext = SetTestContext(nameof(ValidateScheduleEntryTest));

            runner.Execute<ValidateScheduleEntry>(workflow => { workflow.Execute(); }, testContext);
        }


        [Test]
        [Author("YourName or email here")]
        [Category("RCSmokeTest")]
        public void ValidateScheduleShiftDetailsDrawerTest()
        {

            var runner = new TestRunner();

            var testContext = SetTestContext(nameof(ValidateScheduleShiftDetailsDrawerTest));

            //runner.Execute<ValidateScheduleShiftdetails>(workflow => { workflow.Execute(); }, testContext);
        }
    }
}
