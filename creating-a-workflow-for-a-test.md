---
description: >-
  Each Test or set of Tests ( for data driven ) must have a WorkFlow associated
  with it. WorkFlows are where the actual test steps are defined and run.
---

# Creating a WorkFlow for a Test

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

**Important pieces of a Workflow:**

* The biggest thing is the Execute method. This method is the only thing the Test will read for executing sets. If any values were passing in from test, they would be passed to this method. 
* Steps are defined as well descriptive methods, they can be named whatever , and should be descriptive to what they do that can easily be understood by a reader. 
* All Test Step methods should be created as private void methods. Expecting each step to be self contained and not returning anything to the next step. They could return values, but ideally you would not do this. However, not run saying you should never do this, do as you see fit. 
* Workflows use Automation Services injected as readonly to do the work required by the defined test steps. 
* In the above example, it shows LoginService used and the first step is login, the Login method created is where you could use the LoginServices methods.  Do NOT put the methods injected in from a service directly in the Execute method. Even though you could do this, the idea is to keep the Execute method as clean as possible and easy to follow. So to be consistent with how all tests will be written, expect your test steps to be done the same way.

\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

The typical idea behind working with a workflow is as you, the designer of the test, is writing out each step, you would write them in the Execute method first as Pseudo code. For example:

_My test steps might look like this:_

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

Once I think I have all the steps I need to automate this test, then you add these Test Steps defined as methods. Right clicking on each method in Visual Studio will provide an option of generating the method for each one. They will be created for you, as private void methods and as not implemented. All ready for you to add code. This allows you to work with someone else to plan your tests, and write the code later. This can be compiled without the code and submitted for a PR review and worked on later. Basically, a Test Driven  design pattern for automation. This is one of the key aspects of using this approach to writing tests in this way.

{% hint style="info" %}
The code in each method is whatever it needs to be to get the job done for that step. Since it is private, it gives the coder the flexible to write code how they see fit, as long as it executes the step it is associated with and does the actions based on the method's description \( the method name\). That is why its ok to have longer names if needed. Each word in the name should be PascalCase as shown in example.
{% endhint %}



\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

**Injecting Services:**

The other important thing about working with workflows, 

