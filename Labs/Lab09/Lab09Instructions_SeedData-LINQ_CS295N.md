# Lab 9: Seed Data and LINQ

## Objectives

Gain experience:

- Adding seed data to your web app.
- Writing LINQ queries.

 

## Requirements

#### Group A

**Community Web Site**

1. Add seed data for at least three messages, sent by at least two different users on at least two different dates.

2. At the top of the page that shows all messages, add a form that provides users a way to filter messages by:
   - Name of sender
   - Date sent

#### Group B

**Fan Site**

1. Add seed data for at least three stories, submitted by at least two different users on at least two different dates.
2. At the top of the page that shows all stories, add a form that provides users a way to filter stories by:
   - Name of submitter
   - Date submitted

#### Group C

**Informational Site**

1. Add seed data for at least three comments, posted by at least two different users on at least two different dates.
2. At the top of the page that shows all comments, add a form that provides users a way to filter comments by:
   - Name of person posting
   - Date posted

 

## Implementation

### Seed Data

The code to add seed data should be called from startup, as shown in the lecture notes. This is different from the way shown in the textbook. The reason to not do it the way shown in the textbook is that the seed data would only be added when the database is updated.

### LINQ

Put the code that executes the LINQ queries in a new controller method for the page that you are filtering. This will be an HTTP POST method since it will need to have search criteria passed to it from the form that you added to the messages, stories, or comments page. 



## Submission

### Code review

There is no code review required for this assignment.

### Publish to Azure and submit links to Moodle

1. Publish your web site to Azure.
2. In the "online text" for the Moodle assignment:

- Paste a link to the branch of your GitHub repository for this lab.
- Paste a link to your web site running on Azure.

****

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC lab instructions were written by [Brian Bird](https://birdsbits.blog), fall 2020 and are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

