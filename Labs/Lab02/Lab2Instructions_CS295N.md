# Lab 2 – Creating Web Site Structure
 CS295N, Web Development 1: ASP.NET

**Contents**

[TOC]

## Part 1: Textbook Tutorial Exercise

Complete Exercise 1-1 in *Murach's ASP.NET Core MVC*
(Use Visual Studio to run the Guitar Shop app.)

## Part 2: Skeletal Web Site

Add to the web site you crated in lab 1 by creating a "skeleton" (a set of nearly empty pages) for your site. A site map is shown below for each group's web site. The site map is shown in the form of an outline. The main bullet points represent top-level web pages, and sub-point bullets represent pages linked from the top-level pages. 

Each top level page requires it's own controller. Each sub-page will have a method in the controller.

These pages will all be place-holders. The only content will be:

- A title (shows up in the browser tab). 
- A heading.
- A sentence saying what the page is for.
- One or more links to other pages.

### Site Maps

#### Group A

**Community Web Site**

- **Home**: General information about the community and the purpose of the site.
  
    Has links to *About* and *[Your choice]* top-level pages and to the sub-pages below:
    
    -   **History**: a brief history of the community.
    -   **Messages**:  a page where messages from other members are displayed.
        -   **Message**:  a page that in the future will have an HTML form that users can use to send messages to the other users.
    
- **About**:  Information about you, the author of the site and moare about the community. 
  
    -   **Links**: Links to external sites related to the community.
    -   **FAQ**: Frequently Asked Questions.
    
- ***Your choice***:  you can make this be whatever you want it to be. Give it your own name.

#### Group B

**Fan Site**

- 
  **Home**: General information about the person (or group, or thing) and the purpose of the site. 
  
  Has links to *Sources* and *[Your choice]* top-level pages and to the sub-pages below.
  
  - **History**: A brief history of the person.
  - **Stories**: a page that in the future will have a forum that users can use for discussions.
  
- **Sources**: Where to find sources for stories and more info.
  
  Has links to the sub-pages below.
  
  - **FanSites**: links to other official and un-official fan sites.
  - **News**: links to news sites, blogs, etch.
  
- ***Your choice***: you can make this be whatever you want it to be. Give it your own name.

#### Group C

**Informational Site**

- **Home**: General information about the topic and the purpose of the site.
  
  Has links to *Blog* and [*Your choice*] top-level pages and to the sub-pages below.
  
  - **Overview**: a brief description of the topic.
  - **References**: Sources of information in print or online.
  
- **Blog**: A page where blog posts will appear.
  
  - Placeholder page for links to top posts.
  - About the author.
  
- ***Your choice***: You can make this be whatever you want it to be. Give it your own name.



### Implementation Instructions

#### Controllers

Write a controller class for each top-level page of the site. Write a method in the controller for each sub-page. Remember that the Home controller should have an index method, index methods are optional in other controllers.

#### Views

Each view can be mostly a place-holder for the information described above.
It should have links to any sub-pages and back to the home page.

#### Models

No models are needed yet. You will add those in a future lab assignment.



## Review and Submission

### PRs and Code Reviews

1. Send a PR (Pull Request) to your lab partner asking them to review your code. 

   After you have gotten a code review and revised your code as needed, you can merge it into the main branch, but keep the lab branch, don't delete it.

2. You should receive a PR from your lab partner and review their code using this [Code Review Guide](../CodeReviewGuide.html).

   On Moodle, in the "online text" field of the Code Review assignment, enter the URL of the pull request with the code review <u>you gave</u>.

### Final Submission to Moodle

1.  Upload a screen-shot of the textbook exercise.
2.  Publish your web site from part 2 to Azure.
3.  In the "online text" for the Moodle assignment:
    - Paste a link to the branch of your GitHub repository for this lab.
    - Paste a link to your web site running on Azure.



## Grading Criteria

This is the rubric I will use to grade your lab assignment:

[Lab2Rubric_CS295N](Lab2Rubric_CS295N.htm)