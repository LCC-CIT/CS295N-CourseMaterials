# Lab 4: Unit Testing with xUnit 
 CS295N, Web Development 1: ASP.NET

**Contents**

[TOC]

## Unit Testing a Quiz Page

You will add a quiz page to your web site using *test driven development*.

Below, are the steps to add a quiz to your site.

## Quiz Class

Write a class that provides:

- Provision for managing and storing questions and answers
- A method to check user's answers to see if they are correct.  
  Initially this will just be a stub method.

### Unit Tests

1. Create two unit tests for the stub check method above:
   - A test that verifies that wrong answers are identified.
   - A test that verifies that right answers are identified.

2. Write the body of the check method in the quiz class&mdash;using the unit tests to verify it as you add code.

### Model

Note: This is technically what is called a *view model*, but we won't talk about the distinction between *domain models* (models that are associated with a database) and view models (models that just move data from controller to view or vice-versa) until after you have added a database to your web app.

Create a *model* class that can contain:

- Properties for:
  - A list of questions
  - Users' answers.
  - Responses showing whether answers are right or wrong.

### Controller methods

Write HTTP Get and HTTP Post controller methods for your quiz.

## View

Write a view for the quiz and test it by hand.



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