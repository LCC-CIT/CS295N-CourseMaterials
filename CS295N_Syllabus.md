<h1>Syllabus for Web Development 1: ASP.NET</h1>

<h2>CS295N, Winter 2026</h2>

|                   | Class Info                                                   |      |                   | Instructor Info                                              |
| ----------------- | ------------------------------------------------------------ | ---- | ----------------- | ------------------------------------------------------------ |
| **Course Number** | CS 295N                                                      |      | Instructor        | Brian Bird                                                   |
| **CRN**           | Hybrid (on campus) 32934<br />Online 32933                   |      | Email<br />Mobile | [birdb@lanecc.edu](mailto:birdb@lanecc.edu)<br />[‪(541) 525-0213‬](tel:5415250213) |
| Day, Time | T, Th, 10:00&ndash;11:50                                     |      | Office            | Building 19, Room 152<br /> or [Zoom meeting](https://lanecc.zoom.us/j/8982554800) |
| **Classroom**     | Building 19, Room 126<br />[Zoom meeting](https://lanecc.zoom.us/j/97321830534) |      | Office Hours | M, W 4:00–4:50<br />Tu, Th 2:00–2:50|




<h2>Table of Contents</h2>

[TOC]

## Course Description

This course provides an introduction to server-side programming in C# using the ASP.NET Core framework and the MVC design pattern. You will learn the concepts and skills necessary to solve web development problems in order to develop maintainable and extensible web applications. 

### Effort

Since this is a four-credit class, students will need to devote at least 12 hours per week to the class (many students will need to devote more).

- 4 hours for class participation.
- 2 hours for reading (an average of 35 pages per week).
- 6 hours for lab assignments.

### Learning Outcomes

To be able to design and code a web site that uses the ASP.NET Core MVC framework for a moderately complex web application.

### Teaching Methods

This hybrid course accommodates on-campus and online students through a blend of lectures, discussions, and hands-on labs. Online students can participate synchronously via Zoom or asynchronously by watching session recordings.

Students will work with lab partners to do code reviews and provide helpful feedback for improving each other’s code quality. Online students can collaborate with their lab partners asynchronously.

### Course Content

#### Technologies

- Git

- C# (advanced features)

- Unified Modeling Language (UML)

- ASP.NET Core MVC

- xUnit for unit testing

- Azure cloud service

- SQL Server and/or MySQL

- LINQ (Language INtegrated Query for C#)

- Entity Framework (Object Relational Manager for database operations)

  

#### Themes and Issues

- Web standards

- Design patterns

- Test Driven Development

- User Experience (UX)

- Object Oriented Design

- Ethics and privacy

  

#### Skills

- Develop ASP.NET Core web apps using server-side C#, HTML, CSS and JavaScript.

- Design data models that translate into SQL Server database tables for use by your web app.

- Write database queries using LINQ.

- Write Unit Tests for Test Driven Development.

- Debug web apps.

- Deploy web apps to a cloud service.

- Effectively use software development tools like Visual Studio.

- Use Git to manage your source code and do code reviews.

  

## Course Resources

### Textbook

There is no textbook required for this course. Instead, we will be using the documentation and tutorials provided by Microsoft on ASP.NET Core MVC. A great starting point can be found here: [Microsoft ASP.NET Core MVC Overview](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview).

#### Optional Book

*Murach’s ASP.NET Core MVC*, 2nd Edition, by Mary Delamater and Joel Murach (Murach Books, 2022) is an optional resource. While this is the latest edition, it is based on .NET 6, which is no longer the current Long Term Support (LTS) version of .NET. But, most of the fundamental concepts and much of the code presented are still highly relevant and applicable to developing with .NET 10.

### Required Software

The class examples are based on using the Windows operating system for development, but have also been tested on Mac OS and should also work on Linux. 

#### IDE and .NET Framework

We will be using [Visual Studio 2026, Community Edition](https://visualstudio.microsoft.com/community/), which is available as a free download. This is the most popular IDE for .NET development on Windows.

For Mac OS and Linux, the best IDE is [JetBrains Rider](https://www.jetbrains.com/rider/), which also runs on Windows and is available free to Students.

The version of the .NET framework we will be using is [.NET 10](https://dotnet.microsoft.com/en-us/download/dotnet/10.0). You will need to download the latest LTS release of the .NET framework SDK for your OS (Windows, Mac, or Linux).

#### Git

You will need to use Git for version control. Git itself is a command line program which you can [download from the Git Community web site](https://git-scm.com/downloads). You can use Git from the command line , or use a Git GUI client. There is a very good [Git client built into Visual Studio](https://learn.microsoft.com/en-us/visualstudio/version-control/git-with-visual-studio) and you can also download the free [GitHub Desktop](https://desktop.github.com/) app for working with Git.

###  Free and Discounted Software for Students

- [Azure Dev Tools for Teaching](https://signup.azure.com/studentverification?offerType=3) is a subscription-based offering, paid for by the LCC CIT department, providing access to professional development and design tools, software, and services from Microsoft. 

  **Note:** You need to have a [Microsoft account](https://account.microsoft.com/?refd=login.live.com) to access this page and sign up for this program. Microsoft has two kinds of accounts: *personal* and *work/school*. To sign up for this, use a <u>personal</u> account.
  
- [Microsoft Office 365](https://lanecc.helpjuice.com/student-faqs/microsoft-office-365-for-lcc-students-staff) LCC students and staff can get a free subscription to Office 365, which includes Microsoft Word, Excel, PowerPoint, Access, and more.

- [On The Hub](https://lanecc.onthehub.com/WebStore/ProductsByMajorVersionList.aspx?cmi_mnuMain=f189368a-f0a6-e811-8109-000d3af41938) has partnered with Microsoft, Adobe, IBM, Symantec, VMware and other software publishers to offer discounted and free software for students and faculty.

  #### Markdown Viewers and Editors

- Most software development documentation is written using [Markdown](https://daringfireball.net/projects/markdown/). GitHub uses Markdown for almost all its docs including readme files and PR comments. You can write and edit Markdown directly on GitHub's web pages, but you might also want a Markdown viewer and/or editor to work with Markdown offline. Here are some options:

  - [Visual Studio Markdown extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor): This is a full featured Markdown editor and viewer.
  - [Visual Studio Code](https://code.visualstudio.com/): VS Code has [built in Markdown editing features](https://code.visualstudio.com/Docs/languages/markdown) and there are a number of Markdown add-ons available as well.
  - [MarkText](https://github.com/marktext/marktext): A highly recommended, free and open-source Markdown editor for Windows, macOS, and Linux, known for its clean interface and real-time preview.
  - [Typora](https://typora.io/): A WYSIWYG (What You See Is What You Get) Markdown editor that runs on Windows, MacOS, and Linux. This might be one of the best MD editors, but it's not free, it's currently $14.95.


None of the software provided in these offers is required for this class, but you may want to take advantage of the free software.

### CIT Computer Lab and in-Person Tutoring

The CIT computerlab (Building 19, room 135) is equipped with computers and software for students taking classes in the CIT department. There are tutors available in the lab to help you with your lab work. There is a schedule posted on the large white board inside the lab which lists the tutors and the times they will be available.

### Online Tutoring

Tutoring is available online. You can drop into the [Lane Support Hub Zoom Room](https://lanecc.zoom.us/j/98549544816) and request a CIT tutor, or make an appointment with a CIT tutor via the scheduling page at [lanecc.mywconline.com](https://lanecc.mywconline.com/). More information is available on the [LCC Tutoring Services](https://www.lanecc.edu/tutor) web page.

### Web Resources

- [Moodle](http://classes.lanecc.edu) is the Learning Management System for this course.

- You will be deploying your web apps to the Microsoft Azure cloud. You can register for a free Azure subscription through [Azure for Students](https://azure.microsoft.com/en-us/free/students/).


## Assessment and Grading

Specific grading criteria will be applied to each of the labs, quizzes, and exams you will be working on in this class. Part of the lab involves a code review. Attendance is not graded.

| Assessment Activities   | Points Each | Total |
| ----------------------- | ----------- | ----- |
| Quizzes 1&ndash;8       | 10          | 80    |
| Labs 1&ndash;8          | 40          | 320   |
| Code Reviews 1&ndash;8  | 10          | 80    |
| Midterm and Final Exams | 100 and 200 | 300   |
| Term Project            | 220         | 220   |


Letter grades for the course will be determined by the following percentages:              

|      | -           |         | +       |
| ---- | ----------- | ------- | ------- |
| A    | 90&ndash;91 | 92 - 97 | 98-100  |
| B    | 80&ndash;81 | 82 - 87 | 88 - 89 |
| C    | 70&ndash;71 | 72 - 77 | 78 - 79 |
| D    | 60&ndash;61 | 62 - 67 | 68 - 69 |
| F    | Below 60    |         |         |

### Late Work

- The grade for assignments submitted after the due date will be reduced by 10%.
  - No late assignments may be submitted after the end of week 10.
  
- Quizzes and exams cannot be taken after the due date. Contact your instructor in advance if you know you will have a schedule conflict so you can reschedule the quiz.

- Exceptions will be made for illness or emergency situations.

### Weekly Learning Activities

You should complete each step in the learning activities by the day of the week shown below. Of course, it's always great to do these things even sooner!

| Monday                      | Tuesday                                                      | Wednesday              | Thursday                                                     | Saturday                                                     |
| --------------------------- | ------------------------------------------------------------ | ---------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ |
| Start the assigned reading. | Participate in class.<br />Submit a code review for your lab partner. | Take the reading quiz. | Participate in class.<br />Submit the production version of last week's lab. | Send a PR to your lab partner for the beta version of your lab. |

*This cycle will start on the second week of the term.*

### Academic Honesty

While students are encouraged to discuss labs and to use each other as resources, each student is responsible for his/her own work. In other words, you can help each other, but you can't copy any part of someone else's work. The end product must be each student's own individual work.

#### Use of AI

Generative AI tools such as Gemini, Claude or ChatGPT are useful resources and you are encouraged to use them to help you learn how to code, but not to do the coding for you unless a specific assignment has instructions that include using AI to assist with writing your code.

Any time AI is used as part of the coding process, you need to provide a comment or other documentation explaining what AI tools were used and how they were used.

### Attendance

Attendance is not graded but will be essential for successful completion of the class. Students who miss a class are responsible for obtaining the course content provided in class and mastering it. For students in an online class, watching the video recordings is equivalent to attending the class sessions.

#### No-Show Drop

LCC has a [no-show drop](https://www.lanecc.edu/esfs/noshow-drops) policy. You must come to class at least once during the first week or be automatically dropped.



## Accessibility and Campus Navigation

### Center for Accessible Resources

Lane Community College (LCC) is dedicated to providing inclusive learning environments. The [Center for Accessible Resources (CAR)](https://www.lanecc.edu/get-support/resource-centers/center-accessible-resources) coordinates all academic accommodations for students at LCC. If you anticipate or experience academic barriers due to a disability, to request assistance or accommodations, contact the Center for Accessible Resources 541-463-5150 or [accessibleresources@lanecc.edu](mailto:accessibleresources@lanecc.edu).

Please be aware that any accessible tables and chairs in this room should remain available for authorized students who find that standard classroom seating is not usable. 

### Campus Location and Maps

The LCC main campus is located at 4000 East 30th Ave. Eugene, Oregon 97405.

- [Bus service and free student bus pass](https://www.lanecc.edu/experience-lane/transportation-getting-around/lcc-bus-pass)

- [Interactive Map of the LCC Main Campus](https://map.concept3d.com/?id=780#!ct/80243,11008,10696,80244,80245?s/)

- [Map (floor plan) of Building 19](Images/Building19FloorPlan.pdf)

## Calendar and Schedule

### Academic Calendar

| **Winter Term 2026**                        |              |
| ------------------------------------------- | ------------ |
| Term begins                                 | 1/5, Monday  |
| Last day to drop and receive a refund       | 1/11, Sunday |
| Martin Luther King Jr. Day (college closed) | 1/19, Monday |
| Presidents' Day (college closed)            | 2/16, Monday |
| Last day for schedule changes               | 2/27, Friday |
| Finals Week                                 | 3/16–3/20    |

View [academic calendars](https://www.lanecc.edu/calendars/academic-calendar) on the LCC web site.

### Tentative Course Schedule

(May be subject to change)

| Week             | Topics                                                       | Lab Assignment                                               |
| ---------------- | ------------------------------------------------------------ | ------------------------------------------------------------ |
| **1**<br />1/5   | Intro to Web Dev<br />*Class starts Tuesday*                 | Lab 1<br />Create an empty MVC site                          |
| **2**<br />1/12  | Intro to MVC                                                 | Lab 2<br />Add pages and links to a site                     |
| **3**<br />1/19  | Working with Data                                            | Lab 3<br />Add models and data entry and publish to Azure    |
| **4**<br />1/26  | Entity Framework<br />Database Migrations<br />Deploying a DB to Azure | Lab 4<br />Add a DB to your site                             |
| **5**<br />2/2   | Midterm quiz                                                 | Term project proposal<br>Midterm quiz:<br />In the classroom on 2/4<br />In the testing center 2/4 through 2/6 (tentative dates) |
| **6**<br />2/9   | Unit testing with xUnit                                      | Lab 5<br />Add a quiz and unit tests to your site.           |
| 7<br />2/16      | Input Validation                                             | Lab 6<br />Add validation to your web site                   |
| **8**<br />2/23  | Repository Pattern<br />More Unit Testing                    | Lab 7                                                        |
| **9**<br />3/2   | Linq and Seed Data                                           | Lab 8                                                        |
| **10**<br />3/9  | Debugging<br />Final quiz                                    | Lab 9 (Extra Credit)<br />- Debugging practice<br />Final in classroom 3/11<br />Final in testing center 3/11&ndash;3/13 (tentative dates) |
| **11**<br />3/16 | Project presentations                                        | Term project                                                 |



[Go back to the top](#course-description)