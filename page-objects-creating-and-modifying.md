---
description: >-
  Page Objects in this framework are "pure" page objects. They do not contain
  combined functionality. They simply provide access to each element on a
  specific page.
---

# Page Objects: Creating and Modifying

## Components of a Page Object: 

* All Page Objects have an Interface and a Concrete Class. The naming of these items follows the same rules noted in the Automation Services [section.](automation-services-creating-and-modifying.md#automation-service-defined)
* Some Page Objects might also have an Elements file, usually for those page objects with a long list of elements.
* Page Objects is a general term to refer to the following: 
  * Page the main page itself.
  * Component, which is basically a Page within a Page
  * Modal
  * Drawer
* These various type of Page Objects are named with the type appended to the Page Object, for example: PunchComp, PunchDrawer, etc.  Note: the abbreviation of the word Comp instead of using the full word Component. I think in this case its fine to use the abbreviation, saves on the typing.



## 

## How to Modify an Existing Page Object:

Depending the item being modified, follow the pattern that the current page has. Since all Page Objects have Interfaces, if adding a new element to a page, be sure and include that element reference in the Interface. If changing an existing page object element, should only be changing the locator value and nothing else. If for some reason you need to change the name of method, be sure any references in the interface are changed as well, unless you are sure nothing else is referencing the element in the project.

{% hint style="warning" %}
 Super-powers are granted randomly so please submit an issue if you're not happy with yours.
{% endhint %}

## How to Create a New Page Object:

The new page inherits a BasePageObject, that gives access to common element interactions: 

* ClickElement
* SetElementText
* GetElementText
* ClickCheckbox

If you need anything outside of these common element interactions, a new one can be created my injecting IWebPage. IWebpage exposes all the available Selenium based ways of handling an element on a webpage. They can be combined with each other to handle accessing more complex elements within a page.

If your page object needs access to Browser commands, inject the IBrowser interface.

When creating a new Page Object, name and append it with the Type the page object is, as noted above. If you need to create a Page Object that has other items associated with it, create a folder to house all of that pages pieces, and create a different page object for each piece.  

{% hint style="warning" %}
Not required, but when dealing with a big page object with multiple pieces that belong to it, I will create one overall Interface \( for example, IEmployeeDashboardPages, notice the 's'\), that does not have a concrete class associated with it, and then use it to inherit all the other interfaces for each piece. This allows injection of the one interface to get access to all the smaller pieces without needing to inject each one. Very helpful for services that need to use all the pieces and still have the option to just inject the individual pieces as well for services that might just need a one or a few of the pieces.
{% endhint %}

The one downside to this, is the Intellisense list will become quite long as it will have all the pieces methods listed.

{% hint style="info" %}
Another ideal way to handle page objects, is to have them return this, unless they are the last option on a page, for example, the Submit button, this one set to void. The reason for doing this, allows the fluent way of coding to be used and the last option such as Submit being set to void, since after that element is clicked, no other actions can be made on that page.
{% endhint %}

{% code title="Example of how the fluent code would be for login when coded this way :" %}
```bash

loginPage.SetCompanyAliasTextBox
         .SetUsernameTextBox
         .SetPasswordTextBox
         .ClickSubmit();
```
{% endcode %}

{% hint style="success" %}
Makes for very easy reading and easier to code in this way.
{% endhint %}

**Example of a LoginPage page object:** 

```bash
using DataModelLibrary;


namespace PageObjects.Login.ConcreteClasses
{
    public class LoginPage : BasePageObject, ILoginPage
    { 
        public void ClickSubmitButton()
        {            
            var locator = SetLocator(LocatorType.Id, LoginElements.BTN_SUBMIT_ID);

            HandleClickElement(locator);
        }

        public ILoginPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(LocatorType.Id, LoginElements.TXTBOX_USERNAME_ID);
           
            HandleTextBox(locatorModel, username);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {          
            var locatorModel = SetLocator(LocatorType.Id, LoginElements.TXTBOX_PASSWORD_ID);

            HandleTextBox(locatorModel, password);

            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {

            var locatorModel = SetLocator(LocatorType.Id, LoginElements.TXTBOX_COMPANYALIAS_ID);

            HandleTextBox(locatorModel, companyAlias);

            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            var locatorModel = SetLocator(LocatorType.Id, LoginElements.TXTBOX_BADGENUMBER_ID);

            HandleTextBox(locatorModel, badgeNumber);

            return this;
        } 
       
    }
}

```

🧐 Notice the verbose element names. This is done to make it clear, exactly what the action the element can be accessed.

#### FAQ: 

* **What if an element on a page, I need to do multiple actions on it? for example Get the Text from a button element ? The basic method would normally be Click method for this type of element:** 
  * The idea to start is for these page objects to provide the methods for the basic expected operations, buttons would be a click method, etc. Then if needed to create a test for that page object that needs different actions  on these elements, these methods are created they as needed at that time. This reduces the need to create more methods then what are actually used or the need to cover all the various ways to handle an element.



