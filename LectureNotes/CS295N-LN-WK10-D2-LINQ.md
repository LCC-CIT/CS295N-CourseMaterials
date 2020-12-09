**CS295N Web Development 1: ASP.NET** 

# Searching and filtering with LINQ



| Weekly Topics                             |                                                     |
| ----------------------------------------- | --------------------------------------------------- |
| 1. Intro to Web Dev                       | 6. Database & Entity Framework                |
| 2. Intro to MVC & Deploying to Azure      | 7. Unit Testing with a DB / *Veteran's Day holiday* |
| 3. MVC Architectural patterns             | 8. More on the Repository Pattern                   |
| 4. Bootstrap                              | 9. Debugging / *Thanksgiving holiday*               |
| 5. Midterm Quiz & Unit testing with xUnit | 10. **Seed Data and LINQ**                              |



 **Contents**

[TOC]

## Introduction

- Review due dates on Moodle
- Discuss questions



## Language Integrated Query (LINQ) 

- Language Integrated Query – it’s part of C# (and all the .NET languages) and can be used to query almost anything: an array, list, XML file, database, and more.

- Use this in place of embedding SQL in your C# code or in place of stored procedures.

- LINQ use functional language concepts (SQL also uses [functional language](https://en.wikipedia.org/wiki/Functional_programming) some functional language concepts like statelessness and "all at once", non-sequential, operations)

- LINQ Syntax (Query expression syntax, as opposed to fluent syntax) (inspired by languages like LISP and Haskell) Looks superficially like SQL – but it’s significantly different.

  - Essential operators: *from*, *select*, *where*
  - Full list of LINQ keywords: [Query Keywords](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords)

- Walk through the [Planet example](https://github.com/ProfBird/CS295-Demos/tree/master/LinqDemo) 

  We will start with a Planet class.

  ```C#
  public class Planet  
  {
    public string Name {get; set;}
    public int Diameter {get; set;} // km
    public int DistanceToSun {get; set;}  // million km
  }
  ```

  We also have list of planets

  ```C#
  List<Planet> planets = new List<Planet>();
  planets.Add(new Planet{Name="Mercury", Diameter=4879, DistanceToSun=67});
  // TODO: add the other seven planets
  ```

  This LINQ statement will return all the planets within 200 million km of the sun 

  ```C#
  IEnumerable<String> innerPlanets = from p in planets
   where p.DistanceToSun < 200
   select p.Name;
  ```

  - *from* declares the *range variable*. The *range variable* represents the current element in the collection that is being queried. Its scope is just this query. 
  - *where* filters the objects that are retrieved.
  - *select* specifies the objects to retrieve.

- A hint for understanding *range variables*:

  Compare the LINQ statement above to the header of the *foreach* loop below. Notice the similar use of the *range variables*.
  `foreach (**Planet p** in planets)`

- Deferred execution: A LINQ statement returns an IEnumerable or an IQueryable. They look like collections, but they do not contain any actual data. They just represent the query and are executed when enumerated.

  - The query above won't be executed until you enumerate *innerPlanets*
    
    ```C#
    foreach (String s in innerPlanets)
    {
      Console.Write(s + ", ");
    }
    ```
    
  - You can get a collection directly from a LINQ query by adding a conversion method, like *ToList()*.
    
    ```C#
    List<String> innerPlanets = (from p in planets where p.DistanceToSun < 200 select p.Name).ToList();
    ```

  - Queries return a collection unless a scalar operator is applied (first, count, etc.)


      ```C#
    int planetCount = 
       (from p in planets where p.DistanceToSun < 200 select p.Name).count();
      ```

### Exercise: Add to the Planet example

1. Write a query to find all the planets greater than a certain size. Use a loop to display the name and size of each planet.

2. Write a query to search for "Earth".

- Display the size and distance from the sun
- Hint: Use `.SingleOrDefault()` at the end of the query so that your query returns a single `Planet` object or `null`.




## References

- *Murach's ASP.NET Core MVC*, Delamater and Murach, 

  Ch. 4  – "How to develop a data-driven MVC web app"

- [Language Integrated Query (LINQ)](https://docs.microsoft.com/en-us/dotnet/csharp/linq/)

- [Add search to an ASP.NET Core MVC app (Movie app)](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-3.1)

- [ASP.NET Core MVC with EF Core - Sort, Filter, Paging (Contoso University app)](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-3.1)



------

[![Creative Commons License](https://i.creativecommons.org/l/by-sa/4.0/88x31.png)](http://creativecommons.org/licenses/by-sa/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev) is licensed under a [Creative Commons Attribution-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-sa/4.0/). 

------