---
description: 'This describes what the TestContext, how to set and use with your tests.'
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

Below is a list of the Available Settings, and which should be set \( if not set they will default to a base setting otherwise\):

<table>
  <thead>
    <tr>
      <th style="text-align:left">Setting Name</th>
      <th style="text-align:left">Description</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td style="text-align:left">BrowserType</td>
      <td style="text-align:left">Default is Chrome, but a few others are available</td>
    </tr>
    <tr>
      <td style="text-align:left">TestName</td>
      <td style="text-align:left">This is passed to the test context from the Test, used for logging</td>
    </tr>
    <tr>
      <td style="text-align:left">Team</td>
      <td style="text-align:left">Can set the Team, also used for logging purposes</td>
    </tr>
    <tr>
      <td style="text-align:left">RunType</td>
      <td style="text-align:left">2 Run Types, Local which is default. Remote is for specialized Test env,
        like Docker, or later BrowserStack, or any other setup outside the regular
        Local or TeamCity triggered run.</td>
    </tr>
    <tr>
      <td style="text-align:left">StartUrl</td>
      <td style="text-align:left">This is the Url your test is starting on. Usually this would be based
        on the Test Environment that is set. However, can set to whatever you want.</td>
    </tr>
    <tr>
      <td style="text-align:left">Active</td>
      <td style="text-align:left">Not in use yet, but the purpose is for if you had a variety of configurations
        defined and wanted mark one of them as Active so it will be used.</td>
    </tr>
    <tr>
      <td style="text-align:left">ConfigName</td>
      <td style="text-align:left">Name of the configuration being used. Not fully implemented yet, but would
        allow external configurations to be loaded called by their names.</td>
    </tr>
    <tr>
      <td style="text-align:left">AppVersion</td>
      <td style="text-align:left">For setting the version of the Application being tested against, for logging
        purposes.</td>
    </tr>
    <tr>
      <td style="text-align:left">Capabilities</td>
      <td style="text-align:left">Not in use yet, but will be for defining custom Selenium settings for
        a Browser.</td>
    </tr>
    <tr>
      <td style="text-align:left">Headless</td>
      <td style="text-align:left">If Tests should be run Headless , set this flag to true. Default value
        is false.</td>
    </tr>
    <tr>
      <td style="text-align:left">IsMobileEnabled</td>
      <td style="text-align:left">Not implemented yet, but if Mobile testing was an option, could set this
        flag to true to let the TestRunner know this is a Mobile Test</td>
    </tr>
    <tr>
      <td style="text-align:left">MobileDevice</td>
      <td style="text-align:left">When IsMobileEnabled is enabled, able to set what Mobile Device to run
        against</td>
    </tr>
    <tr>
      <td style="text-align:left">TRTestCaseId</td>
      <td style="text-align:left">TestRail Testcase, if this value is set, results of a test can be recorded
        to TestRail</td>
    </tr>
    <tr>
      <td style="text-align:left">TRTestRunId</td>
      <td style="text-align:left">TestRailTestRunId, required for reporting to TestRail</td>
    </tr>
    <tr>
      <td style="text-align:left">ViewPort</td>
      <td style="text-align:left">This is for setting the ViewPort to the allowed Options</td>
    </tr>
    <tr>
      <td style="text-align:left">Environment</td>
      <td style="text-align:left">This is for setting the Environment test will be run in. Default is TIN</td>
    </tr>
    <tr>
      <td style="text-align:left">
        <p></p>
        <p>TestCategoryName</p>
      </td>
      <td style="text-align:left">Can pass the TestCategory to the context, this would be for logging purposes.</td>
    </tr>
    <tr>
      <td style="text-align:left">Driver</td>
      <td style="text-align:left">Not in use, but could be set if more than one driver available to run
        tests with.</td>
    </tr>
  </tbody>
</table>

{% hint style="info" %}
Note: These settings may change, based on the needs for test, or expansion to the Test that requires new settings be added to the context. 
{% endhint %}

