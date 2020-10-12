**CS295N Web Development 1: ASP.NET**

| Weekly Topics                                  |                                               |
| ---------------------------------------------- | --------------------------------------------- |
| 1. Intro to Web Dev                            | 6. Entity Framework / Deploying a DB to Azure |
| 2. Intro to MVC / Code reviews via Git PR      | 7. Debugging / *Veteran's Day holiday*        |
| 3. **Working with data**  / Deploying to Azure | 8. Controllers                                |
| 4. Bootstrap                                   | 9. Razor Views / *Thanksgiving holiday*       |
| 5. Midterm Quiz / Unit testing with xUnit      | 10. Razor Views (continued)                   |

**Contents**

[TOC]

## Introduction

- Any questions about lab 2?
- Review the ch. 2 quiz.
- This week, on Thursday, we will publish to Azure.

## Overview

This week you will learn to work with data in all three parts of your MVC web site:

- Model: holds data being sent between a controller and a view.
- Controller: responds to HTTP requests and moves data between views using a model:
  - HTTP GET: a controller method will receive a request either with or without a query for data:
    - without a query&mdash;just a view will be returned.
    - with a query&mdash;a model with the requested data will be sent to the view and the view will be returned.
  - HTTP POST: a controller method will receive a request that contains data to be put into a model (and later it will also be put into a database).
- View: gets or displays data.

## Defining a model

### Identifying model classes and properties

#### OOP Relationships

- Inheritance
- Association
- Composition

## Writing Controller methods

- HTTP GET methods
- HTTP POST methods

## Writing views

- Form views
- Views with data models












------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog/) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------