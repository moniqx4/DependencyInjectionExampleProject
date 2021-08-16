---
description: Most commonly asked questions.
---

# F.A.Q

## What is this Container business, and will I need to do something with it when writing tests?

OOP languages, create objects, and pass them around where they are needed. One of the challenges of doing this, objects have to be instantiated \( using the new keyword \) , if they are not you'll get the dreaded " objects is null, or object has not been instantiated" error message. In an inheritance system you return object, so the class inheriting it can use it. However, this poses other challenges , like if your class changes it, and you may not want to be returned to any external objects/classes. To handle this scenario requires safe guards in place, and anticipation of how other objects/classes work with it, etc. It also makes it more work for the end user of the object because if they need access to it, and say its been set to internal for some reason and you come along with a valid reason to need this object you would have to change the original object's accessibility, which can be problematic for other code that is using this object. Sometimes you can do this, and compile and everything works fine for you, but now a bug has been introduced for other objects that can only be seen at runtime. This also means more testing on your part as the consumer of this object you have changed, to be sure you haven't broken anything else. All very time consuming and painful to work with as your codebase gets bigger and this is just one example of the issues you may run into when working in this manner. 

The ideal of containers handle this, because they take that responsibility of instantiating objects away from the object and instead the containers do it, hence the name of inversion of control, ioc Containers. Allowing the developer to no longer worry about that when they access an object, or create one. 

Now that we know what a container is and what it does, we can understand that we have only one container that does this in our project \( can have more for more complex solutions, but we do not\). This container has code in that tells it what kind of objects to manage and where to find them, and how they are named, so it can do its job. They are designed to allow rules to be set, so they can automatically handle objects that fit some criteria, so that you as the developer does not have to add an entry in the container every time you create a new object. 

So the answer to this question, is NO you do not need to do anything with the container as long as you create objects that follow the rules that it is looking for. In our case, using interfaces and having the interface start with the capital letter "I" in front of it, and its concrete class using the same name, minus the I, is the only rule we have setup. That information is all the container looks for to know it needs to manage the object. Containers are typically a create once, set your rules and leave alone to do its job, unless you have a good reason for changing the rules its using to manage objects. As this strategy is something you would come up with at the beginning of a project and then code your project based on the strategy your team agreed upon. The only time you will hear from your container, in terms of code errors, is when you fail to properly follow the rules it has for managing your code objects, like creating a interface, and not having a concrete class behind it, or using the new keyword, in an object that is being managed by the container, or not creating a interface for a concrete class, and then trying to inject it as the ability to do injection does require the object be managed by an IoC container.



## Have you had a chance to answer the previous question?

Yes, after a few months we finally found the answer. Sadly, Mike is on vacations right now so I'm afraid we are not able to provide the answer at this point.



