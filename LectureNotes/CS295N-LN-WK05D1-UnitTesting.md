---
title: Unit Testing
description: How to write unit tests for buisiness logic and for controller methods.
keywords: test, test driven development, test first
material: Lecture Notes
generator: PanWriter
author: Brian Bird
---

**CS295N Web Development 1: ASP.NET**

<h1>Unit Testing</h1>

| Weekly Topics                           |                                          |
| --------------------------------------- | ---------------------------------------- |
| 1. Intro to Web Dev                     | 6. <mark>Unit Testing</mark>             |
| 2. Intro to MVC & Deploying to Azure    | 7. Database & Entity Framework           |
| 3. Working with Data                    | 8. Unit Testing & the Repository Pattern |
| 4. Bootstrap                            | 9. Linq and Seed Data                    |
| 5. Midterm Quiz & Term Project Proposal | 10. Debugging                            |

<h2>Contents</h2>

[TOC]

# Introduction

- Answer questions about the midterm.
- Answer questions about lab 4 and publishing to Azure.
- Describe where we're going: databases, unit testing with databases.



# Unit Testing Overview 

We'll cover more details of unit testing later, but here are some basic concepts:

- MVC facilitates unit testing - this is one of the reasons to use MVC

## What to test?

- Business logic (in models, or in separate classes)
  - If Models just contain simple C# properties, they don't really need tests

- Controller methods

  - This is what usually makes the most sense to test

- Test using data from a real database? No!

  - Why?
    - The database may not contain optimal data for doing certain tests. 
    - It’s not advisable to put test data into a production database.
    - The data can change over time and cause tests to fail.
    - The tests could cause unwanted changes to the real data.

  - Solution - test against a "fake" repository.

## Test Driven Development

- Test first. Writing unit tests before writing the methods they test gives you a clear idea of what the method should do and speeds up development by letting you test easily and often.
- Test after bug fixes.
- Test after adding new features.
- Regression testing.

## xUnit

Used by the .NET Core team to test their own code.

Test runner integrated in Visual Studio

Note: The `Assert.Equal` test method uses the base class `Equal` method of C# objects for comparison. Primitive .NET types and many classes in the .NET library have fully implemented this method. You only need to write a Compare class (as shown in the textbook) if you are using a class that doesn't already have a comparator implemented for the `Equals` method.



# How to Write a Unit Test

First, add a unit test project for C# to the Visual Studio Solution. Then add a reference to the web app project to the test project. Now you can start writing tests.

## Parts of a Unit Test

- Arrange  
  Create objects, initialize variables or constants and get everything ready so you can call the method that you are testing.
- Act  
  Call the method that you are testing.
- Assert  
  Check the return value and/or any other object affected by the method call.

## Example Tests

### A Business Logic Test

The unit test will be for the method below, from a class named AuthorQuiz, used to implement a quiz about authors:

```C#
public static class Quiz
{
    public const string RIGHT = "Right";
    public const string WRONG = "Wrong";
    public const string NAQ = "Not a question";

    public static string CheckAnswer(int questionNumber, string answer)
    {
        string correct;
        switch (questionNumber)
        {
            case 1:
                correct = answer == "Victor Hugo" ? RIGHT : WRONG;
                break;
            case 2:
                correct = answer == "1812" ? RIGHT : WRONG;
                break;
            case 3:
                correct = answer == "false" ? RIGHT : WRONG;
                break;
            default:
                correct = NAQ;
                break;
        }
        return correct;
    }
}
```

Here is a unit test. Note that this unit test is not complete, it only checks one of the cases in the switch statement.

```C#
[Fact]
public void CheckAnswerTest()
{
    // Arrange
    // We don't need to instantiate an object since we're testing a static method.

    // Act
    string resultRight = AuthorQuiz.CheckAnswer(2, "1812");
    string resultWrong = AuthorQuiz.CheckAnswer(2, "1810");
    string resultNaq = AuthorQuiz.CheckAnswer(0, "1812");

    // Assert
    Assert.Equal(Quiz.RIGHT, resultRight);
    Assert.Equal(Quiz.WRONG, resultWrong);
    Assert.Equal(Quiz.NAQ, resultNaq);
}
```

### A Controller Test

Assume we have the controller method below which gets information from a view containing an user entry form. This method then sends the info to the Index view as route values which become query parameters on an HTTP GET request. This is a simplified version of the corresponding method in the Book Review example.

```c#
 [HttpPost]
public IActionResult Review(Review model)
{
    return RedirectToAction("Index",
         // annonymous object with properties that equal HTTP route names
         new { bookTitle = model.BookTitle,
                reviewText = model.ReviewText } );
}
```

The unit test below that verifies that the correct information got put into each route value field.
Notes that this is a simplified version of the code in the Book Reviews example.

```c#
[Fact]
public void Review_PostTest()
{
    // arrange
    ReviewController controller = new ReviewController();
    const string TITLE = "The Title";
    const string REVIEW_TEXT = "Not a real book";
    Review model = new Review {BookTitle = TITLE, ReviewText = REVIEW_TEXT};

    // act
    var redirectResult = (RedirectToActionResult)controller.Review(model);
    var routeValueDict = (RouteValueDictionary)redirectResult.RouteValues;

    // assert
    // The dictionary keys are the route names from the method being tested.
    Assert.Equal(TITLE, routeValueDict["bookTitle"]);
    Assert.Equal(REVIEW_TEXT, routeValueDict["reviewText"]);
}
```



# Example

[Test project in the Book Review web site example](https://github.com/LCC-CIT/CS295N-Example-BookReviews/tree/5-UnitTests)



# Wrap-up

- Look at the lab assignment.
- Look at the term project requirements.
- Look at due dates on Moodle.



# Reference

- Official web page: [xUnit Documentation](https://xunit.net/#documentation)
- Using xUnit with Visual Studio: [Getting Started with xUnit.net](https://xunit.net/docs/getting-started/netfx/visual-studio)
- Microsoft Tutorial: [Testing Controller Logic in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing)

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog), 2018, revised 2022, are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

