**CS296N Web Development 2: ASP.NET**                                                        

<h1>Intro to User Management with Identity</h1>

<h2>Contents</h2>

[TOC]

------

## Introduction

### What is ASP.NET Core Identity?

It is a class library for:          

- Authentication
- Authorization
- Role management
- User account management



## Adding Identity to a web app

### Adding the infrastructure

1. Use the NuGet package manager to add the following package to your project:

   - Microsoft.AspNetCore.Identity.EntityFrameworkCore
                 

3. Modify your application's DbContext class to inherit from `IdentityDbContext`.            

   - This provides a way for Identity to add tables for storing user information to your database. All you need to do is change the inheritance.
   - Don't add a new `DbSet` for Identity, that will be done by the parent class.
   - Remove the DbSet for your User model, that is also managed in the parent class, `IdentityDbContext`.
   
4. Modify your *User* model so that the class inherits from `IdentityUser`. 

   - If your current user model class is named `User`, you should change it to something else, like `AppUser` so that you don't have a conflict with an Identity class named `User`.
   - If your user class has user name or email properties, you should remove them since they are in the new base class (see below).
   - Remove the ID property from your user class. The ID is in the base class.
   - The `IdentityUser` class has these properties:            
     - Id - This property contains the unique ID for the user. 
     - UserName - This property returns the user’s username.              
     - Claims - This property returns the collection of claims for the user.
     - Email - This property contains the user’s e-mail address. 
     - Logins - This property returns a collection of logins for the user, which can be used for third-party authentication.
     - PasswordHash - This property returns a hashed form of the user password.
     - Roles - This property returns the collection of roles that the user belongs to.
     - PhoneNumber - This property returns the user’s phone number. 
     - SecurityStamp - This property returns a value that is changed when the user identity is altered, such as by a password change. 
                              

4. In Program.cs, add:
   
   ```C#
   builder.Services.AddIdentity<AppUser, IdentityRole>()
       .AddEntityFrameworkStores<AppDbContext>()
       .AddDefaultTokenProviders();
   ```
   
   The `AddIdentity` method has generic type specifiers for the user class and the built-in `IdentityRole` class for user roles.            
   
   - The `AddEntityFrameworkStores` method specifies that Identity should use Entity Framework Core to store and retrieve its data, using the application's database context class. 
   - The `AddDefaultTokenProviders` method uses the default configuration to support operations that require a token, such as changing a password.
                   
   
6. In Program.cs add:
  
    `app.UseAuthentication();`
    
    This should go <u>after</u> `app.UseAuthorization();`  
    
6. If you have overridden `OnModelCreating` in your database context class, then add a call to the base class method. This is because the base class method creates the Identity tables.    
  
    
  
7. 
   Add a migration for the new user model and update the database using these commands:
   
   | CLI Commands                                                 | Package Console Commands                        |
   | ------------------------------------------------------------ | ----------------------------------------------- |
   | `dotnet ef migrations add Identity`<br />`dotnet ef database update` | `add-migration Identity`<br />`update-database` |
   
   After adding Identity to your project, Inspect the database using SQL Server Object Explorer and note the new tables added by Identity. The tables listed below should have been created.
   

- AspNetRoleClaims

- AspNetRoles

- AspNetUserClaims

- AspNetUserLogins

- AspNetUserRoles

- AspNetUsers&mdash;this is your user table, it contains the fields you added in your own user class.

- AspNetUserTokens

- Using Identity in administrative pages



## References

### Basic

- *Murach’s ASP.NET Core MVC*, Mary Delamater and Joel Murach, 2022
  - Ch. 16, "How to Authenticate and Authorize Users"
- *Pro ASP.NET Core 2*, Adam Freeman, 2017            
- Ch. 28 – Getting Started with Identity
  
  - Ch. 12, pg. 321–330, SportsStore: Securing the Administration Features
- [Introduction to Identity in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/?view=aspnetcore-3.1)

### Advanced

-  [ HTTP Authentication Mechanisms](https://code-maze.com/http-series-part-4/)
-  [Exploring the  ASP.NET Core Identity Password Hasher](https://andrewlock.net/exploring-the-asp-net-core-identity-passwordhasher/)
-  [Download SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) Use SSMS (free) to troubleshoot database problems.

------

## Example Code on GitHub

- Instructor's Demo Web App using ASP.NET 6.0: [BookReviews&mdash;Identity branch](https://github.com/LCC-CIT/CS296N-Example-BookReviews-DotNet6/tree/02-Identity)



## Next Class

- We will add pages that use Identity for registration and login (authentication)
- We will restrict different parts of the web app based on user role (authorization)
            

------

[ ![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) [ASP.NET Core MVC Course Materials](http://lcc-cit.github.io/CS296N-CourseMaterials/) by [ Brian Bird](https://profbird.dev), written winter 2017, revised winter 2024 are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 
    

------

