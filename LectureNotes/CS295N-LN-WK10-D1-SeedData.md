**CS295N Web Development 1: ASP.NET** 

<h1>Seed Data</h1>



 **Contents**

[TOC]

## Introduction

Seed data is data that is automatically added to your database when the application is started. There are two main purposes for seed data:

- Development testing.
- Data that is needed in production. For example, data that will populate pre-defined select lists.

## Seeding Your Database

One way to seed your database is to write a class with a static method that will add entities to the database. The method to seed the database will be called from *Program.cs*. I put mine in a static class named *SeedData*, but it's not a special name (not part of a convention).

### Seed Data class and method

````c#
public class SeedData
{
   public static void Seed(AppDbContext context)
   {
      if (!context.Reviews.Any())  // this is to prevent adding duplicate data
      {
        	// Create User objects
        	User reviewer1 = new User { Name = "Emma Watson" };
        	User reviewer2 = new User { Name = "Brian Bird" };
        	// Queue up user objects to be saved to the DB
          context.Users.Add(reviewer1);  
        	context.Users.Add(reviewer2);
        	context.SaveChanges();  // Saving adds UserId to User objects
        
          Review review = new Review
          {
              BookTitle = "Prince of Foxes",
              AuthorName = "Samuel Shellabarger",
              ReviewText = "Great book, a must read!",
              Reviewer = reviewer1,
              ReviewDate = DateTime.Parse("11/1/2020")
          };
          context.Reviews.Add(review);  // queues up a review to be added to the DB

          review = new Review
          {
              BookTitle = "Virgil Wander",
              AuthorName = "Lief Enger",
              ReviewText = "Wonderful book, written by a distant cousin of mine.",
              Reviewer = reviewer2,
              ReviewDate = DateTime.Parse("11/30/2020")
          };
          context.Reviews.Add(review);  

          context.SaveChanges(); // stores all the reviews in the DB
       }
    }
  }
}
````

### Call the Seed method from Program.cs

- Add code at the end of the file, just before `app.Run();`

- Get an instance of your class that is derived from `DbContext`  
  ```c#
  // Get a DbContext object -- we will refactor this
  var scope = app.Services.CreateScope())
  var context = scope.ServiceProvider
                     .GetRequiredService<AppDbContext>();
  ```

- Call the Seed method and pass it your DbContext object  
  ```c#
  SeedData.Seed(context);
  ```

- Refactor this to use a  [`using` statement](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/using) (this is not the same as the using statement for namespaces).
  ```c#
  using (var scope = app.Services.CreateScope())
  {
      var dbContext = scope.ServiceProvider
                           .GetRequiredService<AppDbContext>();
      SeedData.Seed(dbContext);
  }
  ```

The `Seed` method will get called when you run your web app.



## References

- *Murach's ASP.NET Core MVC*, Delamater and Murach, 

  Ch. 4  – "How to develop a data-driven MVC web app"

- [Publish an ASP.NET Core app to Azure with Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-6.0)

------

[![Creative Commons License](https://i.creativecommons.org/l/by-sa/4.0/88x31.png)](http://creativecommons.org/licenses/by-sa/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev), written 2020, revised <time>2026</time>, is licensed under a [Creative Commons Attribution-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-sa/4.0/). 

------