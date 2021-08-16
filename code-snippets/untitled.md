---
description: >-
  This codebase is C#, and helps working with C# is understanding what a design
  pattern and how and when to use them. This describes those patterns that most
  helpful to test automation code.
---

# Design Patterns

## Dependency Injection Design Pattern

What is Dependency Injection? 

This codebase is utilizing the Dependency Injection design pattern for a big portion of overall design methodology. The idea is to keep the code loosely coupled and make the code modular. However, you can write automation code that does not use this pattern perfectly fine. All the examples you will see on the web for test automation will generally NOT be using this design pattern. It is design choice for this codebase, so its important you understand the basics of how it works.

You might ask, if no one else is using for test automation, why make it a design choice for this project? This pattern in my opinion should be used and should be shown in examples. However, it is considered a more complex pattern when it comes to setting up your codebase to be able to utilize this pattern. It requires understanding the concepts of containers, what they do, and how they need to be configured. Containers are those sort of things once you get it setup, you should never have to touch it again, unless you decide to make major changes to your underlying code, or add new sub projects and need to include those as well to be managed by your containers. DI as I will refer to it, provides some unique advantages and can make things easier for those writing code in your codebase, without needing to know anything about DI, except the basics, how to inject a dependency and how to structure code. Examples of why it works well with test automation code: 

* It promotes a standard code structure. Using a template style as we do for each type of major code structure used in automation such as a Test, Workflow, or Page Object is structured the same and have been provided as example templates that users simply copy and change the names and build within to quickly get started.
* If you want developers to assist in developing automation code, DI is defacto for most codebases because of the loosely coupled code, and modularity it provides. Your developers will be happy to see a code style they are use to and makes it more easier for them to work with something they are familiar with. 
* The ideal of modularity, really helps with writing re-usable code in smaller pieces, making readability much easier and code easier to digest. You'll appreciate it more when you have to take ownership of code you didn't write.
* Since everything is written to contracts \(interfaces\), versus to concrete classes, it allows the ability to work on bigger pieces and not upset any code will working on it, and simply switching the contract to inherit your new class while testing it out, is a major big deal. Knowing if you want to add a feature, or change the version of say the web driver to see how well it works with your codebase before full implementation is super important and gives you code extensibility

