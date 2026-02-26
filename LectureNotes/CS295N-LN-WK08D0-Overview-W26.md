<h1>Week 8 Overview for Winter 2026</h1>

**CS 295N, Web Dev 1: ASP.NET**

| Weekly Topics                       |                                                   |
| ----------------------------------- | ------------------------------------------------- |
| 1. Intro to web dev                 | 6. EF and database                                |
| 2. Intro to MVC, deploying to Azure | 7. LINQ, seed data                                |
| 3. Managing data: forms and models  | <mark>8. Input validation</mark>                  |
| 4. Unit testing                     | 9. Authentication & Authorization                 |
| 5. Midterm quiz, start term project | 10. Debugging, term Project, project presentation |
| 11. Final quiz                      |                                                   |



<h2>Contents</h2>

[TOC]

## Announcements

- **LCC Foundation Scholarships** 
  The LCC Foundation scholarship application is now open! Just one simple application connects LCC students to hundreds of scholarship opportunities available ONLY to them. Apply before the March 3rd deadline! This is for students who will be at LCC for the 2026-27 academic year.

  Resource: [More Information](https://out.smore.com/e/5xfb7/638W3H?__$u__) | Contact: [Kaisa Lightfoot - LCC Foundation](https://out.smore.com/e/5xfb7/y-lGQ7?__$u__)

- **Last week to withdraw or change grading options**.  
  This Friday, Feb. 27, is the last day to make schedule changes for this term. This includes dropping a course, withdrawing, or changing grading methods.

  NOTE: You should consult an [advisor](https://www.lanecc.edu/get-support/academic-support/academic-advising) and/or [financial aid](https://www.lanecc.edu/costs-admission/paying-college/financial-aid) representative before making these kinds of changes, especially withdrawing. These types of changes may have implications for academic progress and/or financial aid awards. This is not always the case, but it's best to be informed.




## Due Dates

- Lab 6 beta version PR: Sunday, 2/2
- Lab 6 code review: Tuesday, 2/24
- Lab 6 production version: Thursday, 2/26
- Validation Quiz: Friday, 2/27
- Lab 7 beta version PR: Sunday, 3/1



## Discussion

- Did you see my announcement on Discord that I figured out why we couldn't create MySQL database servers on Azure?
- Any questions about lab 6 on Seed data and LINQ queries (searching)?



## Learning Objectives for Week 8

### Input Validation with ASP.NET

This week you will:

- Distinguish between *client-side validation* for user experience and *server-side validation* for application security.
- Perform model validation using *data annotations* to enforce constraints on model properties.
- Configure views to display errors using *unobtrusive validation* and built-in *Validation Tag Helpers*.
- Manage controller logic by evaluating `ModelState.IsValid` and adding explicit validation errors to the *ModelState dictionary*.
- Synchronize *database schemas* with model constraints by executing Entity Framework *migrations*.



---

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) These ASP.NET Core MVC course materials written by [Brian Bird](https://profbird.dev) in <time>2026</time> are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

---

