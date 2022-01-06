# net-generic-host-boilerplate
This is a .NET 6 boilerplate for generic host console apps. 

If you're like me and frequently in need of creating long running .NET 6 console apps, then you can use this. It's especially good if your structure and implementation grows over time. 

It covers the basic necessities of a generic host console app:
- Logging, via `Microsoft.Extensions.Logging`. You can plug your own if you want.
- Dependency injection.
- Async/await processing inside the `BackgroundService` instance.
- Configuration, through environment vars and/or `appsettings.json`.

## Installation

Nothing fancy, just run:
```
git clone git@github.com:marceln/net-generic-host-boilerplate.git
```

Then you can change the solution and project names.

## Running

You can run this from Visual Studio 2022 or through the .NET CLI but don't forget first to set your `DOTNET_ENVIRONMENT` environment variable. 

In Visual Studio 2022: 
- Project properties -> Debug -> Open debug launch profiles UI
- Edit launchSettings.json:
```
{
  "profiles": {
    "GenericHostBoilerplate.App": {
      "commandName": "Project",
      "environmentVariables": {
        "DOTNET_ENVIRONMENT": "Development"
      }
    }
  }
}
```

The latter also works for Visual Studio Code. 

## Implementation

The boilerplate provides a `BackgroundService` implementation as well as an `ExampleService` so it can demonstrate dependency injection. In the `BackgroundHostedService` class you can also see how you can use some other framework-provided services, like `IConfiguration`, `ILogger<>`, `IHostApplicationLifetime` and `IHostEnvironment`.

Have fun with it!