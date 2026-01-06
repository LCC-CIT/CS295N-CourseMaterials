<h1>Lab 6: Database and Entity Framework</h1>

 CS295N, Web Development 1: ASP.NET

**Contents**

[TOC]

## Part A: Textbook Tutorial Exercise

In *Murach's ASP.NET Core MVC*, complete exercise 4-1, "Create the Movie List app". 

Note: If you are using MySQL or SQLite rather than SQL Server, a few of the steps will be different:

- Step 3: you will need to install the correct NuGet package for the database provider for your database type.
- Step 10: Use the correct connection string for your database type.
- Steps 14 and 15: Use a database management program that works with your database, such as  MySQL Workbench or DB Browser for SQLite.

Take a screen-shot of the app running in your web browser at the end of the exercise. Put the screen-shot in a Word document and in that document, report one of the following:

A. I Followed all the steps shown in the book and successfully compiled and ran the program.

B. I Loaded the completed solution, experimented with the code, and ran the program.

C. I didn't do the exercise.



## Part B: Saving Data to a Database

### Add a Database to your project

#### Group A

**Community Web Site**

Refactor your code so that the messages entered by the user on the Home/Contact page are saved in a database.

#### Group B

**Fan Site**

Refactor your code so that the stories entered by the user on the Home/Story page are saved in a database.

#### Group C

**Informational Site**

Refactor your code so that the comments entered by the user on the Home/Forum page are saved in a database.



#### For all groups

- Modify your views so that:
  - The user's entry is no longer just echoed back to a view.
  -  All messages, stories, or comments are read from the database and displayed on the Contacts, Stories, or Forum page. (Not the same page with the HTML form for entering information.)
  
- Use either SQL Server or MySQL as the database type.
  - You should use the same database type on both your local development machine and on Azure. Use the same type that your lab partners are using.

- Add an initial migration.
  - Hint: include the database type in the name of the migration, for example: *InitialMySql*, or *InitialSqlServer*.

- Publish the site to Azure.
  - Set up either an  *Azure SQL Database* (compatible with SQL Server), or *Azure Database for MySQL* server on Azure.
    - For Azure SQL, you <u>only get one free database</u> with your Azure for Students account, and only the <u>Standard S0</u> service tier is free.
    
    - For Azure Database for MySQL, you can also set up a free server and you are allowed to create multiple free databases on it. For the databases to be free you must choose these settings on the server:
      - Workload type: *For development or hobby projects.*
      - Compute + Storage:  *Burstable B1ms* with a maximum of 32GB of storage.
      
      For complete instructions read: [How to set up a MySQL Database on Azure](https://lcc-cit.github.io/CS295N-CourseMaterials/Notes/AzureMySqlSetupGuide.html).
    
  - Create a database schema by either:
    - Running `dotnet ef database update` using the connection string for your database server on Azure.
    - Modifying your Visual Studio publish profile so that it applies the migrations when you publish the web app. (This only works on Visual Studio for Windows.)
    
  - Publish your web app to Azure.




## Review and Submission

### PRs and Code Reviews

1. Send a PR (Pull Request) to your lab partner asking them to review your code. 

   After you have gotten a code review and revised your code as needed, you can merge it into the main branch, but keep the lab branch, don't delete it.

2. You should receive a PR from your lab partner and review their code using this [Code Review Guide](../CodeReviewGuide.html).

   On Moodle, in the "online text" field of the Code Review assignment, enter the URL of the pull request with the code review <u>you gave</u>.

### Final Submission to Moodle

2.  <s>Publish your web site to Azure.</s> Not for fall 2024
3.  In the "online text" for the Moodle assignment:
    - Paste a link to the branch of your GitHub repository for this lab.
    - Paste a link to your web site running on Azure.