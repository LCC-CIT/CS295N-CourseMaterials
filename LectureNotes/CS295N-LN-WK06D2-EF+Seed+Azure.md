**CS295N Web Development 1: ASP.NET
**

<h1>EF, Seed Data, Publishing to Azure</h1>

| Weekly Topics                           |                                             |
| --------------------------------------- | ------------------------------------------- |
| 1. Intro to Web Dev                     | 6. Unit Testing                             |
| 2. Intro to MVC & Deploying to Azure    | 7. <mark>Database & Entity Framework</mark> |
| 3. Working with Data                    | 8. Unit Testing & The Repository Pattern    |
| 4. Bootstrap                            | 9. Linq & Seed Data                         |
| 5. Midterm Quiz & Term Project Proposal | 10. Debugging                               |

<h2>Contents</h2>

[TOC]

# Announcements and Discussion

For fall term 2023

- Lab 5, any questions on the quiz code or unit tests?
  - production version due Thursday (tomorrow).

## Introduction

We will  finish up last class's topic of adding a database to your web app by adding code to store and retrieve data, add seed data to the database and publish it to Azure.

## Controller Code for Storing and Retrieving Data

In Controller methods where you want to store or retrieve data you will use an instance (object) of your DbContext class (ApplicationDbContext in our example), to do database operations. In order to use the DbContext object in a controller it needs to be passed in via the controller's constructor, like this:

```C#
public class ReviewController : Controller
    {
  			// field of class
        ApplicationDbContext context; 
  
  			// constructor
        public ReviewController(ApplicationDbContext c)
        {
            context = c;
        }
        // The rest of the class is not shown
```

The DbContext object gets passed to the controller constructor via dependency injection.

In a controller method that needs to store data, you would call the `Add`, and `SaveChanges` methods on the DbContext object like this:

```C#
 context.Reviews.Add(model);
 context.SaveChanges(); 
```



In a controller method that needs to retrieve a particular item from the database you could call the `Find` method:

```C#
 review = context.Reviews.Find(reviewId);
```



In order to retrieve multiple items, you would just convert the DbSet to a C# List:

```C#
List<Review> reviews = context.Reviews.ToList();
```

The code above will work, but will only retrieve the only properties that are directly on the `Review` objects. The properties on objects that are a part of `Review` will not be included.



## Loading related data

Related data is data that comes from objects that are related to the object you are retrieving by aggregation or composition. 

For example, in the <u>hypothetical</u> `Review` domain model below, the `Book`, `Reviewer`, and `Author` properties are related data because they are related to Review objects by aggregation (a Review "has-a" Book and an AppUser, a Book "has-an" Author).

![](ReviewComplexDomainModel.png)

### Ways to load related data

- **Eager loading**
  Related data is loaded from the database as part of the initial query.

  - Use the *Include* method to include dependent objects. You only need this when you include your own model classes (not for *DateTime* or other classes that are not part of your domain model.)
  
  - Use *ThenInclude* for second-level dependencies.
    
    Example code snippet from a controller method that gets a list of `Review` objects from a database:
    
    ```C#
    public List Reviews = context.Reviews
      .Include(review => review.Reviewer) // returns Reivew.AppUser object
      .Include(review => review.Book) // returns Review.Book object
      .ThenInclude(book => book.Author)  // returns Review.Book.Author object
      .ToList();
    ```
    
  
    The syntax of the include statement is:  
    
    *Include(parameterRepresentingDbSet => parameter.ModelPropertyName)*
  
- **Explicit loading**
  Related data is explicitly loaded from the database at a later time.
  (See the article below for more details.)
  
- **Lazy loading**
  Related data is transparently loaded from the database when a dependent property (or navigation property) is accessed.
  (See the article below for more details.)

> **Reference**
> MS EF Core Tutorial: [Loading Related Data](https://docs.microsoft.com/en-us/ef/core/querying/related-data)

------



## Seeding Your Database

- The method to seed the database will be called from *Program.cs*. I put mine in a static class named *SeedData*, but it's not a special name (not part of a convention), nor is the method name I used. 

  ```c#
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
  ```

   

- Add a call to the *Seed* method at the end of the *Configure* method in the *Startup* class.

  ```C#
  SeedData.Seed(app);
  ```

- The Seed method gets called when you run the CLI command to update the database, or when you run your web app:

  `dotnet ef database update`

 

# Examples

[Book Reviews Example, 6-Database branch](https://github.com/LCC-CIT/CS295N-Example-BookReviews/tree/6-Database)

[All About Pigeons Example, Lab06 branch](https://github.com/ProfBird/BrianBird_CS295N_Labs/tree/Lab06)



------

# References

## Text Book

- Ch. 4, "How to develop a data-driven MVC web app", 

  *Murach’s ASP.NET Core MVC*, 2nd Edition, by Mary Delamater and Joel Murach, Murach Books, 2022.

## Online

- Microsoft Tutorial: [Get started with ASP.NET Core MVC and Entity Framework Core using Visual Studio](https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/?view=aspnetcore-6.0)
- Microsoft Reference: [Entity Framework Core tools reference - .NET CLI](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)
- Microsoft Tutorial: [Publish an ASP.NET Core app to Azure with Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-6.0)



------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) These ASP.NET Core MVC Lecture Notes written by [Brian Bird](https://profbird.dev) in 2018 and revised in 2023,  are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

