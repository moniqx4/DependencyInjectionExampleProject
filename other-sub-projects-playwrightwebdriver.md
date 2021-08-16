# Other Sub-Projects: PlayWrightWebDriver

The Playwright subproject, is a self contained project and entirely different way of writing tests and uses its own driver for handling the browser. The reason its not in its own project, was part of the idea of this solution being a toolbox with different tools for testing. This toolbox being a CSharp \(C\#\) toolbox only has sub projects utilizing the C\# language. 

What kind of tool is Playwright for automation ? It supports asynchronous testing, which means you can do things like intercept API calls and manipulate them to test APIs, or leverage in your testcase. Selenium does not offer this capability as it is not asynchronous. Basically, if you are familiar with how Cypress works, then its along those general lines for an automation tool. 

Playwright is a free open source tool \(library to be more accurate\) developed by Microsoft. It is a fork of the Google tool Puppeteer that has been enhanced to handle more things then what puppeteer currently does. The developers that developed Puppeteer were hired by Microsoft and continued their work, but now on Playwright instead. So as it appears fairly new, its actually not that new under the covers. If you look at the code and how it works, you'll find the same syntax as Puppeteer to the level where you can leverage Puppeteer code, examples, add-ons in Playwright as right.  

Because of Playwrights support of C\#, it made a nice addition as a sub project to this solution to allow STEs and developers whom are C\# developers to be able to take advantages of these type of automation tools in the same solution of the UIAutomation solution and still work with C\#, and avoid the pitfalls of context switching. 

Its been setup to use NUnit as its Testrunner, and some testcases will leverage some of the shared data models, and page elements that are defined in their own files. It is not setup with the Container for injection. However, this could be changed, if the usage of this sub project becomes bigger than its current setup. Later, will be creating some basic usage, best practices type documentation based on how the team is leveraging it. In the meantime, feel free to ask questions if interested and view the working tests currently in project for examples on how to get started.

For complete documentation and details: [https://playwright.dev/](https://playwright.dev/)





