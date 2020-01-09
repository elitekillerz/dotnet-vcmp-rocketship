# Startup class

### Abstract

The startup class is a class in the user code which is responsible for bootstrapping the script.

---

### Marking a class as the startup class

A startup class is a class which has the attribute `EliteKillerz.DotnetVcmp.Rocketship.Lifecycle.StartupClassAttribute`. Exactly one class must have this attribute; violating this will result in an exception at startup:

- `EliteKillerz.DotnetVcmp.Rocketship.Lifecycle.StartupClassNotFoundException` in the case of no startup class being found; or,

- `EliteKillerz.DotnetVcmp.Rocketship.Lifecycle.AmbiguousStartupClassException` in the case of more than one startup class being found.

### Requirements for a startup class

A startup class must:

- implement `EliteKillerz.DotnetVcmp.Rocketship.Lifecycle.IStartup`; and,

- have a public constructor that requires no arguments.

Violating these rules will lead to the following exceptions respectively:

- `EliteKillerz.DotnetVcmp.Rocketship.Lifecycle.StartupClassUnderivedException`

- `EliteKillerz.DotnetVcmp.Rocketship.Lifecycle.StartupClassUninstantiableException`

### Configuring services for dependency injection

> This is very similar to configuring services in an ASP.NET Core application.

The service configuration method in this class is called very early on in order to register available services that can then be consumed by the rest of the application and the framework. This method is named `ConfigureServices`, whose signature can be found in`EliteKillerz.DotnetVcmp.RocketShip.Lifecycle.IStartup.ConfigureServices`:

```csharp
public void ConfigureServices(
    Microsoft.Extensions.DependencyInjection.IServiceCollection services
)
```

For information on how to use the service collection, refer to [Microsoft's documentation on their dependency injection solution](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1).

---

## Implementation details

> **Warning**
> 
> Your code should not rely on these implementation details. They are here in order to help build the framework as well as to serve as a reference to potential contributors to the framework. They are subject to potential change at any time, and code using them is prone to failure and lack of forward compatability.

#### General

The startup class is located by iterating through all assemblies and their types. This is done using a LINQ query. The query is then converted to a list so that its length can be checked and an appropriate exception thrown in case the length is not equal to one. The startup class is then instantiated and the `ConfigureServices` method is called using reflection. This is done before the bootstrap function (bootstrapped from the runtime client) synchronously returns.
