**[CS295N Web Development 1: ASP.NET](http://lcc-cit.github.io/CS295N-CourseMaterials/)**

# Intro to Web Dev

| Weekly Topics                                |                                               |
| -------------------------------------------- | --------------------------------------------- |
| 1. **Intro to Web Dev** / Deploying to Azure | 6. Entity Framework / Deploying a DB to Azure |
| 2. Intro to MVC                              | 7. Debugging / *Veteran's Day holiday*        |
| 3. MVC Architectural patterns                | 8. Controllers                                |
| 4. Bootstrap                                 | 9. Razor Views / *Thanksgiving holiday*       |
| 5. Midterm Quiz / Unit testing with xUnit    | 10. Razor Views (continued)                   |

## Contents

[TOC]

## Introduction to the course

- Introduce myself
- Take roll, ask about degree programs, favorite web sites, programming experience
- Announcements 



## Intro to Web Development

- Job market

  - \#1 job in the US: Software Developer
    (According to US News and World Report Survey, of [100 best jobs in America)
    ](https://money.usnews.com/careers/best-jobs/rankings)

    - 253,400 projected jobs from 2016 to 2026
    - Median Salary: $100,080
    - Web development is a big part of what most Software Developers do.

  - Web developer jobs, based on a survey of jobs listed on Dice.com in February, 2018

    - Web development jobs by language and framework (sorted by jobs nationwide)

    | **Language / Framework **       | **Oregon ** | **US ** |
    | ------------------------------- | ----------- | ------- |
    | Java / Spring                   | 19          | 3497    |
    | C# / ASP.NET                    | 26          | 2759    |
    | Python / Web services           | 40          | 2524    |
    | Java / J2EE (Apache Jakarta EE) | 10          | 1893    |
    | JavaScript / Node.js            | 41          | 1385    |
    | Ruby / Rails                    | 1           | 490     |
    | Python / Django                 | 3           | 369     |
    | PHP / Laravel                   | 1           | 134     |

- Differences between desktop and web development

  - Multiple languages and technologies in one app: HTML, CSS, JavaScript, C#, SQL
  - Multiple browsers types and browser compatibility
  - Multiple concurrent users
  - No direct access to the client file system
  - Statelessness of HTTP

- Development tools you will use in this class

  - Visual Studio
  - Visual Studio Code
  - Development server (on your local machine)
  - Web browsers



## Overview of MVC

- MVC

  - Not new, originated in 1978 with the Smalltalk project at Xerox PARC
  - Became popular with Ruby on Rails, 2005
  - Block diagram (arrows show direction of dependencies):
                 M
                ^  ^
               /    \
               V <— C 

  - Model: data
  - View: renders HTTP responses
  - Controller: responds to HTTP request

- Facilitates programming best practices

  - Minimize dependencies
  - Separation of concerns

  - Unit tests

- MVC Embraces the statelessness of HTTP

  - No false state implementation
  - No complicated page lifecycle (handling click events)
  - View gives you full control of HTML

## Demo

- Build the default VS web site
  - Identify the Models, Views, and Controllers
  - Identify dependencies
  - Identify HTML, CSS, and JS resource

## Class Procedures

- Discuss code reviews
- Discuss weekly cycle of assignments 
- Review due dates

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev) is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

