---
description: This describes what the TestContext, how to set and use with your tests.
---

# TestContext

## The TestContext for Configuring Tests

As mentioned in Getting Started section, the TestContext is for setting the available settings for your Test. It is set in the BaseTest that is inherited by your TestSuite. There are a variety of settings. Below is a basic items you should have:  

```
public TestContext SetTestContext(string testName)
        {
            var testContextBuilder = new TestContextBuilder();

            var testContext = testContextBuilder.Build();

            testContext.BrowserType = BrowserType.Chrome;
            testContext.TestName = testName;
            testContext.Team = Teams.TCT;
            testContext.RunType = RunType.Local;
            testContext.StartUrl = "";
            testContext.Active = true;
            testContext.ConfigName = "Default Config";
            testContext.Environment = Environment.TIN;

            return testContext;
        }
```

{% hint style="info" %}
 Each Test Suite, can have a different BaseTest inherited. You would do this, if you wanted to Run a certain group of test with a different configuration. Just create the BaseTest file in the directory of Test with a different name and inherit that Base Test file instead, formatted the same way as example with the new configuration settings.
{% endhint %}

#### Below is a list of the Available Settings, and which should be set ( if not set they will default to a base setting otherwise):

| Setting Name                   | Description                                                                                                                                                                          |
| ------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| BrowserType                    | Default is Chrome, but a few others are available                                                                                                                                    |
| TestName                       | This is passed to the test context from the Test, used for logging                                                                                                                   |
| Team                           | Can set the Team, also used for logging purposes                                                                                                                                     |
| RunType                        | 2 Run Types, Local which is default. Remote is for specialized Test env, like Docker, or later BrowserStack, or any other setup outside the regular Local or TeamCity triggered run. |
| StartUrl                       | This is the Url your test is starting on. Usually this would be based on the Test Environment that is set. However, can set to whatever you want.                                    |
| Active                         | Not in use yet, but the purpose is for if you had a variety of configurations defined and wanted mark one of them as Active so it will be used.                                      |
| ConfigName                     | Name of the configuration being used. Not fully implemented yet, but would allow external configurations to be loaded called by their names.                                         |
| AppVersion                     | For setting the version of the Application being tested against, for logging purposes.                                                                                               |
| Capabilities                   | Not in use yet, but will be for defining custom Selenium settings for a Browser.                                                                                                     |
| Headless                       | If Tests should be run Headless , set this flag to true. Default value is false.                                                                                                     |
| IsMobileEnabled                | Not implemented yet, but if Mobile testing was an option, could set this flag to true to let the TestRunner know this is a Mobile Test                                               |
| MobileDevice                   | When IsMobileEnabled is enabled, able to set what Mobile Device to run against                                                                                                       |
| TRTestCaseId                   | TestRail Testcase, if this value is set, results of a test can be recorded to TestRail                                                                                               |
| TRTestRunId                    | TestRailTestRunId, required for reporting to TestRail                                                                                                                                |
| ViewPort                       | This is for setting the ViewPort to the allowed Options                                                                                                                              |
| Environment                    | This is for setting the Environment test will be run in. Default is TIN                                                                                                              |
| <p></p><p>TestCategoryName</p> | Can pass the TestCategory to the context, this would be for logging purposes.                                                                                                        |
| Driver                         | Not in use, but could be set if more than one driver available to run tests with.                                                                                                    |

{% hint style="info" %}
Note: These settings may change, based on the needs for test, or expansion to the Test that requires new settings be added to the context. 
{% endhint %}
