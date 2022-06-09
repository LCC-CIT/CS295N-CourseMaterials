CS295N Web Development 1: ASP.NET 

#  Repositories and Unit Testing

| Weekly Topics                             |                                                     |
| ----------------------------------------- | --------------------------------------------------- |
| 1. Intro to Web Dev                       | 6. Database & Entity Framework                      |
| 2. Intro to MVC & Deploying to Azure      | 7. Unit Testing with a DB / *Veteran's Day holiday* |
| 3. MVC Architectural patterns             | **8. Repositories and Unit Testing**                |
| 4. Bootstrap                              | 9. Controllers & Debugging / *Thanksgiving holiday* |
| 5. Midterm Quiz & Unit testing with xUnit | 10. Razor Views                                     |



## Contents 

[TOC]               

## Introduction

- Review due dates on Moodle
- Answer questions

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

### Example

This example code is from [BookInof-WebApp-Core3](https://github.com/ProfBird/BookInfo-WebApp-Core3) on GitHub.

#### The interface

```C#
public interface IBookRepository
{
    IQueryable<Book> Books { get; }  // property that can contain a collection of books
    void AddBook(Book book);											// method to add a book to the DB
    void AddReview(Book book, Review review);			// method to add a review to the DB
    Book GetBookByTitle(string title);			// method to retrieve a book from the DB
}
```

#### The "real" repository

```C#
public  class BookRepository : IBookRepository
{
    private AppDbContext context;
    // Get all books + associated data by using the EF Include method.
    public IQueryable<Book> Books 
    { get 
       { return context.Books.Include(book => book.Authors).Include(book =>
            book.Reviews).ThenInclude(review => review.Reviewer); 
       } 
    }

    public BookRepository(AppDbContext appDbContext)
    {
      context = appDbContext;
    }

    public  void AddBook(Book book)
    {
      context.Books.Add(book);
      context.SaveChanges();
    }

    public void AddReview(Book book, Review review)
    {
      book.Reviews.Add(review);
      context.Books.Update(book);
      context.SaveChanges();
    }

    public  Book GetBookByTitle(string title)
    {
      Book book;
      book = context.Books.First(b => b.Title == title);
      return book;
    }
}
```




## Dependency Injection  

Change the dependency of a class at run-time
- One way to create *loosely coupled* classes
-  Example: https://dotnetfiddle.net/PcxXrD



## Injecting Repositories into Controllers 

### Example

#### In Startup, the ConfigureServices method

```C#
services.AddTransient<IBookRepository, BookRepository>();
```

#### In a controller class

```C#
// private field
IBookRepository repo;

// constructor
public BookController(IBookRepository r)
{
    repo = r;
}

public IActionResult Index()
{
    var books = repo.Books.ToList();
    books.Sort((b1, b2) => string.Compare(b1.Title,b2.Title,StringComparison.Ordinal));
    return View(books);
}
```



### Using IQueryable

You don't need to use IQueryable to implement repositories, but it's a good idea to use it whenever you are doing operations that pull data from a database.

The IQueryable<T> interface is useful because it allows a collection of objects of this type to be queried efficiently. Using the IQueryable<T> interface allows you to ask the database for just the objects that you require using standard LINQ statements and without needing to know what kind of database stores the data or how it processes the query. Without the IQueryable<T> interface, you would have to retrieve all of the objects from a data set and then discard the ones you don’t want. ***This is why the IQueryable<T>   interface is typically used for collection classes instead of IEnumerable<T> .***

However, care must be taken with the IQueryable<T> interface because each time the collection of objects is enumerated, the query will be evaluated again, which means that a new query will be sent to the database. This can undermine the efficiency gains of using IQueryable<T>. In such situations, you can convert IQueryable<T> to a concrete form using the ToList() or ToArray() method.

\- paraphrased from Freeman, 2017, page 201



## Unit Testing with a Fake Repository

### What to test

Before writing any unit tests, you need to know what methods to test. We want to test any computation or processing done by our app. We primarily test controller methods and sometimes helper methods on models (if there are any). There may also be some additional classes we've added that have functionality that should be tested (like a quiz or game).

### Example, in the Test Project

#### A fake repository class

```C#
public class FakeBookRepository : IBookRepository
{
    private List<Book> books = new List<Book>();
    public IQueryable<Book> Books { get { return books; } }

    public void AddBook(Book book)
    {
        // This simulates EF adding an automatically generated ID
        book.BookID = books.Count;  
        books.Add(book);
    }

    public void AddReview(Book book, Review review)
    {
        // There will only be one book with a matching ID, 
        // but books.First will return a single Book object instead of a collection.
        Book theBook = books.First<Book>(b => b.BookID == book.BookID);
        theBook.Reviews.Add(review);
    }
    public Book GetBookByTitle(string title)
    {
        Book book = books.Find(b => b.Title == title);
        return book;
    }

}
```

#### Unit tests using the fake repository

Instructor todo: Add better examples of testing functionality!

```c#
public class BookTest
{
    // Verify that the Index HttpGet method returns a sorted list of books.
    [Fact]
    public void IndexTest()
    {
        // Arrange
        var repo = new FakeBookRepository();
        AddTestBooks(repo);
        var bookController = new BookController(repo);

        // Act - get a list of books sorted by title in ascending order
        var result = (ViewResult)bookController.Index();
        var books = (List<Book>)result.Model;
        // Assert that book titles are in ascending order.
        // This implicitly checks that there are three books in the list as well.
        Assert.True(string.Compare(books[0].Title, books[1].Title) < 0 &&
                    string.Compare(books[1].Title, books[2].Title) < 0);
    }

    // Verify that the AddReview HttpPost method adds a review for a specific book.
    [Fact]
    public void AddReviewTest()
    {
        // Arrange
        var repo = new FakeBookRepository();
        AddTestBooks(repo);
        var bookController = new BookController(repo);

        // Act
        bookController.AddReview("Sense and Sensibility",
                                 "This book is a classic!", "A. Reader");
        // Assert
        Assert.Equal("This book is a classic!",
                     repo.GetBookByTitle("Sense and Sensibility").Reviews[0].ReviewText);

    }

    // This method adds three books and authors, and one review to the repository.
    private void AddTestBooks(FakeBookRepository repo)
    {
        // Add the first book
        Book book = new Book()
        {
            Title = "The Fellowship of the Ring",
            PubDate = new DateTime(1937, 1, 1)
        };
        book.Authors.Add(new Author
                         {
                             Name = "J.R.R. Tolkein"
                         });
        repo.AddBook(book);

        // Add the second book
        book = new Book()
        {
            Title = "Sense and Sensibility",
            PubDate = new DateTime(1811, 1, 1)
        };
        book.Authors.Add(new Author
                         {
                             Name = "Jane Austen"
                         } );
        repo.AddBook(book);

        // Add the third book and a review
        book = new Book()
        {
            Title = "Paradise Lost",
            PubDate = new DateTime(1667, 1, 1)
        };
        book.Authors.Add(new Author
                         {
                             Name = "John Milton"
                         });
        Review review = new Review() { ReviewText = "Awesome book!" };
        book.Reviews.Add(review);
        repo.AddBook(book);
    }
}
```



## Unit of Work

Why some people use the Unit of Work pattern:

> The goal of the unit of work pattern is to simplify DML (Data Manipulation Language) in your code and only commit changes to the database/objects when it's truly time to commit. &mdash;https://github.com/Coding-With-The-Force/Salesforce-Separation-Of-Concerns-And-The-Apex-Common-Library/wiki/05)-The-Unit-of-Work-Pattern



## Further Reading

- [xUnit Documentation](https://xunit.github.io)

- [Dependency Injection Demystified](http://www.jamesshore.com/Blog/Dependency-Injection-Demystified.html)

- [Repository Pattern in ASP.NET Core](https://www.c-sharpcorner.com/article/repository-pattern-in-asp-net-core/)

- *Pro ASP.NET Core MVC 2*,
  7th Edition, Adam Freeman
  Apress, 2017
  - Ch. 7 – Unit Testing MVC Applications
  - Ch. 18 - Dependency Injection

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

