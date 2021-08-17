---
description: 'Still curious about DI containers, and want more details, here ya go.'
---

# DI Container - Big Explanation

OOP languages, create objects, and pass them around where they are needed. One of the challenges of doing this, objects have to be instantiated \( using the new keyword \) , if they are not you'll get the dreaded " objects is null, or object has not been instantiated" error message. In an inheritance system you return object, so the class inheriting it can use it. Inheritance poses a number of challenges , by the nature of how it works. Such as: 

* Needing to anticipate more how other classes will use it, because the inheritance couples the code so closely. There are ways of handling it, such as changing accessibility of your object is one way. However, in the end, we never know how any code consuming class will need to use it \( since the code is not built yet\) so adding safe guards usually makes it more difficult to change if some new code comes along that should be allowed to get around these safe guards and ends up with code getting more and more complex as it grows.
* In inheritance, when something is inherited, you get instance access to all the methods as they all get loaded when the class is instantiated. Sounds good, except we have no idea what is actually available with that inheritance without looking at the code being inherited, and if that happens to inherit something, it can get even uglier. So in a nutshell, you'll have to understand every aspect of the codebase in this system, and depending on how large of a codebase, this may not even be possible. If you don't, you'll suffer the consequences later, when someone unknowingly changes something that breaks everything else, and you are stuck going through everything to figure out how to properly fix it. 

The ideal of containers handle this, because they take that responsibility of instantiating objects away from the object and instead the containers do it, hence the name of inversion of control, ioc Containers. Allowing the developer to no longer worry about that when they access an object, or create one. 

Now that we know what a container is and what it does, we can understand that we have only one container that does this in our project \( can have more for more complex solutions, but we do not\). This container has code in that tells it what kind of objects to manage and where to find them, and how they are named, so it can do its job. They are designed to allow rules to be set, so they can automatically handle objects that fit some criteria, so that you as the developer does not have to add an entry in the container every time you create a new object. 

