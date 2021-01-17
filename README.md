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