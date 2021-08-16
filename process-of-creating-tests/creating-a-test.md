---
description: Getting Started with your first test.
---

# Creating a Test

Creating tests in this framework is a process similar to Test Driven Development. We write and stub out what we think we want to automated, and then we work through the steps of making the test we created work. Below are the steps to help guide you through this process.

At a high level, our process can be broken up into these basic steps:

* **Planning**, plan our test our before writing any code. It will be the blueprint \(psuedo code for us\), and give us the best chance of identifying any difficult areas to automate, and potentially save us time, and designing better, less flaky tests
* **Build Base Test**\(s\) for TestSuite
* **Build out empty Workflow for Test**
* **Add steps for tests** we planned out as methods in workflow. However, do not code them, yet.
* **Add our source for TestData** and create any models needed for this testdata, if not already available.
* **Code**, start with first method \(step method\), and add code till complete. Repeat until each step method is coded.
* If any support code was not available that we created empty methods for it, we'll need to go back and add the code needed for those.
* When all code has been added for each method we can begin testing. Test could be after each step as you work through them, so you can see early what's missing or logic issues as you go along.
* Once all tested, we are done. Cleanup and refactor as needed.

## Step 1: Thinking - What do we want to test? \(Planning\)

Before coding anything, we should be thinking of what we want to test and then decide if it makes a good candidate for automation.

## Step 2: Build Base Test\(s\) for Test Suite

In this step, we are creating the Base Test, we have decided what tests we want to write for this testsuite, and here we are simply creating the Test class. To guide our work going forward. ✅ Can use the Example Test class, and copy and change to your tests with your values. 

## Step 3: Creating the Workflow

Now in our Test we added our Workflow\(s\) name. However, they probably are red because they have not been created yet. So in this step, we create those workflow classes, with the same name as we named then in the Test. They should be the name of the Test, appended with the work 'Workflow'. For example: ValidateAbleToLoginTest is the test name, and the workflow name would be ValidateAbleToLoginWorkflow. ✅ Can use the Example Workflow class, and copy and change to your workflow name to quickly get started.

## Step 4:  What Services/PageObjects do we need to complete our Test? \(Planning\)

Our tests will require access to Pages and the elements on those pages. We should have a Service available that exposes various grouped actions. For example, LoginService, provides methods for logging to system under Test.

Identifying what we'll need based on what we are testing, we can also figure out if we are missing any Services we might need to complete our test.

So for example, I know I need to Login, so the ILoginService is injected. If using the example workflow, this is already done. repeat this for any Services you know, you'll need. If not sure, that's ok, we can add those when we get to it.

## Step 5: Add Steps for test \(Code\)

In the Execute method, we add Tests steps as methods. They can be as Verbose in naming as needed, the goal is to clearly identify the actions that step is doing. Each step does not not necessary need to be a a single line, they can have multiple code lines as needed to complete the action the step does. For example, if I have method called DeleteTimecardEntries\(\), this method may take a few steps to accomplish it, and those details may not be important to a reader to understand what this test is doing from a non code perspective.

Now that we have created our Steps as methods, they are appearing as Red, because they don't exist. That is expected, and now we can use the Visual Studio quick actions, highlighting method and right clicking and selecting Generate method. VS will create the methods as not implemented. We have completed the first basic steps, and this could be checked in and reviewed before building it to have a check on what you are testing and the approach you'll be using.

## Step 6: Adding Source for TestData

While I'm planning my test, I'm also thinking about what Test Data do I need as well. For example, if I have a method that builds a WebKiosk Instance, I know in order to build that, I need InstanceName, InstancePassword, CompanyAlias, etc. So if I don't already have one, I typically, create a Model for the data \( for example, WebKioskConfigModel\) , and then use that Model to pass that data around as needed. This allows me to have that data setup in test, even if I don't have the actual values I will be using in place. Doing this is abstracting the data from the test, making the test resilient to change, as I can change the data without needing to change code in the test.

The TestData itself might come from repository class in code, or a json file, or where ever your data maybe store. We can reference that data as a GetTestData type method and pass it to our data Model.

NOTE: in the case where your data is not changing and its maybe one item, like a single string that doesn't make sense to put it in an data model, then its ok, to just set the string value in workflow.

## Step 7: Coding our Methods

Now that we have this built out skeleton of a workflow in place with all our steps outlines as methods, starting with the first method , we will add the code to make that method functional.

Assuming you have injected the dependencies for Services needed, we can now use each service, and the methods it provides in those methods. For example: 

I've injected LoginService, so I'd use \_login, and then locate the method available from intellisense that I need. 

✅ If I find a method I need was not available, not a problem. We can simply type it in anyway. It will be red, but using the VS Quickactions, can click on it, and select the option to create the method. It will create it on our interface, and then we will need to implement it on the concrete class. Also using the QuickActions on the concrete class to add the method \( as not implemented\) and then add the necessary code to it.

Repeat and rinse for each method.

## Step 8: Time to Test our Test

Some prefer to test as they go along, but you might prefer to run test after all pieces are in place depending on what the methods in your test do. 

If anything was correct the first time, and nothing missed, or incorrect order of steps, test should work fine. Otherwise, time to debug, starting with the first method that failed, and fixing what failed, and proceeding til they all pass. Similar to what happens when you do Test Driven Development. Fix until you get it to pass, and in the case of UIAutomation, always be sure you can at least consistently run test 10 times in a row at a minimum without failure to address any issues with test flakiness.



## Congratulations, if you following step 8 and passes you have just completed your first test!

### Gotchas: 

These steps seem pretty straight forward and in a perfect world they would work as intended. However, you may come up with issues and not sure what to do next. Here are some things to keep in mind that might help you when this happens: 

* If you find an element you are using is not behaving as expected, not doing what its supposed to, maybe its selecting the element, but not doing the secondary action of selecting an item on say a dropdown. This might be a case of the page object where the element code for accessing it, is not correct and needs maybe an extra wait, or certain type of selection method. If that's the case, you identify exactly what is wrong, and then adjust that element on that page object. You fixing it here will allow it to work for everyone else going forward. The Page Objects element methods are designed with a basic "should" work type method, but doesn't always work for everything and may need to be tweaked. Since Page Objects can't really be tested till you use in test, this is when you'll need to do that. 
* Sometimes a method in a Service, doesn't properly surface an error, and when you run test it might just proceed to the next step, and not tell you a failure occurred until the next step blows up. First identify that is the case, watch closely when you run it, and pay attention to that previous step before failure to be sure it actually did what it was supposed to. Then once you have figured out that the previous step caused error, add a try catch to that method in service to have it properly catch error and handle it, either killing test, or return a result and pass it to the next calling method so it can properly decide what the next step needs to be. Some cases you don't want test to fail, you just want check. The tricky part about this, is knowing if the method will ever be called to where it should error out, and when it should not ? When creating the Service, ideally we want to handle all methods results the same where possible, if it fails that group of actions, return a bool, and log it, and with that result the consumer of test can decide if that method needs to stop testcase run and log error, or do something else and proceed. 











