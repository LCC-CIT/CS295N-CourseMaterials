---
title: User Secrets in VS 2026
description: How to manage user secrets in VS 2026, in particular how to store the user name and password for a connection string in user secrets so they don't get committed to source control.
keywords: User Secrets, User name, password, appsettings.json, connection string, EF, SQL Server, DB, MySQL
material: Lecture Notes
generator: Typora
author: Brian Bird
---

**CS295N Web Development 1: ASP.NET**

<h1>Managing <i>User Secrets</i> in Visual Studio</h1>

<h2>Contents</h2>

[TOC]

## Keep Secrets Out of *appsettings.json*

Storing sensitive information—like database usernames and passwords or other credentials directly in `appsettings.json` is risky and can easily lead to accidental leaks, especially when using Git or shared computers (in a lab or classroom).
 ASP.NET Core provides a built‑in, secure, development‑only feature called ***User Secrets*** that solves this problem elegantly.

This tutorial, based on Visual Studio 2026, walks you through configuring User Secrets to keep credentials out of your connection string while still allowing your application to build a complete connection string at runtime.

------

### Why Use User Secrets?

The Visual Studio User Secrets feature is ideal for storing secrets (credentials) during local development because:

- They store sensitive values **outside** your project folder.
- They are **never committed** to Git.
- They are **per‑user** and **per‑project**.
- ASP.NET Core loads them **automatically during Development**.
- They work perfectly on Windows 11 classroom PCs without admin rights.

For production, you would use other strategies, such as *environment variables* or *Azure Key Vault*.

## How to Use VS User Secrets

------

### 1. Initialize User Secrets

In Visual Studio, right‑click your project → **Manage User Secrets**

This automatically adds a `UserSecretsId` to your `.csproj`:

```xml
<PropertyGroup>
  <UserSecretsId>your-guid-here</UserSecretsId>
</PropertyGroup>
```

#### CLI alternative

```bash
dotnet user-secrets init
```

Either method creates a unique secret store for this project.

------

### 2. Keep Only Non‑Sensitive Parts in appsettings.json

Instead of storing the full connection string, store only the safe parts:

```json
{
  "ConnectionStrings": {
    "MySqlBase": "Server=localhost;Database=SchoolDb;"
  }
}
```

No username.
 No password.
 Nothing sensitive.

This keeps your repository clean and portable.

------

### 3. Store Sensitive Values in User Secrets

Use the .NET CLI to add your credentials:

```bash
dotnet user-secrets set "DbUser" "root"
dotnet user-secrets set "DbPassword" "SuperSecret123"
```

You can verify what’s stored:

```bash
dotnet user-secrets list
```

These values are written to:

```
%APPDATA%\Microsoft\UserSecrets\<UserSecretsId>\secrets.json
```

A typical path looks like:

```
C:\Users\<YourUserName>\AppData\Roaming\Microsoft\UserSecrets\<UserSecretsId>\secrets.json
```

------

## 4. Combine the Values at Runtime in Program.cs

ASP.NET Core automatically loads User Secrets into the configuration system when the environment is **Development**.

You can build the final connection string like this:

```csharp
var builder = WebApplication.CreateBuilder(args);

var baseConn = builder.Configuration.GetConnectionString("MySqlBase");
var user = builder.Configuration["DbUser"];
var password = builder.Configuration["DbPassword"];

var finalConn = $"{baseConn}User={user};Password={password};";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        finalConn,
        ServerVersion.AutoDetect(finalConn)
    ));
```

This approach:

- Keeps secrets out of source control
- Lets each student set their own credentials
- Works identically across all classroom PCs
- Matches modern ASP.NET Core configuration patterns

------

## 4. Viewing or Editing Secrets

You can open the secrets file directly:

```bash
dotnet user-secrets edit
```

This opens the JSON file in your default editor.

------

## Summary

Using User Secrets allows you to:

- Keep `appsettings.json` clean and safe.
- Avoid leaking credentials into a Git repository.
- Let each developer maintain their own secure configuration.
- Build connection strings dynamically at runtime.

This is the  development‑time approach recommended by Microsoft for .NET projects.



## Examples

[Code Reviews Example, Lab 5&mdash;Database branch](https://github.com/ProfBird/BrianBird_CS295N_Labs_W26/tree/Lab5)



## References

- [Safe storage of app secrets in development](https://learn.microsoft.com/aspnet/core/security/app-secrets)
- [Microsoft Docs — *Configuration in ASP.NET Core*](https://learn.microsoft.com/aspnet/core/fundamentals/configuration)
- [Connection strings in ASP.NET Core](https://learn.microsoft.com/aspnet/core/fundamentals/configuration/options)
- 


------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) These ASP.NET Core MVC Lecture Notes, drafted using MS Copilot with GPT 5.1 and revised by [Brian Bird](https://profbird.dev) in <time>2026</time>,  are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

---

