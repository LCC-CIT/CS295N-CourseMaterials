# Lab 3 – Working with Data
 CS295N, Web Development 1: ASP.NET

**Contents**

[TOC]

## Part A: Textbook Tutorial Exercises

In *Murach's ASP.NET Core MVC*, complete exercise 2-2, "Build the Future Value app using the Empty template". 

*Note that this exercise uses the ViewBag to send data (the discount and total) to a view. This is usually not recommended, it is better to send a model to the view.*

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
- Message priority (an integer)
- Body of the message
- Date sent

Are there any other properties you think you might need or want? (Don't add more than one or two.)

For now, all users will see all messages, even those addressed to someone else.



#### Group B

**Fan Site**

Modify the Home/Stories page so users can enter stories.

Stories will contain:

- Title of the story
- Topic
- Year the story took place (an integer)
- Text of the story
- Name of the submitter
- Date submitted

Are there any other properties you think you might need or want? (Don't add more than one or two.)



#### Group C

**Informational Site**

Modify the Blog page so the site admin can make blog posts.

Blog posts will contain:
- Title
- Text of the post
- Name of person posting
- Date posted
- Rating

Are there any other properties you think you might need or want? (Don't add more than one or two.)

Do you want the posts to be identified as either comments or additional information?



### Implementation Instructions

#### Models

- Decide what two or three models you will need.
- Decide the relationship between the models.
- Code the models.

#### Views

- Add a new view containing a HTML form for entering a message, story, or forum post. Make the view strongly typed. Name it Message, Story, or Post
  - Add a link to the existing Message, Stories or Blog view to open the new view.

- Modify the existing Contact, Stories, or Blog view so that it can display data echoed back when the user submits information they entered in the form described above.

#### Controllers

- Write an HTTP GET method for the new HTML form view described in *Views* above.
- Write an HTTP POST method that receives the information from the new HTML form. This method should use the Redirect method to send the information back to the Contact, Stories, or Forum view (back to the controller method for that view.)

Note: You should already have an existing HTTP GET method in your HomeController that renders a Contact, Stories, or Blog view.



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



## Grading Criteria

[Grading rubric for lab 3](Lab3Rubric_CS295N.htm)
