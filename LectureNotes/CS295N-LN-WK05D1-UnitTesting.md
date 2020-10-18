**CS295N Web Development 1: ASP.NET
**

Brian Bird

# Unit Testing

Weekly Topics:



| Weekly Topics                                 |                                               |
| --------------------------------------------- | --------------------------------------------- |
| 1. Intro to Web Dev                           | 6. Entity Framework / Deploying a DB to Azure |
| 2. Intro to MVC / Deploying to Azure          | 7. Debugging / *Veteran's Day holiday*        |
| 3. MVC Architectural patterns                 | 8. Controllers                                |
| 4. Bootstrap                                  | 9. Razor Views / *Thanksgiving holiday*       |
| 5. Midterm Quiz / **Unit testing with xUnit** | 10. Razor Views (continued)                   |



## **Contents**

[TOC]

## Introduction

- Review due dates on Moodle
- Answer questions about lab 5

### Main focus today

- Writing Unit Tests using xUnit
- Creating fake repositories for unit testing


## Review - Controller Action Methods


- Action Method return types we have seen so far:

- - String
  - ViewResult

- Data gets passed to an action method:

- - Via the method parameters

  - - Method parameters get arguments from HTTP requests (both Get and Post)

- Data gets sent to views

- - Via a model of the type that the view has as it's model property
  - Via the ViewBag



- 



## Unit Testing Overview 

We'll cover more details of unit testing later, but here are some basic concepts:

- MVC facilitates unit testing - this is one of the reasons to use MVC

- 
- 
- What to test?

- - Business logic (in models, or in separate classes)

  - - If Models just contain simple C# properties, they don't really need tests

  - Controller methods

  - - This is what usually makes the most sense to test

- Test using data from a real database? No!

- - Why?

  - - The database may not contain optimal data for doing certain tests. 
    - It’s not advisable to put test data into a production database
    - The data can change over time and cause tests to fail.
    - The tests could cause unwanted changes to the real data.

  - Solution - test against a "fake" repository

- xUnit

- - Used by the .NET Core team to test their own code.
  - Test runner integrated in Visual Studio
  - Note: Assert.Equal method uses the Equal method of .NET objects for comparison. Primitive .NET types and many classes in the .NET library have fully implemented this method. You only need to write a Compare class (as shown in the textbook) if you are using a class that doesn't already have a comparator implemented for the Equals method.

- Reference

- - Overview: [xunit.github.io](https://xunit.github.io)
  - Getting started with xUnit and Visual Studio: [Getting Started with xUnit.net](hhttps://xunit.net/docs/getting-started/netfx/visual-studio)

#### 

## Further Reading

[Testing Controller Logic in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing)



------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------