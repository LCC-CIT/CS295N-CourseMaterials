CS295N Web Development 1: ASP.NET 

<h1>Repositories and Unit Testing</h1>

| Weekly Topics                           |                                                       |
| --------------------------------------- | ----------------------------------------------------- |
| 1. Intro to Web Dev                     | 6. Unit Testing                                       |
| 2. Intro to MVC & Deploying to Azure    | 7. Database & Entity Framework                        |
| 3. Working with Data                    | <mark>8. Unit Testing & The Repository Pattern</mark> |
| 4. Bootstrap                            | 9. Linq & Seed Data                                   |
| 5. Midterm Quiz & Term Project Proposal | 10. Debugging                                         |

<h2>Contents</h2>

[TOC]               

## Q and A

**For 11/13/2023**

- Upcoming due dates:
  - This week's quiz closes before class on Wednesday.
  - Lab 6 is due Thursday night, publishing to Azure is not required.
  - This is the last week to change grade options.

- I've caught up on grading! Please look at my feedback.


- Answer questions.

## Overview

This week we will:

- Refactor our controller code to use *repositories* instead of directly using a dBContext object to work with data via EF.
- Create a *fake* repository to facilitate unit testing.
- Add unit tests for controller methods that work with data.
- Create a database server on Azure and publish our sites to Azure.  
  Be sure to check your Azure credit. One student already lost thier account!

## Repositories: Real and Fake

