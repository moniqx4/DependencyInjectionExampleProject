Automation Services

A Service is basically grouped web element actions to perform a complete action.

For example: Adding a Punch is a complete action, but to do that, you have to access various web
elements to make that happen.

The Automation services will utilize the Page Objects project to interact with the elements on webpage.

All Automation Services will use Interfaces and any test using a Service will only do so via
via their interface.

Why, not just combine this with Page Objects? More flexibility, easier to manage and when building
out page objects, can just focus on doing that, and not the various actions. An extra level of abstraction
that will make it more extendible, easier to manage, and build out services as we go as well.

Rules: 
- All Service methods are void, they don't return values. Sounds restrictive, but you'll understand later
- Services are not chained, yet the methods that make up these methods within a service, may be
- Using DI, so these services will be injected as Test Needs them.
- Services can call multiple page objects with a single method to complete their actions 
- A service provide complete actions so, they are expected to contain methods that are higher order utizing lower level actions.
- Tests only call Services to accomplish the steps to their testcases