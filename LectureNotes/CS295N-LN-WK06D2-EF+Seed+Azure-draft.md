---

title: Using EF
description: How to send data from controller methods to views and vice-versa
keywords: controller, view, model
material: Lecture Notes
generator: PanWriter
author: Brian Bird
---


**CS295N Web Development 1: ASP.NET**

<h1>Sending Data To and From Views</h1>

<h2>Contents</h2>

[TOC]

# Announcements and Discussion

Any questions?

# Sending Data from a Controller to a View

## Sending a Data Directly to a View

- Can be a model class, can be another type

- Using the view method

- Using ViewBag or ViewData

- view method with view parameter  
  `return View("Index", model);`

  ## Sending Data to another Controller Method

- Using the redirectToAction method

- Using a route paramter

# Sending Data from a View to a Controller

## Using a Model

asdf

## Using form fields



##

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
- MS EF Core Tutorial: [Loading Related Data](https://docs.microsoft.com/en-us/ef/core/querying/related-data)
- Microsoft Tutorial: [Publish an ASP.NET Core app to Azure with Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-6.0)



------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) These ASP.NET Core MVC Lecture Notes written by [Brian Bird](https://profbird.dev) in 2023,  are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

