# Lab 7: Unit Testing with Repositories
 CS295N, Web Development 1: ASP.NET

**Contents**

[TOC]

## Part A: Textbook Exercise

Do exercise 14-1 in the Textbook, "Add dependency Injection and some unit tests"

Take a screen-shot of the unit test runner, showing the passing tests. Put the screen-shot in a Word document and in that document, report one of the following:

A. I Followed all the steps shown in the book and successfully compiled and ran the program.

B. I Loaded the completed solution, experimented with the code, and ran the program.

C. I didn't do the exercise.

## Part B: Repositories and Unit Tests

The instructions are the same for groups A, B, and C.

Add repositories and unit tests to your web site.

1. Create a repository interface for the DbSet class that is based on your "top level" model.

   (For example, if I have a User class that is part of my Review class, then, for this lab assignment, I just need to create IReviewRepository.)
   
2. Create a "real" repository based on the interface above.

3. Replace the code in each of your controller methods that uses your DB context with code that uses the repository. This will require adding dependency injection for your repository.

4. Write a fake repository. You can put this in the main project or the test project.

5. Add unit tests for at least one of your controller methods that uses a repository.

   Choose a method that do something worth testing. These would be controller methods that actually does some kind of processing like:

   - Adding information to a model property (a date, a user, etc.)
   - Searching or sorting data it gets from the database.
   - Calculating some kind of result based on user data.
   
   Remember that you are testing what the controller method does, not what the fake repository does.



## Part C: Publish Your Site to Azure

Follow the instruction given in class to publish your web site to Azure.



## Review and Submission

### PRs and Code Reviews

1. Send a PR (Pull Request) to your lab partner asking them to review your code. 

   After you have gotten a code review and revised your code as needed, you can merge it into the main branch, but keep the lab branch, don't delete it.

2. You should receive a PR from your lab partner and review their code using this [Code Review Guide](../CodeReviewGuide.html).

   On Moodle, in the "online text" field of the Code Review assignment, enter the URL of the pull request with the code review <u>you gave</u>.

### Final Submission to Moodle

1.  Upload the word doc with the screen shot and report of what you did in the exercise.
2.  Publish your web site from part B to Azure.
3.  In the "online text" for the Moodle assignment:
    - Paste a link to the branch of your GitHub repository for this lab.
    - Paste a link to your web site running on Azure.