# Lab 7: Unit Testing with Repositories
 CS295N, Web Development 1: ASP.NET

**Contents**

[TOC]

## Part A

Do exercise 14-1 in the Textbook, "Add dependency Injection and some unit tests"

## Part B

Add repositories and unit tests to your web site

1. Create a repository interface for each of your DbSet classes.
2. Create a "real" repository for each DbSet
3. Replace the code in your controller methods that uses your DB context with code that uses the repositories. This will require adding dependency injection for your repositories.
4. In your test project, write a fake repository
5. Add unit tests to test your controller methods.



## Part C: Publish Your Site to Azure

Follow the instruction given in class to publish your web site to Azure.



## Review and Submission

### PRs and Code Reviews

1. Send a PR (Pull Request) to your lab partner asking them to review your code. 

   After you have gotten a code review and revised your code as needed, you can merge it into the main branch, but keep the lab branch, don't delete it.

2. You should receive a PR from your lab partner and review their code using this [Code Review Guide](../CodeReviewGuide.html).

   On Moodle, in the "online text" field of the Code Review assignment, enter the URL of the pull request with the code review <u>you gave</u>.

### Final Submission to Moodle

1.  Upload a screen-shot of the textbook exercise. Take of screen-shot of the unit test runner, showing the passing tests.
2.  Publish your web site from part B to Azure.
3.  In the "online text" for the Moodle assignment:
    - Paste a link to the branch of your GitHub repository for this lab.
    - Paste a link to your web site running on Azure.