**CS295N Web Development 1: ASP.NET**                                                        

<h1>Authorization with Identity</h1>

<h2>Contents</h2>

[TOC]

------

## Review

In the field of software security, *authentication* and *authorization* are the two main operations that control who has priveleges to access different parts of a software system.

### Authentication: Proving Who You Are

Authentication is the initial step of verifying a user's identity. It answers the question, "Are you who you say you are?" This is typically handled through credentials such as passwords, biometric scans (like fingerprints or facial recognition), or multi-factor authentication (MFA) with codes sent to a phone or an authentication app. Once the system successfully matches the provided credentials against its records, it establishes a "session" for the user, confirming that they are indeed who they claim to be.

### Authorization: Defining What You Can Do

Once a user is authenticated, authorization determines their level of access. It answers the question, "What are you allowed to do?" Just because you’ve logged into a system doesn't mean you have the right to see everything. For example, in a corporate application, an "Employee" might be authorized to view their own payroll data, while a "Manager" is authorized to view the data for their entire team. Authorization relies on policies, roles, and permissions to ensure users stay within their designated boundaries.

#### The Two Main Parts of Authorization

- Establishing user roles and assigning one or more roles to each user. For example:
  - Guest (could be an unregistered user)
  - Member (any registered user, we'll see later that this is a default role)
  - Administrator (a registered user with maximum privileges)

- Limiting access to certain parts of the web app to users with particular roles. For example:
  - Administrators have no restrictions. They can access all pages including special administrative pages.

  - Members can view all non-administrative pages and make posts.

  - Guests can only view non-administrative pages and they can't make posts.

### ASP.NET Core Identity

It is a class library for:          

- Authentication
- Authorization
- Role management
- User account management

---



## Implementing Authorization

In this section we will not actually restrict any parts of the web site. We'll just set up user roles and role management. We'll add restrictions to parts of our web site based on roles in the next session.

### Managing Users and Roles

In order to work with roles, we need a way to create roles and assign roles to users. 

1. Add `app.UseAuthorization` to Program.cs. This must come <u>after</u> `app.UseAuthentication`!

2. Add user roles in seed data.  
   ```C#
     var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();
   
     // Define roles
     string[] roleNames = { "Admin", "Instructor", "Student" };
   
     // Create roles if they don't exist
     foreach (var roleName in roleNames)
     {
         if (!context.Roles.Any(r => r.Name == roleName))
         {
             roleManager.CreateAsync(new IdentityRole(roleName)).Wait();
         }
     }
   ```

3. Get an `IConfiguration` object which represents your application's configuration settings loaded from all sources (appsettings.json, User Secrets, environment variables, etc.).  Add this code to Program.cs:
   ```c#
   using (var scope = app.Services.CreateScope())
   {
       var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
       // Add this lline:
       var config = scope.ServiceProvider.GetRequiredService<IConfiguration>();
       // Modify this line:
       SeedData.Seed(dbContext, scope.ServiceProvider, config);
   }
   ```

4. Modify the Seed method header to include a parameter for `IConfiguration`  
   ```C#
   public static void Seed(AppDbContext context, IServiceProvider provider, IConfiguration config)
   ```

5. Seed a "real" Admin user  
   This will be a real user as opposed to the fake users that are in the seed data just for testing. The user name and password for this user will be stored in user secrets.  

   ```c#
    var adminPassword = config["SeedData:AdminPassword"];
    var adminUserName = config["SeedData:AdminUserName"];
    if (string.IsNullOrEmpty(adminUserName) || string.IsNullOrEmpty(adminPassword))
        throw new InvalidOperationException("Admin cerdentials not configured in user secrets.");
   ```

6. Add the credentials to user secrets by using the "Manage User Secrets" option on the project menu in the VS Solution Explorer, or using a CLI command like this:  
   `dotnet user-secrets set "SeedData:adminPassword" "YourSecurePassword"`

7. Create the default admin user  
   ```C#
   var adminUser = new AppUser {Name = adminUserName, UserName = adminUserName, Email = "admin@example.com"}
   var result = userManager.CreateAsync(adminUser, adminPassword).Result;
   if (!result.Succeeded)
   {
       throw new InvalidOperationException(
           $"Failed to create user {adminUser.UserName}: " +
           string.Join(", ", result.Errors.Select(e => e.Description)));
   }
   
   // Assign role
   var roleResult = userManager.AddToRoleAsync(adminUser, "Admin").Result;
   if (!roleResult.Succeeded)
   {
       throw new InvalidOperationException(
           $"Failed to add role '{role}' to {adminUser.UserName}: " +
           string.Join(", ", roleResult.Errors.Select(e => e.Description)));
   }
   ```



## Restricting Access to Authorized Users 

We will use the following C# attributes to restrict access classes or methods:

- `[Authorize]`
  - Limits access to logged in users.
  - If a user tries to access a method that requires authorization, they will automatically be redirected to Account/Login[^1]. 

- `[Authorize(Roles = "Admin")]`
  - Limits access to users in the Admin role.
  - If a user not in this role tries to access a method with this restriction, they will be automatically redirected to Account/AccessDenied[^2].





## Footnotes

*CreateScope* is a method that creates a new scope for the specified service provider. It is used to create a new scope for resolving dependencies. The IServiceScope instance returned by CreateScope is used to resolve dependencies within the scope of the created scope. The IServiceScope instance is also used to dispose of the scope and any resources that were created within it when it is no longer needed. 

*Scoped services* are registered using the AddScoped method of the IServiceCollection interface. When a scoped service is requested, a new instance of the service is created within the scope of the current request. The same instance is then used for all subsequent requests within that same scope. [Microsoft Learn, Scoped Services](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#scoped)

------

​          

------

[ ![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) [ASP.NET Core MVC Course Materials](http://lcc-cit.github.io/CS296N-CourseMaterials/) by [ Brian Bird](https://profbird.dev), with assistance from Gemini 3.0, written winter <time>2026</time> are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 
    

------

