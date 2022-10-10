**CS295N Web Development 1: ASP.NET**

| Weekly Topics                             |                                               |
| ----------------------------------------- | --------------------------------------------- |
| 1. Intro to Web Dev                       | 6. Entity Framework / Deploying a DB to Azure |
| 2. Intro to MVC / Deploying to Azure      | 7. Debugging / *Veteran's Day holiday*        |
| 3. **Working with data**                  | 8. Controllers                                |
| 4. Bootstrap                              | 9. Razor Views / *Thanksgiving holiday*       |
| 5. Midterm Quiz / Unit testing with xUnit | 10. Validation                                |

**Contents**

[TOC]

## Q and A

- Any questions about lab 2?
- Any questions about PRs and code reviews?
- Any questions from the reading or the Ch. 2 quiz?



## Overview

This week you will learn to work with data in all three parts of your MVC web site:

- Model: holds data being sent between a controller and a view.
- Controller: responds to HTTP requests and moves data between views using a model:
  - HTTP GET: a controller method will receive a request either with or without a query for data:
    - without a query on the URL&mdash;just a view will be returned.
    - with a query on the URL&mdash;a model with the requested data will be sent to the view and the view will be returned.
  - HTTP POST: a controller method will receive a request that contains data to be put into a model (and later it will also be put into a database).
- View: gets or displays data.



## Defining a Domain Model

The concept of "domain"&mdash;the world of your solution

A domain model contains multiple model classes that will get mapped to tables in a relational database (later this term).

A model is a C# class that primarily just contains properties.

### Identifying classes, fields, and methods

- Nouns are classes or fields
- Verbs are methods
- In models, we just use properties rather than create fields (instance variables).

Example:

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
    public DateTime signUpDate {get; set;}
}
```

The AppUser model will get more added to it next term when we add authentication and authorization to our web sites.

#### OOP Relationships

- Inheritance: "is-a"
- Association (similar to aggregation): "uses-a" (or "has-a")
- Composition: "is-a-part-of"

#### Model Relationships

Let's refactor the Review model into two models: `Review` and `Book`.

What is the relationship between these two models?

- Can a Review exist without the Book?

- Can a Book exist without a Review?

  

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

Draw a UML diagram that shows the relationships between all three models.



## Writing controller methods

###HTTP GET methods

```c#
        public IActionResult Index()
        {
            return View();
        }
```

- May optionally include a query for data (as a parameter in the Index method.)

- Used for displaying a view with or without sending it data (as an argument in the View method).

- Passing a model to the view is optional. (This would be another way of sending it data.)

- Controller methods are GET methods by default.

  ```C#
  public IActionResult Review()
          {
              Review model = new Review();
              User reviewer = new User();
              model.Reviewer = reviewer;
              return View(model);
          }
  ```

  

### HTTP POST methods

- Will receive data from a view (usually a view containing an HTML form) passed to the method in one of two ways:

  - In a model object:

    ```c#
    [HttpPost]
    public IActionResult Review(Review model)
    {
        model.ReviewDate = DateTime.Now;
        return View(model);
    }
    ```

  - In parameters that match the HTML form field names:

    ```
    [HttpPost]
    public IActionResult Review(string bookTitle, string authorName,
            string reviewerName, string reviewText, string reviewDate)
    {
    		Review model = new Review(){BookTitle = bookTitle, 
    		     AuthorName = authorName, ReviewText = reviewText,
    		     Reviewer = new User(){Name = reviewerName},
    		     ReviewDate = DateTime.Now }
        return View(model);
    }
    ```

    

## Writing views

- Form views

  - This view would be invoked by an HttpGet method in the controller.
  - This view will send data to a HttpPost method in the controller.

  ```c#
  @model Review
  @{
      ViewData["Title"] = "Books";
  }
  
  <form method="post">
      <label asp-for="BookTitle">Title</label>
      <input asp-for="BookTitle" /><br />
  
      <label asp-for="AuthorName">Author</label>
      <input asp-for="AuthorName" /><br />
  
      <label asp-for="Reviewer.Name">Reviewer</label>
      <input asp-for="Reviewer.Name" /><br />
  
      <label asp-for="ReviewText">Review</label>
      <textarea asp-for="ReviewText"></textarea><br />
  
      <button type="submit">Submit</button>
  </form>
  ```

- Views with data models



## Reference

### Textbook

Ch. 2, "How to code a single-page MVC web app", *Murach’s ASP.NET Core MVC*, 1st Edition, by Mary Delamater and Joel Murach, Murach Books, 2020.

### Online

[Add a Model to an ASP.NET Core MVC App](https://lanecc.zoom.us/rec/share/eysvpQj6XMaobYbus6qz_0cvLLxkrHTkPfg3OBoM7G-EwiIhkyYCZiCBKpg3Dvkr.oqyMt8bs2AEArLPq)&mdash;Microsoft Tutorial




------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------