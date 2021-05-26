---
description: >-
  This information, relates to how the Selenium Web Driver is used, and
  implemented in this solution.
---

# Advanced Topics: Selenium Web Driver

The Selenium sub-project in this solution is quite a bit different then the rest of the UIAutomation. It only has a few Interfaces exposed, and here DI is lightly use. The reason its not utilizing Dependency Injection is because the Selenium Web Driver needs to be setup as a Static class, and static classes can not be instantiated.

