CS296N Web Development 2: ASP.NET

<h1>Formatting a Site with Bootstrap</h1>

**Topics by week** 

| Weekly Topics                           |                                          |
| --------------------------------------- | ---------------------------------------- |
| 1. Intro to Web Dev                     | 6. Unit Testing                          |
| 2. Intro to MVC & Deploying to Azure    | 7. Database & Entity Framework           |
| 3. Working with Data                    | 8. Unit Testing & the Repository Pattern |
| 4. <mark>Bootstrap</mark>               | 9. Linq and Seed Data                    |
| 5. Midterm Quiz & Term Project Proposal | 10. Debugging                            |

<h2>Contents</h2>

[TOC]

------

# Introduction



## Announcements, Q and A

- Any questions about the last lab assignment?


# Bootstrap Form classes

Form classes are used to format labels and controls on forms. These provide customized formatting for a more consistent rendering across browsers and devices. There are type attribute that should be used on all inputs (e.g., email for email address or number for numerical information) to take advantage of newer input controls like email verification, number selection, etc.

## Commonly Used Classes

These classes provide provides bootstrap's customized formatting which makes minor changes to the appearance of the elements.

- `form-label` The main formatting change is to put a margin at the bottom.
- `form-control` Changes the appearance of the border.
  - `form-control-lg` and `form-control-sm` control the size of text in an input control.
  - 

- `form-select`





# Example

Note: this example was written for .NET 3.1 and Bootstrap 4 and is somewhat out of date, but still relevant.

[Book Review Web App, Lab04 branch on GitHub](https://github.com/ProfBird/CS295N-Fall2020LabExample/tree/lab04)

Look at the input form in this view: BookReviews/BookReviews/Views/Book/Review.cshtml



# References

## Textbook

Ch. 3, "How to make a web app responsive with Bootstrap", *Murach’s ASP.NET Core MVC*, 2nd Edition, by Mary Delamater and Joel Murach, Murach Books, 2022.

## Online

[Bootstrap 5 Tutorial](https://www.w3schools.com/bootstrap5/index.php)&mdash;W3Schools.

[Bootstrap Web Site](http://getbootstrap.com)&mdash;Official site.



[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog), written in 2023 are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

