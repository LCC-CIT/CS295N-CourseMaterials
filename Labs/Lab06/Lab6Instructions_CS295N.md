<h1>Lab 5: Database and Entity Framework</h1>

 **CS295N, Web Development 1: ASP.NET**

(This was lab 6 in previous years.)

**Contents**

[TOC]

## Part A: Tutorial Exercise

Follow the instructions in the tutorial for the two tutorials for the MVC Movie app.

Take a screen-shot of the app running in your web browser at the end of each exercise. Put the screen-shot in a Word document and in that document, report one of the following:

A. I Followed all the steps shown in the tutorials and successfully compiled and ran the program.

B. I Loaded the completed solution, set breakpoints, experimented with the code, and ran the program.

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

- Use either <s>SQL Server or</s> MySQL as the database type.
  - You should use the same database type on both your local development machine and on Azure. Use the same type that your lab partners are using.

- Use Visual Studio *User Secrets* to store your database credentials.

- Add an initial migration.
  - Hint: include the database type in the name of the migration, for example: *InitialMySql*, or *InitialSqlServer*.

- Publish the site to Azure.
  - Set up <s>either an *Azure SQL Database* (compatible with SQL Server), or</s> *Azure Database for MySQL* server on Azure.
    - For Azure SQL, you <u>only get one free database</u> with your Azure for Students account, and only the <u>Standard S0</u> service tier is free. **Only getting one free database is the main reason we are not using SQL Server**
    
    - With Azure Database for MySQL, you can set up <u>one free server</u> but you are <u>allowed to create multiple free databases</u> on it. For the databases to be free you must choose these settings on the server:
      - Workload type: *For development or hobby projects.*
      - Compute + Storage:  *Burstable B1ms* with a maximum of 32GB of storage.
      
      For complete instructions read: [How to set up a MySQL Database on Azure](https://lcc-cit.github.io/CS295N-CourseMaterials/Notes/AzureMySqlSetupGuide.html).
    
  - Create a database schema by either:
    - Running `dotnet ef database update` using the connection string for your database server on Azure.
    - Modifying your Visual Studio publish profile so that it applies the migrations when you publish the web app. (This only works on Visual Studio for Windows.)
    
  - <s>Publish your web app to Azure.</s>




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
    - <s>Paste a link to your web site running on Azure.</s>