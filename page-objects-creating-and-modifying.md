---
description: >-
  Page Objects in this framework are "semi- pure" page objects. They do not
  contain combined functionality. They simply provide access to each element on
  a specific page exposing the basic action.
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



## Base Rules: 

* Methods for page objects should prefix the action they provide: For example, ClickApplyButton\(\), or SeUsernameTextbox\(string username\); See section below: How to Create a New Page Object. 
* All Page Objects MUST have an interface, except in the case of using a Partial class. See section Large Page Objects below, for more details on using Partial classes. 
* Page Objects do NOT require logging lines for each method. However, if you are catching an error, you  do want to log that catch, to provide an assist for debugging. Logging the error that was caught and how it was handled. 

## How to Modify an Existing Page Object:

Depending the item being modified, follow the pattern that the current page has. Since all Page Objects have Interfaces, if adding a new element to a page, be sure and include that element reference in the Interface. If changing an existing page object element, should only be changing the locator value and nothing else. If for some reason you need to change the name of method, be sure any references in the interface are changed as well, unless you are sure nothing else is referencing the element in the project.

{% hint style="warning" %}
 Super-powers are granted randomly so please submit an issue if you're not happy with yours.
{% endhint %}

## How to Create a New Page Object:

The new page injects IWebPage/WebPage, this gives access to all the wrapped methods for working with elements. The methods are prefixed with their corresponding elements: 

* Click:  all methods prefixed with Click are methods for clicking on Elements
* Set: all methods that set a value on an element, for example a TextField are prefixed with ex. SetText
* Get: all methods prefixed with Get, get something and return it, it can be text, and element object, etc. ex. GetElement
* Select: all methods prefixed with Select means its a method for Selecting something, for example from a dropdown, combobox, or selector of some sort.
* Does/Is: all methods prefixed with Does or Is, are bool methods that is doing a check of some sort and returning True or False, for example, DoesElementExists, IsElementDisplayed, these methods will do check and return a result of true or false, and will not error out, allow the user of method to decide if they want to Assert and fail out of test, or do some other action.

If your page object needs access to Browser commands, inject the IBrowser interface.

When creating a new Page Object, name and append it with the Type the page object is, as noted above. If you need to create a Page Object that has other items associated with it, create a folder to house all of that pages pieces, and create a different page object for each piece.  

{% hint style="warning" %}
**Large Page Objects:** Not required, but when dealing with a big page object with multiple pieces that belong to it, there are a few ways to do this: 

**Option 1:** 

1. Create the main Page Object that houses all the sub components. For example, EmployeeDashboard page.
2. Use the **partial** accessor on class.
3. Create your constructor and inject IWebPage as a dependency
4. For a component of this page, create a new class with the name of the item for the filename, for example. ActivityComp, which lets me know this is not a page but a component. If it were a Drawer then append with Drawer, etc.
5. In that class after you have created it, change the className in the file \( not the filename\) to the same class name of the main page object, so for our example,  it would be called public partial class EmployeeDashboardPage, this allows C\# to see this class as just an extension of the main class, and to be handled as one big class.
6. Now that we have done that, we also get access to any dependencies that are injected on the main class, so we don't have to inject anything in these partial classes. If we need to add a new dependency, we do it from the main class.
7. Now any methods we add to any partial class, for example in ActivityComp, we expose it on the IEmployeeDashboardPage interface.
8. You can make more classes as partials as needed simply by changing the class name to the main class with partial as an accessor. REMEMBER, the class filename, should be respective of the actual page object its is. You'll get error if you tried to name it the same since you can't have filenames that are exactly the same anyway. Besides, when adding new methods, you want to organize them and need to know where the method needs to live.

Now when we inject the IEmployeeDashboardPage, we get access to all the methods for all its components \( as the partials\), instead of needing to inject each one separately. 

Special Rules when using this method: 

* Only go one level down as a partial to a main class. For example, if you have sub Components of a sub component, such as EmployeeDashboardPage has an ActivityComp, and the ActivityComp has TimeCorrection components \(drawers, tabs\), best to create a new main for the sub-component of the sub component, and then make all the partial classes for that sub-sub-component on that main instead. So in my example, TimeCorrectionComp would be a main class, and then TimeCorrectionAddDrawer would be a partial class to TimeCorrectionComp. This helps to separate those concerns, granted,  I will need to inject both IEmployeeDashboardPage, and TimeCorrection when writing tests that need access to the TimeCorrection methods, if getting to the TimeCorrection elements requite access through the ActivityComp.

**Option2:** 

Using an interface that does not have a Concrete class associated with it, and instead inheriting all the interfaces for the components you want access to. This approach means, that all the components associated with it, MUST all have their own interfaces and concrete classes, they also must inject the dependencies they need on each component.

Step 1:  Create one overall Interface \( for example, _**IEmployeeDashboardPages**_, notice the 's'\).

Step2: Do not create a concrete class for it, instead,  inherit the interface\(s\) to the components that will be associated with it. 

Step 3: Create your sub components, with its interface and concrete class as normal, and then add their interface to be inherited to the main interface, in this example , IEmployeeDashboardPages : IActivityComp, IPunchComp

