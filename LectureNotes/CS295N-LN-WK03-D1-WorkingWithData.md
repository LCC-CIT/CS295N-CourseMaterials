**CS295N Web Development 1: ASP.NET**

| Weekly Topics                             |                                               |
| ----------------------------------------- | --------------------------------------------- |
| 1. Intro to Web Dev                       | 6. Entity Framework / Deploying a DB to Azure |
| 2. Intro to MVC / Deploying to Azure      | 7. Debugging / *Veteran's Day holiday*        |
| <mark>3. Working with data</mark>         | 8. Controllers                                |
| 4. Bootstrap                              | 9. Razor Views / *Thanksgiving holiday*       |
| 5. Midterm Quiz / Unit testing with xUnit | 10. Validation                                |

**Contents**

[TOC]

## Q and A

- Any questions about lab 2?
- Any questions about PRs and code reviews?
- Any questions from reading  Ch. 2?

## What's Due

- Lab 2 beta version PR was due Sunday
- Lab 2 code review: Tuesday
- Quiz 3: Wednesday
- Lab 2 production version: Thursday
  - Part 2 (your web site) should be published to Azure again.

- Lab 3 beta version PR: Sunday



## Overview

This week you will learn to work with data in all three parts of your MVC web site:

- Model: holds data being sent between a controller and a view.
- Controller: responds to HTTP requests and moves data between views using a model:
  - HTTP GET: a controller method will receive a request either with or without a query for data:
    - without a query on the URL&mdash;just a view will be returned.
    - with a query on the URL&mdash;a model with the requested data will be sent to the view and the view will be returned.
  - HTTP POST: a controller method will receive a request that contains data to be put into a model (and later it will also be put into a database).
- View: gets or displays data.



## Designing a Domain Model

Before we can start writing our model classes, we need to decide which model classes we need and what properties should go in them. In other words, we need to design a *domain model*.

#### Defining a Domain Model

The concept of "domain"&mdash;the world of your solution

A domain model contains <u>multiple model classes</u> that will get mapped to tables in a relational database (later this term).

A model is a C# class that primarily just contains properties.

#### Identifying classes, fields, properties and methods

One of the first steps in designing object oriented software is to decide what classes you need and what goes in them.

- For OOP design in general
  When designing OOP classes for C# or any language, one approach is to write a written prose description of what the software will do, then identify:

  - Nouns: these are potential classes or fields, or properties.

  - Verbs: these are potential methods.


- For model classes

  - We just use *properties* rather than create fields (aka instance variables) unless they are *backing fields* for properties.

  - We normally don't include methods.
    - If methods are included they should be small and just for doing something like unit or format conversion of the data.
    - The methods should have no dependencies, since model classes should have no dependencies.

###  Relationships Between Model Classes
- Some general OOP relationships:

  - **Inheritance**: "is-a"

  - **Association** (similar to aggregation): "uses-a" (or "has-a")

  - **Composition**: "part-of" &larr; *complex model classes will almost always have this relationship to each other.*

- Model Relationships
    - Any of the three above are possible.
    - Inheritance doesn't translate to database schema well, so we will use it sparingly.


## Writing Model Classes

Once we have designed our domain model, we can write our individual model classes.

For example:

```C#
public class Review
{
    public string BookTitle { get; set; }
    public string AuthorName { get; set; }
    public AppUser Reviewer { get; set; }
    public string ReviewText { get; set; }
    public DateTime ReviewDate { get; set; }
}
```

```C#
public class AppUser
{
    public string UserName { get; set; }
    public DateTime SignUpDate {get; set;}
}
```

FYI, the `AppUser` model will get more added to it next term when we add *authentication* and *authorization* to our web sites.

 #### Identifying Relationships

  What is the relationship between our two models?

  - Can a `Review` exist without the `AppUser`?
  - Can a `AppUser` exist without a `Review`?

### Refactoring Model Classes

We might decide that we want a separate `Book` model. (Or even separate `Book` and `Author` models.) Lets refactor our domain model so that we have separate `Review` and `Book` models.

Example: refactored `Review` model class and a new `Book` model class

```C#
public class Review
{
    public Book Book { get; set; }
    public AppUser Reviewer { get; set; }
    public string ReviewText { get; set; }
    public DateTime ReviewDate { get; set; }
}
```

```C#
public class Book
{
    public string BookTitle { get; set; }
    public string AuthorName { get; set; }
    public int Isbn {get; set;}
    public string Publisher {get; set;}
    public DateTime PubDate { get; set; }
}
```

