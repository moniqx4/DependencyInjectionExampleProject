---
description: Working with web page elements.
---

# IWebPage/WebPage

## IWebPage/WebPage

All page objects will have this interface injected. This provides all the functionality for interacting with elements, clicking, setting text, etc. Pretty straight forward, you'll find all the interactions available with intellisense. 

How is that different then just using the driver directly, why the interface?  The methods for these interactions are wrapped, making them easier to use, you simply pass in the LocatorType and the locator, and your done. The wrapping builds in the waiting UNTIL an element is visible, before trying to work with it. They are all set with a default period of waiting, but allow it to be override, and specify at the single element level. It also has built in checks for element being nullable. Instead of blowing up, it will just stop test right there, if at any time its passed an element that does not exist.

With that said, there are instances where an element may not be found, but you don't want to end test, what can you do ? There is exposed a class called ILocatorBuilder. This is the main class used by the wrapped methods for WebPage that does the wait until, and then builds the locator based on the LocatorType. It is where the custom locators are created as well. It have a method that can be used called DoesElementExist and it returns a bool. This can be used, to check an element exists, and not kill your test. Note there are other options available besides this one to do something similar thing, but this one saves you a line or two of code, depending on what your needs are. Normally, the LocatorBuilder is not used directly, except for special situations. However, should be aware of it and know how and when to use it. Being a core piece as part of the WebDriver, not something that should be modified without being aware of what it affects.