This allows injection of the one interface to get access to all the smaller pieces without needing to inject each one. Very helpful for services that need to use all the pieces and still have the option to just inject the individual pieces as well for services that might just need a one or a few of the pieces.

So which Option should you use?

The depends, Option 1 is great, if you are don't need the flexibility of injecting any of its sub components only. Which technically, you shouldn't need them as standalone. Its less code. However, note this approach, does make it a little challenging for a new person not familiar with code, to know all the partial classes associated from just looking \( they can search by main class name, and then would be shown all of them\). Also, the sub component of a subcomponent getting separated out, can also be a little confusing for consumers of this page object. It also requires a little bit of extra planning when setting up.

Option 2 has one caveat about it, if your main class, actually has methods, for example, Say the EmployeeDashboard page, has elements on it, that are not part of any of the components, where do they end? you can't create main concrete class for it, because if you do and add it there, it will need to inherit all the methods from the inherited interfaces, and we don't want to do that, since they each have their own concrete class. So if your main page object is this type, then should use Option 1 instead.
{% endhint %}

_\*\*\*\*_❗ _The one downside to both these options, is the Intellisense list will become quite long as it will have all the components' methods listed and you'll also need to be very clear with your method naming, so you don't end up with methods on the Intellisense list that are hard to know the difference between them. For example, the ClickSaveButton on Component1, or the same method on Component2. **Consider naming the methods that also include the component it belongs to as well.**_

## **Fluent or not so Fluent**

Another ideal way to handle page objects, is to have them return this, unless they are the last option on a page, for example, the Submit button, this one set to void. The reason for doing this, allows the fluent way of coding to be used and the last option such as Submit being set to void, since after that element is clicked, no other actions can be made on that page.

{% hint style="info" %}
One major difference with Fluent usage when Dependency Injection is used, versus using an Inheritance Model, is in the Inheritance model the returning of this, returns an object for the next calling class to use it, and not have to instantiate the object.

With Dependency Injection, we have the container that handles the objects, so it is really just allowing a code writing style, that can be easier to read when grouping multiple steps together as the code example below shows.
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
    public class LoginPage : ILoginPage
    { 
    
        private readonly IWebPage _webPage;
        
        public LoginPage(IWebPage webPage)
        {
            _webPage = webPage;
        }
        
        
        public void ClickSubmitButton() => _webPage.ClickElement(LocatorType.Id, LoginElements.BTN_SUBMIT_ID);
       
        public ILoginPage SetUsernameTextBox(string username)
        {
            var locatorModel = SetLocator(LocatorType.Id, LoginElements.TXTBOX_USERNAME_ID);
           
            _webPage.SetText(LocatorType.Id, LoginElements.TXTBOX_USERNAME_ID);

            return this;
        }

        public ILoginPage SetPasswordTextBox(string password)
        {  
            _webPage.SetText(LocatorType.Id, LoginElements.TXTBOX_PASSWORD_ID);
            return this;
        }

        public ILoginPage SetCompanyAliasTextBox(string companyAlias)
        {
            _webPage.SetText(LocatorType.Id, LoginElements.TXTBOX_COMPANYALIAS_ID);
            return this;
        }

        public ILoginPage SetBadgeNumberTextBox(string badgeNumber)
        {
            _webPage.SetText(LocatorType.Id, LoginElements.TXTBOX_BADGENUMBER_ID);
            return this;            
        } 
       
    }
}

```

🧐 Notice the verbose element names. This is done to make it clear, exactly what the action the element can be accessed.

#### FAQ: 

* **What if an element on a page, requires accessing another element, then access it. can the page object methods have multiple lines?:** 
  * YES, you should be combining them at the page object level, and if the first element to go through to get to the second element is not one you ever need to access alone, you don't need a separate method for it exposed on the interface, could either make it a private method and call it on those methods that need it, if can be used for multiple methods. If not used by any other methods, then just include the code in the same method.
* What if a action I need for a page object, is very specific and not available in the the methods provided in WebPage?

  * Can create a method that returns the web element, then in your test you can use this, and chain from gives access to the selenium commands. 
    * _Might ask why not just return the elements for all of them, and then let the tests decide how they want to use them?_  

      * Can do this, but the ideal for doing them with their actions, is to allow wrapping in the method anything extra that is required to work with the element. Once you have the element method, and tested it out and it works, you can be assured for the most part that element when accessed will always work that way. So if you add some element method, and you figure out in testing, that element needs to have an extra wait in it, or you need to add checks in it, you don't at the page object level for that method, saves others from trying to figure out the type of waits or any extras around element to get it work as expected. They can just used your wrapped element. Figure it out once, and re-use. Granted you can not always think of the ways an element might need to use, but can always add to the page object later, adding those other methods for handling an element as needed. Suggest when creating a page object you only try and create the methods for the basics, or known needs, versus trying to add all when you have more complex systems under test. Recommend, always provide a method that does simply return the element back, to allow consumers the option to deal with an element directly when needed. For example, they don't need the wrapped method \( which has wait until timeouts built in\).

  The idea for building page objects described is to provide the methods for the basic expected operations, buttons would be a click method, set text fields, etc. Then if needed to create a test for that page object that needs different actions  on these elements, these methods are created as they are needed. This reduces the need to create more methods then what are actually used or the need to cover all the various ways to handle an element.



