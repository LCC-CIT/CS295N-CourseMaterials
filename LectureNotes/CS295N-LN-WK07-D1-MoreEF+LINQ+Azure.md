**CS295N Web Development 1: ASP.NET** 

<h1>More EF, LINQ and Publishing to Azure </h1>

<h2>Contents</h2>

[TOC]

## Q and A

- Announcements.
- Discuss questions about the previous lab.
- Review lab due dates on Moodle.

## Introduction

We will finish up last week's topic of adding a database to your web app by looking at how to add seed data to a database and publish it to Azure.

## Review

Last week we added Entity Framework to our project and used it to create a database.

I created a new branch, Lab06-Mac, for the students doing development on a Mac. The only difference is that this version uses SQLite instead of SQL Server as a database engine.

## Deploying a Web Site with a Database to Azure

These instructions assume you have already set up a [free student Azure account](https://azure.microsoft.com/en-us/free/students/) and have already deployed a version of your web app that doesn't have a database to Azure.

### Create a database via the Azure Web Portal 

- Log into the [Azure portal](https://portal.azure.com)

- Select SQL databases from the menu of services

- Click on +Add, then fill in the required fields

  - Create a resource group if you don't already have one

  - Create a server if you don't already have one

    - You are only allowed to have one free database per region. You select the region when you set up your server.

  - Select a pricing tier

    - If you are using a free student subscription, select the Free, 32 MB pricing tier.

- Copy the ADO.NET connection string for your database. You will need to add it to the publish profile in Visual Studio.

- Example connection string:

  `Server=tcp: practiceserver.database.windows.net,1433; Initial Catalog=Movie; Persist Security Info=False; User ID={your_username}; Password={your_password}; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;`



### Publish from Visual Studio 


- In Visual Studio, run the publish wizard by right-clicking on the project and selecting publish.

- Click on configure to change the settings in your publish profile

- Select the Settings page

- - In the *Databases* section, check the checkbox for your SQL Server connection string and paste the connection string for your Azure SQL Database.

  - - Be sure to put the user name and password for your Azure SQL Database in place of your_username and your_password and delete the curly braces.

  - In the *Entity Framework Migrations* section, check the check box for AppDbContext and add the connection string again.

- Now you can re-publish your web app.



## Seeding Your Database

- The method to seed the database will be called from *Startup*. I put mine in a static class named *SeedData*, but it's not a special name (not part of a convention), nor is the method name I used. 

  ````c#
  public class SeedData
  {
    public static void Seed(IApplicationBuilder app)
    {
      AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
      context.Database.EnsureCreated();
      if (!context.Books.Any())
      {
        Author author = new Author { Name = "Samuel Shellabarger" };
        context.Authors.Add(author);
        User user = new User { Name = "Walter Cronkite" };
        context.Users.Add(user);
        Review review = new Review
        {
          ReviewText = "Great book, a must read!",
          Reviewer = user    };
        context.Reviews.Add(review);
        Book book = new Book
        {
          Title = "Prince of Foxes",
          PubDate = DateTime.Parse("1/1/1947")
        };
        book.Authors.Add(author);
        book.Reviews.Add(review);
        context.Books.Add(book);
        context.SaveChanges(); // save all the data
      }
    }
  }
  ````

  

- Add a call to the *Seed* method at the end of the *Configure* method in the *Startup* class.

  ````C#
  SeedData.Seed(app);
  ````

- The Seed method gets called when you run the CLI command to update the database, or when you run your web app:

  `dotnet ef database update`





## Language Integrated Query (LINQ) 

- Language Integrated Query – it’s part of C# (and all the .NET languages) and can be used to query almost anything: an array, list, XML file, database, and more.

- Use this in place of embedding SQL in your C# code or in place of stored procedures.

- LINQ use functional language concepts (SQL also uses [functional language](https://en.wikipedia.org/wiki/Functional_programming) some functional language concepts like statelessness and "all at once", non-sequential, operations)

- LINQ Syntax (Query expression syntax, as opposed to fluent syntax) (inspired by languages like LISP and Haskell) Looks superficially like SQL – but it’s significantly different.

- - Essential operators: *from*, *select*, *where*

  - Full list of LINQ keywords: [Query Keywords](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords)

  - Walk through the [Planet example](https://github.com/ProfBird/CS295-Demos/tree/master/LinqDemo)

  - - Assume a Planet class.

      `public class Planet  {    public string Name {get; set;}    public int Diameter {get; set;}     // km    public int DistanceToSun {get; set;}  // million km  }`

    - Assume a Planet List in which each of the eight planets has a: name, size, and distance from the sun.

      `List<Planet> planets = new List<Planet>();planets.Add(new Planet{Name="Mercury", Diameter=4879, DistanceToSun=67});// TODO: add the other seven planets`

    - This LINQ statement will return all the planets within 200 million km of the sun `IEnumerable<String> innerPlanets = **from** p in planets **where** p.DistanceToSun < 200 **select** p.Name;`

    - - *from* declares the *range variable*. The *range variable* represents the current element in the collection that is being queried. Its scope is just this query. 
      - *select* specifies the objects to retrieve.
      - *where* filters the objects that are retrieved.

  - - Compare the LINQ statement above to the header of the *foreach* loop below. Notice the similar use of the *range variables*.
      `foreach (**Planet p** in planets)`

  - Deferred execution: A LINQ statement returns an IEnumerable or an IQueryable. They look like collections, but they do not contain any actual data. They just represent the query and are executed when enumerated

  - - The query above won't be executed until you enumerate *innerPlanets*
      `foreach (String s in innerPlanets){  Console.Write(s + ", ");}`
    - You can get a collection directly from a LINQ query by adding a scalar operator, like *ToList*.
      `List<String> innerPlanets = (from p in planets where p.DistanceToSun < 200 select p.Name).ToList();`

  - Queries return a collection unless a scalar operator is applied (first, count, etc.)
    `int planetCount = (from p in planets where p.DistanceToSun < 200 select p.Name).count();`

  - Exercise 1: Add to the Planet example

  - - Write a query to find all the planets greater than a certain size. Use a loop to display the name and size of each planet.

    - Write a query to search for "Earth".

    - - Display the size and distance from the sun
      - Hint: Use .SingleOrDefault() at the end of the query so that your query returns a Planet object.




## References

- *Murach's ASP.NET Core MVC*, Delamater and Murach, 

  Ch. 4  – "How to develop a data-driven MVC web app"

- *Pro ASP.NET Core MVC 2.0*, Adam Freeman, Apress, 2017, 

  Ch. 12 "Sports Store: Security and Deployment"

- [Publish an ASP.NET Core app to Azure with Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-3.1)

- [Language Integrated Query (LINQ)](https://docs.microsoft.com/en-us/dotnet/csharp/linq/)

- [Add search to an ASP.NET Core MVC app (Movie app)](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-3.1)

- [ASP.NET Core MVC with EF Core - Sort, Filter, Paging (Contoso University app)](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-3.1)



------

[![Creative Commons License](https://i.creativecommons.org/l/by-sa/4.0/88x31.png)](http://creativecommons.org/licenses/by-sa/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev) is licensed under a [Creative Commons Attribution-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-sa/4.0/). 

------