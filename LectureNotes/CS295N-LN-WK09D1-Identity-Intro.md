**CS295N Web Development 1: ASP.NET**                                                        

<h1>Authorization and Authentication with Identity</h1>

<h2>Contents</h2>

[TOC]

------

## Introduction

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



## Implementing Authentican and Authorization with Identity

### Implementing Authentication

To add Identity to a project see [How to Scaffold Identity](https://lcc-cit.github.io/CS296N-CourseMaterials/LectureNotes/CS296N-LN-WK0XDX-IdentityScaffolding.html).

Once Identity has been added to a project, you will need a way to set up an initial admin user who can log into the site after it is published.



#### Adding Users to Seed Data

When we added Identity to our project, we removed the `DbSet` for our user class from our`DbContext` class. This is because the user table in the database is now managed by Identity. Instead of using the DbContext to do CRUD operations with our AppUser model, we will do all of those operations using the Identity `UserManager` service.

##### Adding a User in Seed Data with the UserManager

As an example of how to use the UserManager service, we will refactor our SeedData to use the UserManager.

1. Modify the code in Program.cs that calls the `SeedData.Seed method` to pass in an instance of `IServiceProvider` which is needed in order to get an instance of `UserManager`

```c#
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider
      .GetRequiredService<ApplicationDbContext>();
    SeedData.Seed(context, scope.ServiceProvider);
}
```

2. In the SeedData.Seed method, add code to get a UserManager object.

   ```c#
   public static void Seed(ApplicationDbContext context, IServiceProvider provider)
   {
      // code omittted 
      var userManager = provider
        .GetRequiredService<UserManager<AppUser>>();
   ```

3. Create users with the UserManager.

   ```c#
    const string SECRET_PASSWORD = "Secret!123";
    AppUser emmaWatson = new AppUser { UserName = "Emma Watson" };
    var result = userManager.CreateAsync(emmaWatson, SECRET_PASSWORD);
   ```

   

#### Updating code that uses `AppUser`

Since we refactored our user domain model, now named `AppUser`, to inherit from `IdentityUser` we need to change the way we use the user model in some of our code.

##### Saving new items in the database

In the instructor's BookReview example app, this is done in the *Post* version of the `Review` method in the `BookReviews` controller:

```c#
[HttpPost]
public IActionResult Review(Review model)
{
    model.ReviewDate = DateTime.Now;
    // Store the model in the database
    if(ModelState.IsValid)
    { 
        repo.AddReview(model);
    }
    return View(model);
}
```

###### Getting a AppUser model from Identity

The `Review` model contains an `AppUser` object named `Reviewer`:
(Validation annotations removed for clarity)

```c#
public class Review
    {
        public int ReviewID { get; set; }
        public Book Book { get; set; }
        public AppUser Reviewer { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
    }
```

The `Reviewer` object is currently being supplied by the Reivew.cshtml view. We need to get it from Identity instead. We'll do this by refactoring the *Post* version of the `Review` method in the `BookReviews` controller:

###### Getting the current user

 To get the current user, simply use the `User` property of the controller to get an object that identifies the current user, then use `GetUserAsync` to get the `AppUser` object:

```c#
  model.Reviewer = userManager.GetUserAsync(User).Result;
```

```c#
[HttpPost]
public IActionResult Review(Review model)
{
    // Get the AppUser object for the current user
    model.Reviewer = userManager.GetUserAsync(User).Result;
    // TODO: modify the register code to get the user's name
    model.Reviewer.Name = model.Reviewer.UserName;  // Temporary hack
    model.ReviewDate = DateTime.Now;
    // Store the model in the database
    repo.AddReview(model);
    return View(model);
}
```



### Implementing Authorization

We will add ths code in order to add authorization to a web app:

- A list of user roles to the AppUser model class
- Optionally:  a UserVM
- Optionally: a UserController

In this section we will not actually restrict any parts of the web site. We'll just set up user roles and role management. We'll add restrictions to parts of our web site based on roles in the next session.

#### Managing Users and Roles

In order to work with roles, we need a way to create roles and assign roles to users. 

**>>> This section needs to be adapted for use with scaffolded Razor Pages <<< **

1. Add `app.UseAuthorization` to Program.cs. This must come <u>after</u> `app.UseAuthentication`!

2. Add a `List` for role names to `AppUser`. This is not needed by Identity. We're just adding it to facilitate our administrative page for managing users and roles.

   ```c#
   [NotMapped]
   public IList<string> RoleNames { get; set; }
   ```

     - The `[NotMapped]` attribute tells Entity Framework that it should not add this property as a field in the AspNetUsers table.
     - `IList<string>`
       - One reason we're using `IList<string>` rather than `List<string>` is because  the `GetRolesAsync` method of `UserManager` returns this type.
       - Another reason is the "best practice" of using the most general type possible for properties. Here we need arbitrary access to the collection so we need `IList`, not `IEnumerable`.[^1]

3. Create the `UserVM` view-model to hold the lists shown below. This will be used by the Index view below.

   ```c#
   public IEnumerable<AppUser> Users { get; set; }
   public IEnumerable<IdentityRole> Roles { get; set; }
   ```

   -  We're using `IEnumerable<AppUser>` here instead of` IList<AppUser>` because we will only be iterating over the collection and don't need arbitrary access to it.[^1]

4. Add the `UserController` that will be used to manage users and roles. 

   Notes:

   - Leave off the *Authorize attribute* for now. It will block us from testing the controller until we have a user in the "Admin" role. We'll add that next time.  
     Also, the attribute is incorrect as shown in the book. The correct attribute is:  
     `[Authorize(Roles = "Admin")] `
   - We are not using *Areas*, so omit the  `[Area("Admin")]` attribute

   This controller implements these action methods:

   - User Management

     - `Index()`Renders the admin page for managing users and roles

       - Note: **If you are using MySQL**, you need to modify the loop header (on line 22) to prevent the MySQL EF provider from throwing an exception, "MySqlConnection already in use". Modify it by adding `ToList()`, like this: 

         ```c#
         foreach (AppUser user in userManager.Users.ToList())
         ```

         This is needed because `userManager.Users` returns an `IQueryable`, which defers execution of database queries until all further processing of the query is completed. The EF provider for MySQL doesn't seem to like this. Adding `ToList()` forces the database query to be completed immediately.

     - `Add()`&mdash;Renders the form for adding users

       - This code isn't shown in the textbook, but it is the same as the corresponding method in the `AccountController`.

     - `Add(RegisterVM)`&mdash;Adds a user

       - This code also isn't shown in the textbook but is the same as in the `AccountController`.

     - `Delete(string)`&mdash;Removes a user

      - Role Management

        - `AddToAdmin(string)`&mdash;Adds a user to the "Admin" role
        - `RemoveFromAdmin(string)`&mdash;Removes a user from the "Admin" role
        - `CreateAdminRole()`&mdash;Creates the "Admin" role
        - `DeleteRole(string)`&mdash;Removes a role

5. Add the `User` / `Index` view

6. Add the `User` / `Add` view


We don't need to add a migration since we have not made any change to our domain model that will affect the database.

#### Restricting Access to Authorized Users 

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