#### Identifying relationships

What is the relationship between our three models?

  - Can a `Review` exist without the `Book`?
  - Can a `Book` exist without a `Review`?

Draw a UML diagram that shows the relationships between all three models.



## Writing Controller Methods

### HTTP GET methods

```c#
        public IActionResult Index()
        {
            return View();
        }
```

- May optionally include a query for data (as a parameter in the Index method.)
- Used for displaying a view with, or without sending it data (as an argument in the View method).
- Controller methods are HTTP GET methods by default.



### HTTP POST methods

- Will receive data from a view (usually a view containing an HTML form) passed to the method in one of two ways:

  - In a model object:

    ```c#
    [HttpPost]
    public IActionResult Review(Review model)
    {
        model.ReviewDate = DateTime.Now;  // Add date and time to the model
        return View(model);
    }
    ```

  - In parameters that match the HTML form field names:

    ```c#
    [HttpPost]
    public IActionResult Review(string bookTitle, string authorName,
            string reviewerName, string reviewText, string reviewDate)
    {
    		// Create a new model since one wasn't passed in
    		Review model = new Review(){BookTitle = bookTitle, 
    		     AuthorName = authorName, ReviewText = reviewText,
    		     Reviewer = new User(){Name = reviewerName},
    		     ReviewDate = DateTime.Now }
        return View(model);
    }
    ```


## Writing Views

Views are written using *Razor* syntax. This is a mixture of HTML and C# which is why the file extension is `.cshtml`. Razor views can also contain CSS and JavaScript. They are pretty much like an HTML page with C# mixed in. Whenever we add C# to a view, we prefix it with the `@` symbol.

Remember that the C# doesn't actually end up running in the browser. It only runs on the server at the time the view is being rendered into an HTML page prior to being sent to the browser.

### Simple Views

The simplest view just has HTML in it. For example:

```html
<h1>Simple Razor View</h1>
Hello world!
```

We could add some C# like this:

```html
<h1>Simple Razor View</h1>
Hello world, the time is @DateTime.Now.ShortTimeString()
```

### Strongly Typed Views

If a controller method is going to send data to a view using a model object, then the view needs to have that model type declared in the view. This makes the view into a *strongly typed* view. For example, if a controller method is going to put the time and day of the week into a model object from a class named `DayAndTime` and then send it to a view, the view would look like this:

```html
@model DayAndTime
<h1>Simple Razor View</h1>
Hello world, it's @Model.Day and the time is @Model.Time
```

### Form Views

- This view would be invoked by an `HttpGet` method in the controller.
- The form method attribute must be set to `post`. (The default is `get`.)
- Here are two versions of a view that will send data to a `HttpPost` method in the controller.  
  Note that we are using the refactored version of the `Review` model that has `Book` and `AppUser` as property types.

The version below uses regular HTML attributes in the labels and input elements.

```c#
@model Review
@{
    ViewData["Title"] = "Books";
}

<form method="post">
    <label for="title">Title</label>
    <input id="title" name="Book.Title" /><br />

    <label for="author">Author</label>
    <input id="author" name="Book.Author"/><br />

    <label for="reviewer">Reviewer</label>
    <input id="reviewer" name="Reviewer.Name" /><br />

    <label for="text">Review</label>
    <textarea id="text" name="ReviewText"></textarea><br />

    <button type="submit">Submit</button>
</form>
```
This version uses the `asp-for` tag helper in the labels and input elements.

```c#
@model Review
@{
    ViewData["Title"] = "Books";
}

<form method="post">
    <label asp-for="Book.BookTitle">Title</label>
    <input asp-for="Book.BookTitle" /><br />

    <label asp-for="Book.AuthorName">Author</label>
    <input asp-for="Book.AuthorName" /><br />

    <label asp-for="Reviewer.Name">Reviewer</label>
    <input asp-for="Reviewer.Name" /><br />

    <label asp-for="ReviewText">Review</label>
    <textarea asp-for="ReviewText"></textarea><br />

    <button type="submit">Submit</button>
</form>
```



## Reference

Ch. 2, "How to code a single-page MVC web app", *Murach’s ASP.NET Core MVC*, 2nd Edition, by Mary Delamater and Joel Murach, Murach Books, 2022.

[Overview of ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-10.0), Microsoft Tutorial, 2024


------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev), revised <time>2026</time>, are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------