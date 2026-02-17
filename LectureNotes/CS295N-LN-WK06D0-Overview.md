<h1>Week 6 Overview for Winter 2026</h1>

**CS 295N, Web Dev 1: ASP.NET**

| Weekly Topics                       |                                                   |
| ----------------------------------- | ------------------------------------------------- |
| 1. Intro to web dev                 | <mark>6. EF and database</mark>                   |
| 2. Intro to MVC, deploying to Azure | 7. LINQ, seed data                                |
| 3. Managing data: forms and models  | 8. Input validation                               |
| 4. Unit testing                     | 9. Authentication & Authorization                 |
| 5. Midterm quiz, start term project | 10. Debugging, term Project, project presentation |
| 11. Final quiz                      |                                                   |



<h2>Contents</h2>

[TOC]

## Announcements

- Most of you did pretty well on the midterm. The average score was 85% !

- I caught up on grading Saturday; so you can check your overall grade for this class so far. 

  - Note that if there are assignments you hadn't submitted yet, you can still submit them.

  

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



## Due Dates

- Term project proposal: Thursday, 2/12
- Lab 5 beta version PR: Sunday, 2/15



## Discussion

- Any questions on the term project proposal?
- Any questions on lab 4 (quiz feature and unit testing)?  
  (This was due last week, but a few people are still working on it.)



## Overview of Week 6

This week you will:

- Finish a proposal for your term project.
- Add a database to your lab project.



---

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) These ASP.NET Core MVC course materials written by [Brian Bird](https://profbird.dev) in <time>2026</time>  are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

---

