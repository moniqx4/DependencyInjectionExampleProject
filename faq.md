---
description: Most Frequently Asked Questions
---

# FAQ

## Why can't I combine group methods in my page objects?

This is one of those things where just because you can do something, doesn't mean you should. In this framework, designed for bigger projects it has been noted that when page objects contain "business logic" they become difficult to use in a consistent manner as the project grows and end up containing "one" off code for specific usages. Of course, this can be avoided if we have strict rules and we are sure it gets monitored with every checkin. Since we want to avoid that extra overhead, because history tells us that it easily gets away from us, then you have a problem and it starts to infect the entire project, we keep it simple, by implementing an easy to remember rule, to not allow logic in page objects. Instead, keep our logic in Services if its re-usable code and if not, keep the logic in the workflows for our tests.

But doesn't that just move the problem from the page objects to Services and Workflows? No, Services and Workflows are further from the core, so they are easier to remove or change at this level and won't effect as many tests if anything MUST be modified or removed there. At the page object level, changes can be more 



## Have you had a chance to answer the previous question?

Yes, after a few months we finally found the answer. Sadly, Mike is on vacations right now so I'm afraid we are not able to provide the answer at this point.



