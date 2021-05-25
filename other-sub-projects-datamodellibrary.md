---
description: >-
  Data Models are simple structures that allow passing of data object that
  contain related data elements.
---

# Other Sub-Projects: DataModelLibrary

The Data Model Library was created to allow shared access to all levels of the project for the various data models needed for completing tests.

Each Team has their own folder, that contains data models specific to their domain area. Data Models in the root are meant for those that are common across teams, such as LoginCreds as one example.

The data models in the root are also grouped by type, for example Configuration directory has Data Models related to Test configuration. 

If the Data Model you need is not one shared, or maybe only specific to one item, it does not need to be in this library. 

**Other Shared items stored here are the following:**

* Enums
* Constants

**Some Best Practices when it comes to Data Models:**

* Data Objects \( models\), should not be partially initialized
  * This forces data objects being passed to have all the required data and thus avoiding instantiating errors and better encapsulation, Example: 

```text
 public class BaseLocatorModel
    {
        public BaseLocatorModel(LocatorType locatorType, string locator)
        {
            LocatorType = locatorType;
            Locator = locator;
        }

        public LocatorType LocatorType { get; }
        public string Locator { get; }

    }
```

* If the Data Object is one expected to have its information written out to a log, add the override string to it. Example: 

```text

```

* Leveraging Data Object Models can be very useful and make it much easier to pass data around. If a method has more then 3 parameters being passed to it, consider using a Data Object Model instead.



