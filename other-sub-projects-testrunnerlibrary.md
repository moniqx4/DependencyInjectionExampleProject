---
description: Details on the TestRunner configuration
---

# Other Sub-Projects: TestRunnerLibrary

The TestRunner is the starting point for all your tests. Its also the one place you don't want to make changes to unless you are sure of the change you are making as it could break your entire framework from being able to run tests.

Since its the starting point for all your tests, it builds the Container for your project here. In the code that is the ServiceProvider class. Once it successfully builds the container, it then builds the TestContext. The TestContext holds the data necessary for that single test to have whatever needed information available  throughout that test session from beginning to end and maintains that information. Its purpose is to keep a state of affairs that following the test, in order to maintain one instance, of those items available through the TestContext. 

It has a TestContext \( basically the model\) and a TestContextBuilder, and when passed into the Constructor of a class that needs this context, can be added to give access. For example, the testcase name, needs to be maintained throughout the life of the Test.

