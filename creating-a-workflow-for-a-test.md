---
description: >-
  Each Test or set of Tests ( for data driven ) must have a Workflow associated
  with it. Workflows are where the actual test steps are defined and run.
---

# Creating a Workflow for a Test

## Getting Started with creating a WorkFlow

In Visual Studio, Add a New Item, and there will be listed a Test WorkFlow item. Select that to get the base Template:

```
 public class ExampleTestWorkflow
    {
        private readonly ILoginService _loginService;

        public ExampleTestWorkflow(ILoginService loginService)
        {
            _loginService = loginService;
        }

        /* Steps that will be executed must be in the Execute Method */
        public void Execute()
        {            

            Login();
            
        }

        /* All test steps should be private methods, generally void */
        private void Login(string baseUrl)
        {
            _loginService.LoginToWTEEDashboard();          
        }       
    }
```

#### **Important pieces of a Workflow:**

* The biggest thing is the Execute method. This method is the only thing the Test will read for executing sets. If any values were passing in from test, they would be passed to this method. 
* Steps are defined as well descriptive methods, they can be named whatever , and should be descriptive to what they do that can easily be understood by a reader. 
* All Test Step methods should be created as private void methods. Expecting each step to be self contained and not returning anything to the next step. They could return values, but ideally you would not do this. However, not run saying you should never do this, do as you see fit. 
* Workflows use Automation Services injected as readonly to do the work required by the defined test steps. 
* In the above example, it shows LoginService used and the first step is login, the Login method created is where you could use the LoginServices methods.  Do NOT put the methods injected in from a service directly in the Execute method. Even though you could do this, the idea is to keep the Execute method as clean as possible and easy to follow. So to be consistent with how all tests will be written, expect your test steps to be done the same way.

\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

The typical idea behind working with a workflow is as you, the designer of the test, is writing out each step, you would write them in the Execute method first as Pseudo code. For example:

_**My test steps might look like this:**_

{% code title="ExampleWorkFlow.cs" %}
```bash
public void Execute()
        {            

            Login();
            NavigateToEmployeeTimecard();
            LocateEmployeeTimecard();
            EnterTimeEntry():
            ValidateEnterTimeEntry();
            
        }
```
{% endcode %}

Once I think I have all the steps I need to automate this test, then you add these Test Steps defined as methods. Right clicking on each method in Visual Studio will provide an option of generating the method for each one. They will be created for you, as private void methods and as not implemented. All ready for you to add code. This allows you to work with someone else to plan your tests, and write the code later. This can be compiled without the code and submitted for a PR review and worked on later. Basically, a Test Driven design pattern for automation. This is one of the key aspects of using this approach to writing tests in this way.

{% hint style="info" %}
The code in each method is whatever it needs to be to get the job done for that step. Since it is private, it gives the coder the flexible to write code how they see fit, as long as it executes the step it is associated with and does the actions based on the method's description \( the method name\). That is why its ok to have longer names if needed. Each word in the name should be PascalCase as shown in example.

If a user can read this section and know all the steps being executed in the test, without reading anything else, then you have created your workflow with the correct amount of granularity. 

\*\*\*\*❗ **Bad Example:** 

Login\(\);  
RunTest\(\);

Just reading this, I have no idea what is being tested, or how its being tested by the script.
{% endhint %}



\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

#### **Injecting Automation Services:**

The other important thing about working with workflows, is understand what an Automation Service is, and how to get them into your workflow.

Automation Services are basically similar actions grouped together to provide common used tasks. For example, a LoginService is designed for logging in to anywhere in the application you can log in. Do not get them confused with a Page Object. Automation Services are NOT Page Objects. Automation Services use Page Objects and even other Automation Services to complete their tasks. 

Automation Services are not necessarily a 1 to 1 relationship for a Page Object, even if they may appear to that way. See the section on Creating Automation Services to get a better understanding.

Now with the definition out the way, how do you get access to these services? In the framework, Dependency Injection has been setup. This means anything with an Interface is managed by a container system and can be injected where needed. This allows code to be decoupled and easier to work with and maintain. When injected, classes/objects do not need to be instantiated before they can be used. The container takes care of that behind the scenes. The container is configured for using constructor injection, so as name implied , these services are Injected into a classes constructor.

#### **Steps to Inject a Service:** 

* At the top, above the constructor the Automation Service you need is added as private readonly as shown in example below.
* Once you do that, you may notice a light squiggle in Visual Studio under the line. If you right click on that squiggle line, Visual Studio's context menu will have an option to add parameter to the constructor. 
* Select this option and Visual Studio will automatically add the rest of code to complete the Injection. That is it, you have injected your service and now it can be used throughout your Workflow using the \_nameService that you have given it, as displayed in example. The intellisense displaying what methods are available.

{% hint style="info" %}
If you Inject a service and then notice the intellisense does not provide a method you need, first be sure you have injected the proper service you need. Second, you may have to add the functionality to the service that is missing. Read the section on Creating and Modifying Automation Services to learn how to do that.
{% endhint %}

```bash
 private readonly ILoginService _loginService;

 public ExampleTestWorkflow(ILoginService loginService)
 {
     _loginService = loginService;
 }
```