One way of managing data in our web app is to use the [Repository Pattern](https://www.c-sharpcorner.com/article/repository-pattern-in-asp-net-core/). Rather than accessing data directly through Entity Framework, the data will be accessed through a repository.

- Reasons for using a repository:

  - The main reason is that it facilitates unit testing since the repository can be replaced by a "fake" for testing.
  - It can facilitate a simple source of "hard coded" data for integration testing during early development.
  - It provides an additional layer of abstraction:
    - For implementing common data operations.
    - To facilitate refactoring&mdash;for example, changing the ORM.
- Implementation
  - Real and Fake repositories both inherit from an interface
    - This supports [dependency injection](http://www.jamesshore.com/Blog/Dependency-Injection-Demystified.html) so that the fake repository can be easily injected when testing.

- Fake repositories:
  - Are Just used for unit testing.
  - Can contain hard-coded test data.
  - Different test data can be supplied for different tests.




## Dependency Injection  

Change the dependency of a class at run-time

- One way to create *loosely coupled* classes
- Example: https://dotnetfiddle.net/PcxXrD



### Example

This example code is from the [Book Reviews](https://github.com/LCC-CIT/CS295N-Example-BookReviews-DotNet6) web app on GitHub.

#### The interface

```C#
public interface IReviewRepository
    {
        public Review GetReviewById(int id); // Returns a model object
        public int StoreReview(Review model);  // Saves a model object to the db
    }
```

#### The "real" repository

```C#
 public class ReviewRepository : IReviewRepository
{
    private ApplicationDbContext context;

    public ReviewRepository(ApplicationDbContext appDbContext)
    {
        context = appDbContext;
    }

    public Review GetReviewById(int id)
    {
        var review = context.Reviews
          .Include(review => review.Reviewer) // returns Reivew.AppUser object
          .Include(review => review.Book) // returns Review.Book object
          .Where(review => review.ReviewId == id)
          .SingleOrDefault();
        return review;
    }
   
    public int StoreReview(Review model)
    {
        model.ReviewDate = DateTime.Now;
        context.Reviews.Add(model);
        return context.SaveChanges();
        // returns a positive value if succussful
    }
}
```



## Injecting Repositories into Controllers 

### Example

#### In Program.cs

```C#
builder.Services.AddTransient<IReviewRepository, ReviewRepository>();
```

#### In a controller class

```C#
// private field
IReviewRepository repo;

// constructor
public ReviewController(IReviewRepository r)
{
    repo = r;
}

public IActionResult Index()
{
    var reviews = repo.Reviews.ToList();
    return View(reviews);
}
```



### Using IQueryable

You don't need to use IQueryable to implement repositories, but it's a good idea to use it whenever you are doing operations that pull data from a database.

The IQueryable<T> interface is useful because it allows a collection of objects of this type to be queried efficiently. Using the IQueryable<T> interface allows you to ask the database for just the objects that you require using standard LINQ statements and without needing to know what kind of database stores the data or how it processes the query. Without the IQueryable<T> interface, you would have to retrieve all of the objects from a data set and then discard the ones you don’t want. *This is why the IQueryable&lt;T&gt;   interface is typically used for collection classes instead of IEnumerable .*

However, care must be taken with the IQueryable&lt;T&gt; interface because each time the collection of objects is enumerated, the query will be evaluated again, which means that a new query will be sent to the database. This can undermine the efficiency gains of using IQueryable&lt;T&gt;. In such situations, you can convert IQueryable&lt;T&gt; to a concrete form using the ToList() or ToArray() method.

\- paraphrased from Freeman, 2017, page 201

Example:

```c#
        public IQueryable<Review> Reviews
        {
            get
            {
                // Get all the Review objects in the Reviews DbSet
                // and include the Reivewer object in each Review.
                return context.Reviews.Include(review => review.Reviewer)
                .Include(review => review.Book);
            }
        }
```



## Unit Testing with a Fake Repository

### What to test

Before writing any unit tests, you need to know what methods to test. We want to test any computation or processing done by our app. We primarily test controller methods and sometimes helper methods on models (if there are any). There may also be some additional classes we've added that have functionality that should be tested (like a quiz or game).

### Example, in the Test Project

#### A fake repository class

Note that the `List` object is used in place of a database.

```C#
public class FakeReviewRepository : IReviewRepository
{
    private List<Review> reviews = new List<Review>();   // Use a list as a data store

    public Review GetReviewById(int id)
    {
        Review review = reviews.Find(r => r.ReviewId == id);
        return review;
    }

    public int StoreReview(Review model)
    {
        int status = 0;
        if (model != null)
        {
            model.ReviewId = reviews.Count + 1;
            reviews.Add(model);
            status = 1;    
        }
        return status;
    }
}
```

#### Unit tests using the fake repository

```c#
public class ReviewControllerTests
{
    IReviewRepository repo = new FakeReviewRepository();
    ReviewController controller;

    public ReviewControllerTests()
    {
        controller = new ReviewController(repo);
    }

    [Fact]
    public void Review_PostTest_Success()
    {
        // arrange
        // Done in the constructor

        // act
        var result = controller.Review(new Review());

        // assert
        // Check to see if I got a RedirectToActionResult
        Assert.True(result.GetType() == typeof(RedirectToActionResult));
    }

    [Fact]
    public void Review_PostTest_Failure()
    {
        // arrange
        // Done in the constructor

        // act
        var result = controller.Review(null);

        // assert
        // Check to see if I got a RedirectToActionResult
        Assert.True(result.GetType() == typeof(ViewResult));
    }

}
```



## Unit of Work

Why some people use the Unit of Work pattern:

> The goal of the unit of work pattern is to simplify DML (Data Manipulation Language) in your code and only commit changes to the database/objects when it's truly time to commit. &mdash;https://github.com/Coding-With-The-Force/Salesforce-Separation-Of-Concerns-And-The-Apex-Common-Library/wiki/05)-The-Unit-of-Work-Pattern



## Further Reading

- [Dependency Injection Demystified](http://www.jamesshore.com/Blog/Dependency-Injection-Demystified.html)
- [Repository Pattern in ASP.NET Core](https://www.c-sharpcorner.com/article/repository-pattern-in-asp-net-core/)
- *Murach’s ASP.NET Core MVC*, 2nd Edition, by Mary Delamater and Joel Murach, Murach Books, 2022.  
  In Ch. 14:
  - "How to use dependency injection (DI)", pg. 560–569,
  - "How to test methods that have dependencies", pg. 578–581.

- *Pro ASP.NET Core MVC 2*,
  7th Edition, Adam Freeman
  Apress, 2017.
  - Ch. 7 – Unit Testing MVC Applications
  - Ch. 18 - Dependency Injection

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev), written 2018, updated 2023, is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

