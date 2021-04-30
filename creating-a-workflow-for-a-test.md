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

Important pieces of a Workflow:

* The biggest thing is the Execute method. This method is the only thing the Test will read for executing sets. If any values were passing in from test, they would be passed to this method. 
* Steps are defined as well descriptive methods, they can be named whatever , and should be descriptive to what they do that can easily be understood by a reader. 
* All Test Step methods should be created as private void methods. Expecting each step to be self contained and not returning anything to the next step. They could return values, but ideally you would not do this. However, not run saying you should never do this, do as you see fit. 
* Workflows use Automation Services injected as readonly to do the work required by the defined test steps. 
* In the above example, it shows LoginService used and the first step is login, the Login method created is where you could use the loginServices methods.  Do NOT put the methods injected in from a service directly in the Execute method. Even though you could do this, the idea is to keep the Execute method as clean as possible and easy to follow. So to be consistent with how all tests will be written, expect your test steps to be done the same way.



{% code title="hello.sh" %}
```bash
# Ain't no code for that yet, sorry
echo 'You got to trust me on this, I saved the world'
```
{% endcode %}



