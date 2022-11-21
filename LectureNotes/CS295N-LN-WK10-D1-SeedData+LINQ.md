**CS295N Web Development 1: ASP.NET** 

<h1>Seed Data and LINQ</h1>



| Weekly Topics                           |                                          |
| --------------------------------------- | ---------------------------------------- |
| 1. Intro to Web Dev                     | 6. Unit Testing                          |
| 2. Intro to MVC & Deploying to Azure    | 7. Database & Entity Framework           |
| 3. Working with Data                    | 8. Unit Testing & The Repository Pattern |
| 4. Bootstrap                            | 9. Linq & Seed Data                      |
| 5. Midterm Quiz & Term Project Proposal | 10. Debugging                            |



 **Contents**

[TOC]

## Q and A

- Labs

  - Lab 7, Repositories and Unit Tests
    - Revised the requirements to just require two unit tests which can both be of the same controller method.
    - Accepting submissions through the end of the week, I won't grade them until Saturday at the earliest.


  - Lab 8 will be due 12/1, Thursday night of next week (week 10).

  - Lab 9 is optional, extra credit and will be due 12/5, Monday night of finals week (week 11).
- the term project is also due Monday, 12/5.

- Discuss questions.  
  After covering seed data, I will talk about how to avoid creating duplicate entities, for example Books. We won't address duplicate entities for the same user this term. That will be taken care of by Identity next term.



## Introduction

Seed data is data that is automatically added to your database when the application is started. There are two main purposes for seed data:

- Development testing.
- Data that is needed in production. For example, data that will populate pre-defined select lists.

## Seeding Your Database

One way to seed your database is to write a class with a static method that will add entities to the database. The method to seed the database will be called from *Startup*. I put mine in a static class named *SeedData*, but it's not a special name (not part of a convention).

Note that the method I'm using here is different from the method shown in the textbook (Murach and Delameter, 2020).

### Seed Data class and method

````c#
public class SeedData
{
   public static void Seed(BookReviewContext context)
   {
      if (!context.Reviews.Any())  // this is to prevent adding duplicate data
      {
          Review review = new Review
          {
              BookTitle = "Prince of Foxes",
              AuthorName = "Samuel Shellabarger",
              ReviewText = "Great book, a must read!",
              Reviewer = new User { Name = "Emma Watson" },
              ReviewDate = DateTime.Parse("11/1/2020")
          };
          context.Reviews.Add(review);  // queues up a review to be added to the DB

          review = new Review
          {
              BookTitle = "Virgil Wander",
              AuthorName = "Lief Enger",
              ReviewText = "Wonderful book, written by a distant cousin of mine.",
              Reviewer = new User { Name = "Brian Bird" },
              ReviewDate = DateTime.Parse("11/30/2020")
          };
          context.Reviews.Add(review);  

          context.SaveChanges(); // stores all the reviews in the DB
       }
    }
  }
}
````

### Call the Seed method from the Startup class

- Add your `DbContext` class as an additional parameter on the Configure method:
`public void Configure(IApplicationBuilder app, IWebHostEnvironment env, BookReviewContext context)`
- Add a call to the *Seed* method at the end of the *Configure* method in the *Startup* class.
`SeedData.Seed(context);`

The Seed method will get called when you update the database, <u>or</u> when you run your web app.



## Language Integrated Query (LINQ) 

- Language Integrated Query – it’s part of C# (and all the .NET languages) and can be used to query almost anything: an array, list, XML file, database, and more.
- Use this in place of embedded SQL in your C# code or in place of stored procedures.
- LINQ use functional language concepts. By the way, SQL also uses some [functional language](https://en.wikipedia.org/wiki/Functional_programming) concepts like statelessness and "all at once"(non-sequential) operations.
- LINQ Query expression syntax (as opposed to LINQ fluent syntax) was inspired by languages like LISP and Haskell and looks superficially like SQL – but it’s significantly different.

  - Essential operators: *from*, *select*, *where*

    - Full list of LINQ keywords: [Query Keywords](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords)

### Example

Walk through the [Planet example](https://github.com/ProfBird/CS295-Demos/tree/master/LinqDemo).

- Assume a Planet class.  

```c#
  public class Planet  {
      public string Name {get; set;}
      public       int Diameter {get; set;}     // km
      public int DistanceToSun {get;     set;}  // million km
  }
```
- Assume a Planet List in which each of the eight planets has: a name, size, and distance from the sun.

````c#
    List<Planet> planets = new List<Planet>();
    planets.Add(new Planet{Name="Mercury", Diameter=4879, DistanceToSun=67});
    // TODO: add the other seven planets
````

- This LINQ statement will return all the planets within 200 million km of the sun:

  ```c#
  IEnumerable<String> innerPlanets = 
      from p in planets 
      where p.DistanceToSun < 200 
      select p.Name;
  ```

  - *from* declares the *range variable*.  
    The *range variable* represents the current element in the collection that is being queried. Its scope is just this query. 
  - *where* filters the objects that are retrieved.
  - *select* specifies the objects to retrieve.

- Compare the LINQ statement above to the header of the `foreach` loop below. Notice the similar use of the *range variables.
  ```c#
  foreach (Planet p in planets)
  ```

- Deferred execution: A LINQ statement returns an IEnumerable or an IQueryable. They look like collections, but they do not contain any actual data. They just represent the query and are executed when enumerated

  - The query above won't be executed until you enumerate *innerPlanets*
    `foreach (String s in innerPlanets){  Console.Write(s + ", ");}`

- You can get a collection directly from a LINQ query by adding a scalar operator, like *ToList*.
  `List<String> innerPlanets = (from p in planets where p.DistanceToSun < 200 select p.Name).ToList();`

- Queries return a collection unless a scalar operator is applied (first, count, etc.)
  `int planetCount = (from p in planets where p.DistanceToSun < 200 select p.Name).count();`

### Exercise

Add to the Planet example:

- Write a query to find all the planets greater than a certain size. Use a loop to display the name and size of each planet.
- Write a query to search for "Earth".

  - Display the size and distance from the sun
  - Hint: Use .SingleOrDefault() at the end of the query so that your query returns a Planet object.





## References

- *Murach's ASP.NET Core MVC*, Delamater and Murach, 

  Ch. 4  – "How to develop a data-driven MVC web app"

- [Publish an ASP.NET Core app to Azure with Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-3.1)

- [Language Integrated Query (LINQ)](https://docs.microsoft.com/en-us/dotnet/csharp/linq/)

- [Add search to an ASP.NET Core MVC app (Movie app)](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-3.1)

- [ASP.NET Core MVC with EF Core - Sort, Filter, Paging (Contoso University app)](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-3.1)



------

[![Creative Commons License](https://i.creativecommons.org/l/by-sa/4.0/88x31.png)](http://creativecommons.org/licenses/by-sa/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev) is licensed under a [Creative Commons Attribution-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-sa/4.0/). 

------