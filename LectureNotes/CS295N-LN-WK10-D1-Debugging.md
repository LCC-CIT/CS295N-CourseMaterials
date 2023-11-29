**CS295N Web Development 1: ASP.NET** 

<h1>Seed Data</h1>



| Weekly Topics                           |                                          |
| --------------------------------------- | ---------------------------------------- |
| 1. Intro to Web Dev                     | 6. Unit Testing                          |
| 2. Intro to MVC & Deploying to Azure    | 7. Database & Entity Framework           |
| 3. Working with Data                    | 8. Unit Testing & The Repository Pattern |
| 4. Bootstrap                            | 9. Linq & Seed Data                      |
| 5. Midterm Quiz & Term Project Proposal | <mark>10. Debugging</mark>               |



 **Contents**

[TOC]

## Announcements  

**For 11/27/23**


- Upcoming due dates:

  - Term project  
    The dates for the beta version and code review are flexible, but make arrangements with your lab partners if you want to change these dates.

    - Send a PR for the beta version: Tuesday, 11/28

    - Submit a link to a code review on a PR: Thursday, 11/30 

    - Presentation to the class: Monday, 12/4

    - Submit links to the production version: Monday, 12/4

  - Labs

    - Lab 8 (Seed data and Line) Code review: Tuesday, 11/28
    
    - Lab 8 Production version: 11/30
    
    - Lab 9 (Debugging) is optional, extra credit: 12/4
    
  - Final Quiz: online Monday 12/4 through Wednesday 12/6  
    If anyone wants to take the quiz on campus, in the classroom, I'll open the classroom on Wednesday at class time, 10:00am.



## Introduction

You've already been debugging using these techniques:

- Running in debug mode in Visual Studio:
  - Setting breakpoints in Visual Studio to:
    - discover flow of execution
    -  examine the values of variables by hovering and using local and watch windows.
    - Try out code using the immediate window.
  - Stopping on exceptions and viewing the Exception Helper. This happens automatically.
- Internal Server Error page. (This is not the same as the Error page in the shared view folder.)
- Unit tests:
  - Run existing unit tests.
  - Add unit tests for suspicous methods.
- Eliminating suspicous code:
  - Temporarily comment out code that you think might be causing a run-time error.
  - Disable or replace method calls to code you think might be causing a run-time error.
- Looking at URLs in the browser to see which controller methods a link or redirect are going to.
- View the source code in the browser to see how ASP.NET has rendered a razor view.
- Check for HTML, CSS, or JavaScript errors in the browser console.
- Checking the database schema and data using:
  -  MySQL Workbench for MySQL databases.
  - Server Explorer in Visual Studio for SQL Server.
- Swapping connection strings to try to narrow down the source of database problems.
- Looking at log files on Azure.

Overall concept of troubleshooting: "Divide and conquor", meaning use a systematic process of elimination to narrow down the possible causes of failure until you've found the problem.

## Additional Debugging Techniques

These are things we haven't talked talked about yet.

- Viewing network traffic in the browser's developer tools.
- Visual Studio tracepoints.
- Error logging and the Error page added by Visual Studio.
- Setting development mode on Azure
  - Change the environment variable.
  - Requires changing the connection string in appsettings.development.json for the deployed site.

## References

- *Murach's ASP.NET Core MVC*, Delamater and Murach, 2022,

  Ch. 5  – "How to manually test and debug an ASP.NET Core web app"

- [Debugger Documentation for Visual Studio 2022 for Windows](https://learn.microsoft.com/en-us/visualstudio/debugger/?view=vs-2022), Microsoft.

  - [Debug ASP.NET Core with the Visual Studio debugger](https://learn.microsoft.com/en-us/visualstudio/debugger/quickstart-debug-aspnet?view=vs-2022), Microsoft, 2023

  - [Debug live ASP.NET Azure apps using the Snapshot Debugger](https://learn.microsoft.com/en-us/visualstudio/debugger/debug-live-azure-applications?view=vs-2022), Microsoft, 2022.


------

[![Creative Commons License](https://i.creativecommons.org/l/by-sa/4.0/88x31.png)](http://creativecommons.org/licenses/by-sa/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev), written 2023, is licensed under a [Creative Commons Attribution-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-sa/4.0/). 

------