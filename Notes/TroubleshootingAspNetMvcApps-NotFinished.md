<h1>Troubleshooting MVC Web Apps</h1>

<h2>Table of Contents</h2>

[TOC]

## HTTP Error 500.30 - ASP.NET Core app failed to start

This error can occur when running locally on your development machine or when running in a Web App (App Service) on Azure.

- Common solutions to this issue:

  - The app failed to start

  - The app started but then stopped

  - The app started but threw an exception during startup


- Troubleshooting steps:

  - Check the system event log for error messages

  - Enable logging the application process' stdout messages

  - Attach a debugger to the application process and inspect




## Reference

[Troubleshoot ASP.NET Core on Azure App Service and IIS](https://learn.microsoft.com/en-us/aspnet/core/test/troubleshoot-azure-iis?view=aspnetcore-6.0)

[Logging in .NET Core and ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-6.0)