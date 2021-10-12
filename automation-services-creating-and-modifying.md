---
description: >-
  Automation Services are the workhorse of the framework. They are what give the
  workflows for tests functionality. They are the abstraction layer between the
  Page Objects and the WorkFlows.
---

# Automation Services: Creating and Modifying

### **Automation Service Defined: **

**What each Automation Service consists of: **

* An Interface 
* A Concrete Class

:exclamation: Each Automation Service **MUST** have an interface with an associated Concrete class. This is to allow the DI container system to manage these services.

:exclamation: All Interfaces **MUST** start with the capital letter I and their Concrete classes **MUST **be the same name, without the I in front of it.  The DI Container system is setup with a rule that looks for Interfaces and automatically associated them with their concrete class and registers them to be managed by the container. By following these base rules when creating one, then you don't have to worry about adding them manually when you create a new service. The only time you would do that, is if you specifically needed this class instantiated in a specific way outside of what is configured. Basically, not likely you'll need to do that for any of the Services you would create for this framework.

### How to Modify an existing Automation Service: 

### How to Create a New Automation Service:

```
Example Interface: 

   public interface INavigationService
    {           

        void NavigateViaUrl(string baseUrl, string path);

        void NavigateViaWTTopMenu(string topMenu, string menuOption=null);

        void NavigateViaSideMenu(string menuOption);
    }
```

```
 Example of Concrete Class:
 
using DataModelLibrary;
using AutomationServices.SharedServices.BrowserActions;
using AutomationServices.SharedServices.ElementActions;
 
 public class NavigationService :  INavigationService
    {
        
        private readonly IBrowserActions _browser;
        private readonly IElementActions _element;

        public NavigationService(IBrowserActions browser, IElementActions element)
        {           
            _browser = browser;
            _element = element;
        }


        public void NavigateViaSideMenu(string menuOption)
        {
           
            _element.ClickElement(LocatorType.DataAutomationId, "hamburgermenutoggle");
            _element.ClickElement(LocatorType.DataAutomationId, menuOption);           
        }

        public void NavigateViaUrl(string baseUrl, string path)
        {            
            _browser.NavigateToPageUrl(baseUrl + path);
        }

        public void NavigateViaWTTopMenu(string topMenuLocator, string menuOption = null)
        {
            
            _element.ClickElement(LocatorType.DataAutomationId, topMenuLocator);           

            if (menuOption != null)
            {
                _element.ClickElement(LocatorType.DataAutomationId, menuOption);
            }
           
        }
        }
```

Automation Services utilize other Automation Services and/or Page Objects. This sub-project does NOT have direct access to the Selenium WebDriver. However, if unable to find a service or page object that works for your needs and creating a page object doesn't make sense, for these special situations there are two interfaces available: IBrowerActions for browser control and IElementActions for element interaction.

It is expected these only be used for those special snowflakes. Basically if you decide to use them, your PR will be more closely looked at for other alternatives. 
