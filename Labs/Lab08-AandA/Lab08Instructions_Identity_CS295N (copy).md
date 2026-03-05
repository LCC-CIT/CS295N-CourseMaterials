**CS 295N Web Development 1: ASP.NET**

<h1>Lab 8: Authentication & Authorization with Identity</h1>

<h2>Contents</h2>

[TOC]

## Objectives

- Learn how to authenticate a user.
- Learn how to authorize user access to different sections of a web app based on user roles.

## Instructions

You will add all the same features to your web site that your instructor added to the example web site.

### Authentication

Add Authentication code to your lab web site for each of these features:

- Registration
- Login
- Logout
- Use the currently logged in user in any place where a user previously needed to enter their name.

### Authorization

Add Authorization code to your lab web site for each of these features:

- Add the code needed to support authorization (inject `UserManager` and `RoleManager` objects into the appropriate controllers, etc.)
- Add a page for user and role management. 
  The page will have these features at a minimum:
  - Delete user
  - Add to Admin
  - Remove from Admin
  - Delete role
- Restrict some parts of the web site:
  - Only logged in users can do operations that store information in the database.
  - Only admin users can access the admin pages.

- Seed the database with a user who is in the Admin. In addition, be sure to add or change the appropriate code in the `Startup` and `Program` classes.


- Add a link for the admin page to the navigation menu that only appears when a user in the Admin role is logged in.



## Submission

### Code review

### PRs and Code Reviews

1. Send a PR (Pull Request) to your lab partner asking them to review your code. 

   After you have gotten a code review and revised your code as needed, you can merge it into the main branch, but keep the lab branch, don't delete it.

2. You should receive a PR from your lab partner and review their code using this [Code Review Guide](../CodeReviewGuide.html).

   On Moodle, in the "online text" field of the Code Review assignment, enter the URL of the pull request with the code review <u>you gave</u>.

### Publish to Azure and submit links to Moodle

1. Publish your web site to Azure.
2. In the "online text" for the Moodle assignment:

- Paste a link to the branch of your GitHub repository for this lab.
- Paste a link to your web site running on Azure.



****

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC lab instructions were written by [Brian Bird](https://profbird.dev), winter <time>2026</time> are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

