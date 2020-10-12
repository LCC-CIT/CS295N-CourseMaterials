# Lab 3 – Working with Data
 CS295N, Web Development 1: ASP.NET

**Contents**

[TOC]

## Part A: Textbook Tutorial Exercises

In *Murach's ASP.NET Core MVC*, complete exercise 2-2, "Build the Future Value app using the Empty template". 

You do not need to do exercise 2-1. 



## Part B: Adding data



### Site Maps

#### Group A

**Community Web Site**

Modify the Home/Contact page so that users can send messages to the other users.

Messages will contain:

- Name of sender
- Name of recipient
- Subject
- Body of the message
- Date sent

For now, all users will see all messages, even those addressed to someone else.



#### Group B

**Fan Site**

Modify the Home/Stories page so users can enter stories.

Stories will contain:

- Title of the story
- Topic
- Text of the story
- Name of the submitter
- Date submitted



#### Group C

**Informational Site**

Modify the Home / Forum so users can post comments.

Forum posts will contain:

- Page being commented on
- Rating of the page
- Text of the post
- Name of person posting
- Date posted

For now, all users will see all messages, even those addressed to someone else.

### Implementation Instructions

#### Models

- Decide what two models you will need.
- Decide the relationship between the models.
- Code the models.

#### Controllers

You should already have an existing HTTP GET method that displays the view that will contain the data entry form.

- Write an HTTP POST method that gets the information from the form, then displays a page containing all the message, story, or post just entered.

#### Views

- Add a data entry form to the message, story, or post view. Make the view strongly typed.
- Add a view that shows one message story, or post. Make the view strongly typed.



## Review and Submission

### PRs and Code Reviews

1. Send a PR (Pull Request) to your lab partner asking them to review your code. 

   After you have gotten a code review and revised your code as needed, you can merge it into the main branch, but keep the lab branch, don't delete it.

2. You should receive a PR from your lab partner and review their code using this [Code Review Guide](../CodeReviewGuide.html).

   On Moodle, in the "online text" field of the Code Review assignment, enter the URL of the pull request with the code review <u>you gave</u>.

### Final Submission to Moodle

1.  Upload a screen-shot of the web page from textbook exercise. Take of picture of it running in a browser with data entered and a calculations shown.
2.  Publish your web site from part B to Azure.
3.  In the "online text" for the Moodle assignment:
    - Paste a link to the branch of your GitHub repository for this lab.
    - Paste a link to your web site running on Azure.