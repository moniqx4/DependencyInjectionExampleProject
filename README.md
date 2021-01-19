# DependencyInjectionExampleProject
 
An example of demonstrating how Dependency Inject is setup and works. It has an example with
a basic Home Grown container, then one with Autofac.

It also shows what is required to do the same thing without Dependency Injection.



Files:
*PageProvider*
The main entry point as a console program, comment out the setups where noted then run program.
 
*DIContainer*  
Basic no frills Container , the container is a one time thing, create it once
and should not need to touch it again. This is what normally packages like Autofac would create for
you with alot more features and capabilities.

*AutofacExample* - 
This is where you would register your types for your container to handle. Generally these 
would be Interfaces.  Autofac has many options to how this is done. In here are just a few, one in which
a version is specified and another that is based on scanning and registering all that start with I. Nice
if you don't want to have to worry about adding a new entry each time a new Interface is added.

*HomeGrownDIExample* -
This is the container setup for the Home Grown version. Very basic no frils, 
setup for registering interfaces with their concrete classes, and building the container, thats it.

The other files are basically test files to demonstrate different scenarios.

*NuniTestProject* -
This project is an example of setting up an autofac container with a TestRunner. The TestRunner is setup
To get the actual test code from a workflow, by the workflow's name. 

*PageObjectProvider*  -
The PageObjectProvider is the container build in this project, and it is setup to register all the
Interfaces in the assemply, so not required to enter them when a new interface is added. 

The TestRunner uses a TestContext, if wanted to add more setting then the name of the test, would add
it to the the TestContext. The TextContentBuilder, builds that Context so the TestRunner knows how to work
with your test, what settings it requires to be set etc.

A WebsiteContext could be added as well, for setting a configuration, like the browsertype to use to run
test, etc. Setup the same way as the Test Context. For this example kept it simple with just the Test Context
being defined with only the name.