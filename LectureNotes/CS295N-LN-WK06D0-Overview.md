<h1>Week 6 Overview for Winter 2026</h1>

**CS 295N, Web Dev 1: ASP.NET**

| Weekly Topics                        |                                 |
| ------------------------------------ | ------------------------------- |
| 1. Intro to Web Dev                  | <mark>6. EF and Database</mark> |
| 2. Intro to MVC / Deploying to Azure | 7. Input Validation             |
| 3. Managing data: forms and models   | 8. Controllers                  |
| 4. Unit Testing                      | 9. Razor Views                  |
| 5. Midterm Quiz / Start term project | 10. Term Project Presentation   |
|                                      | 11. Final                       |

[TOC]

## Announcements

- None yet.

## Review of Unit Testing

- Improvements to the All About Pigeons example in the QuizController class:

  - Initialized the `Question` and `Answer` properties with empty Dictioinary objects: `public Dictionary<int, String> Questions { get; } = new();`

  - Fixed an issue that could have become a bug later in the CheckQuizAnswers method: 
    `foreach (var question in` **`model.Questions) `**  

    I changed the code so it loops on `model.Questions` instead of `Questions` which are the temporary hard-coded questions in the controller.

- What should unit tests be testing?

  - Functionality (logic) of an individual method.

  - Not the data (in this case the hard-coded questions).  
    Look at some examples.

    


## Overview of Week 6

This week you will:

- Add a database to your project
- Finish a proposal for your term project.



## Due Dates

- Term project proposal: Thursday, 2/12
- Lab 5 beta version PR: Sunday, 2/15

