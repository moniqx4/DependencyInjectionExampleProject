---
description: Breaking down the layers and the purpose of each
---

# Framework Architecture

The architecture for this Automation Framework is based on Layers. Each Layer has its own purpose. Understanding these layers will help to understand the WHY for the layers of abstractions and how to work with the various layers.

## Tests/Workflow - Top Layer

This layer is the highest component of framework. Here is where your tests and workflows are created. These tests/workflows are the "Directors" of how tests runs. The Directors plan and provide the requirements for the rest of the layers, to fulfill their requirements for getting their tests functional.

Directors can write plans \(tests\) all day, and we need those to understand what we need to work on for them. Directors can be anyone really. They don’t have to know anything about the inner working of our architecture. Ideally, it would be preferred to write the tests first, so we have an idea of what is needed to work for the tests.

## Services - Mid Tier Layer, Main 

The main layer that are the “WorkTeams” for the directors. The workteam gets their requirements from the directors, and its their job to get the stuff they need together to present to the directors. The directors have no knowledge of the details, they just want the work done.

Once we have some plans\(tests\), we can decide what kind of services are needed. This should be thought out at a high level, and then mocked out. Do this planning does require us to know how our DOMAIN works, to provide a structure of available services that is intuitive and efficient. Keep the redundancy down and figure out the best level of access to provide the directors, so they build their tests as they spec’ed out.

This layer is the one that depending on size of project, can be _optional_. However, this layer provides one very important feature, which is **Re-Usability** for our code. When you have a larger project, with more than 1 or two people writing tests, this layer allows creating chunks of re-usable code in the form of Services. These services need to be properly planned out to provide not only re-usable code, but in manner that is intuitive and makes this code discoverable by the consumers.

Keep in mind, for a smaller project you can omit this layer, and it does add an extra layer of abstraction. Instead,  you could use Page Objects in your workflow, but because workflows are personal to the test they are being written for, you'll lose re-usability, between workflows. Copying and pasting any code you repeat between workflows. 

As services can be challenging to build, and if you have a team that is fairly new to the codebase, one approach is start with using Page Objects with your workflows, and as tests are being developed the minute you have a chunk of code that is being repeated you create a Service for it and then it can be shared between the workflows. This allows your test writing to dictate what Services are needed.

## Page Objects Layer - Lower level Component

The materials or  what the workteams use to build their services. The workteams don’t know how to build these materials, and don’t care how they are built. They just want to get the materials they need.

Now at the same thing they are figuring out the best structure on the services layer, they have already provided the list of materials they need, aka pageobjects. These are being assembled and ready for the Services layer to consume whenever they are ready. Or in the case of a smaller project they may be feeding the Workflows directly. 

## Driver Layer - Lowest level Component

Tools came before anything else, so they are already available for the PageObjects layer to use. They may make a special request, or need some tool we haven’t provided yet, no problem we add it as needed. This layer ONLY available to the Page Objects layer, and the access is limited to two interfaces, IWebPage for element interaction and IBrowser for Browser interaction, controls for handling the browser window, for example, loading pages, refresh browser page, etc.

## Other vertical layers \( cross between all the layers\):

Utils – specialized tools to help any layer do their work 

DataModelLibrary , Configuration– miscellaneous information needed by all





