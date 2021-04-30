---
description: >-
  This guide assumes you are already familiar with writing tests in general with
  Selenium as we are doing today. We will start from NUnit and and work our way
  through the framework.
---

# Getting Started with UIAutomation 2021

## Write First Test

To create a Test, we'll use the Template that will layout our basic structure. In Visual Studio, select add New Item, and in there are some custom ones created for writing test. One will be called NUnit Test Example, select that one and it will look similar to the following: 

```
public class NameOfYourTestTests
    {
        [TestFixture]
        public class NameOfYourTestTests: BaseTest
        {

            [Test]
            [Author("YourName or email here")]
            [Category("RCSmokeTest")]
            public void ValidateSomeFunctionalityTest()
            {

                var runner = new TestRunner();

                var testContext = SetTestContext(nameof(ValidateSomeFunctionalityTest));

                runner.Execute<ValidateSomeFunctionWorkflow>(workflow => { workflow.Execute(); }, testContext);
            }

        }
```

Import pieces to take note of this template: 

* The Test name is appended with the word Test, ValidateSomeFunctionalityTest . This is done to easily see the difference between the Test and the WorkFlow it uses. 
* Notice the name of the Workflow is appended with the word Workflow, ValidateSomeFunctionWorkflow. This done to make it clear this is a Workflow for a Test. 
* In this framework Tests are simply the director. Sets the TestRunner with the Tests its running, and then pointing it to the Workflow to run that Test.  
* A Workflow can be used for multiple Tests, assuming the all use the same Steps. This is what you would do in the case of writing data driven Tests. 
* When not doing Data Driven, the Test would be a 1:1 relationship. 
* The next important piece is the TestContext. The TestContext sets all the pertinent information related to your test settings. You'll notice the test is inheriting from a BaseTest , this BaseTest file is where you would setting with whatever setting available in the TestContext. The BaseTest are settings that will be used for all the Tests in this files Test Suite. Each TestSuite can have a different BaseTest if you want it to use different settings from one group of tests to another. We'll talk about that more in depth later. For now we'll use the default one set here.

{% hint style="info" %}
 The Author NUnit attribute is an optional feature, put in to make it easier to see who originally worked on test just in case someone has questions on a testcase. Granted in Visual Studio one can see whom last updated, but that doesn't mean they originally wrote it. Could also review history in BitBucket, but just easier if right here. We also have a few other custom attributes for NUnit available, not listed here, Jira for the Jira story card number, and also TRTestcaseId, for the testcase associated with Test.
{% endhint %}

This Template below is a little bit different, demonstrating a Test Driven Test that is using NUnit's TestCase Source to manage the test data for driving the test:

{% code title="TImeCorrectionTests.cs" %}
```bash
 private static IEnumerable<TestCaseData> AddCases()
        {
            yield return new TestCaseData("ValidateAddTimeCorrectionTests", TimeCorrectionType.Add, PunchType.ClockIn, "04/15/21", "8:00 AM", "Automated Time Correction Add Test");
            yield return new TestCaseData("ValidateEditTimeCorrectionTests", TimeCorrectionType.Edit, PunchType.ClockIn, "04/15/21", "8:00 AM", "Automated Time Correction Edit Test");
            yield return new TestCaseData("ValidateRemoveTimeCorrectionTests", TimeCorrectionType.Remove, PunchType.ClockIn, "04/15/21", "8:00 AM", "Automated Time Correction Remove Test");
        }

        [Test, TestCaseSource(nameof(AddCases))]
        [Author("YourName or email here")]
        [Category("DashboardTimeCorrectionTests")]        
        public void ValidateTimeCorrectionTest(string testname, TimeCorrectionType tcType, string punchDate, string punchTime, string reason)
        {

            var runner = new TestRunner();
            var testContext = SetTestContext(testname);
            runner.Execute<ValidateTimeCorrectionsWorkflow>(workflow => { workflow.Execute(tcType, punchDate, punchTime, reason); }, testContext);
        }
```
{% endcode %}

Import pieces to take note for this template: 

* Each set of data that will be passed to test a new TestCaseData. In this example, the TestName is first, then each piece of actual testdata is separated by a comma. 
* The NUnit attribute \[Test, TestCaseSource\(nameof\(AddCases\)\)\], where AddCases is passed. Can just juse the method name of AddCases, but could be named whatever, as long as its the same in both places. A user might want a different name if they have different sets of data setup. 
* Notice where the variables are passed to testcase: ValidateTimeCorrectionTest\(string testname, TimeCorrectionType tcType, string punchDate, string punchTime, string reason\), this must match what is in each data set. 
* Now notice in the Workflow Execute, the variables are passed to the test, except the TestName, this is excluded, this value is only passed to the TextContext. Only actual TestData is passed to the WorkFlow to the Execute method:   runner.Execute\(workflow =&gt; { workflow.Execute\(tcType, punchDate, punchTime, reason\); }, testContext\);

