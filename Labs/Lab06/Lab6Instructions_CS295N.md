# Lab 6: Database and Entity Framework
 CS295N, Web Development 1: ASP.NET

**Contents**

[TOC]

## Part A: Textbook Tutorial Exercise

In *Murach's ASP.NET Core MVC*, complete exercise 4-1, "Create the Movie List app". 

You will take a screen-shot of the app running in your web browser at the end of the exercise and on the document containing the screen-shot you will also report one of the following:

A. I Followed all the steps shown in the book and successfully compiled and ran the program.

B. I Loaded the completed solution, experimented with the code, and ran the program.

C. I didn't do the exercise.



## Part B: Saving Data to a Database

### Add a Database to your project

#### Group A

**Community Web Site**

Refactor your code so that the messages entered on the Home/Contact page are saved in a database.

#### Group B

**Fan Site**

Refactor your code so that the stories entered on the Home/Stories page are saved in a database.

#### Group C

**Informational Site**

Refactor your code so that the comments entered on the Home/Forum page are saved in a database.



#### For all groups

- Modify your data entry view so that:
  - The entry is shown on a different view.
  -  All messages, stories, or comments are displayed on that view.
- Use SQL Server as the database type.
- Store a user object as related data with the message, story, or comment object.
- Add migrations.
- Publish the site to Azure.



## Review and Submission

### PRs and Code Reviews

1. Send a PR (Pull Request) to your lab partner asking them to review your code. 

   After you have gotten a code review and revised your code as needed, you can merge it into the main branch, but keep the lab branch, don't delete it.

2. You should receive a PR from your lab partner and review their code using this [Code Review Guide](../CodeReviewGuide.html).

   On Moodle, in the "online text" field of the Code Review assignment, enter the URL of the pull request with the code review <u>you gave</u>.

### Final Submission to Moodle

2.  Publish your web site to Azure.
3.  In the "online text" for the Moodle assignment:
    - Paste a link to the branch of your GitHub repository for this lab.
    - Paste a link to your web site running on Azure.