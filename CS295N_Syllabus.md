<h1>Syllabus for Web Development 1: ASP.NET</h1>

<h2>CS295N, Fall 2024</h2>

|           | Class Info                                                   |      |              | Instructor Info                                              |
| --------- | ------------------------------------------------------------ | ---- | ------------ | ------------------------------------------------------------ |
| CRN       | Hybrid (on campus) 20934<br />Online 21466                   |      | Instructor   | Brian Bird                                                   |
| Credits   | 4                                                            |      | Email        | birdb@lanecc.edu                                             |
| Day, Time | M, W, 10:00&ndash;11:50                                      |      | Office       | Building 19, Room 152                                        |
| Classroom | Building 19, Room 128<br />[Zoom meeting](https://lanecc.zoom.us/j/95729160529) |      | Office Hours | T&mdash;Th  4:00&ndash;4:50<br />[Zoom meeting](https://lanecc.zoom.us/j/94514229670) |




<h2>Table of Contents</h2>

[TOC]

# Course Description

This course provides an introduction to server-side programming in C# using the ASP.NET Core framework and the MVC design pattern. You will learn the concepts and skills necessary to solve web development problems in order to develop maintainable and extensible web applications. 

## Effort

Since this is a four-credit class, students will need to devote at least 12 hours per week to the class (many students will need to devote more).

- 4 hours for class participation.
- 2 hours for reading (an average of 35 pages per week).
- 6 hours for lab assignments.

## Learning Outcome

To be able to design and code a web site that uses the ASP.NET Core MVC framework for a moderately complex web application.

## Course Content

### Technologies

- Git

- C# (advanced features)

- Unified Modeling Language (UML)

- ASP.NET Core MVC

- xUnit for unit testing

- Azure cloud service

- SQL Server and/or MySQL

- LINQ (Language INtegrated Query for C#)

- Entity Framework (Object Relational Manager for database operations)

  

### Themes and Issues

- Web standards

- Design patterns

- Test Driven Development

- User Experience (UX)

- Object Oriented Design

- Ethics and privacy

  

### Skills

- Develop ASP.NET Core web apps using server-side C#, HTML, CSS and JavaScript.

- Design data models that translate into SQL Server database tables for use by your web app.

- Write database queries using LINQ.

- Write Unit Tests for Test Driven Development.

- Debug web apps.

- Deploy web apps to a cloud service.

- Effectively use software development tools like Visual Studio.

- Use Git to manage your source code and do code reviews.

  

# Course Resources

## Required Textbook   

*Murach’s ASP.NET Core MVC*, 2nd Edition, by Mary Delamater and Joel Murach, Murach Books, 2022. ISBN 978-1-943873-02-9. You can purchase the textbook from the [Titan Store](https://www.bkstr.com/laneccstore/home) or from the publisher, [Murach Books](https://www.murach.com/shop-books/web-development-books/murach-s-asp-net-core-mvc-detail). 

[Free chapters and code](https://www.murach.com/shop/murach-s-asp-net-core-mvc-2nd-edition-detail)

The first two chapters of the book and the source code for the sample programs and exercises in the text are also available for download on the [publisher's web site](https://www.murach.com/shop-books/web-development-books/murach-s-asp-net-core-mvc-detail), under the tab "Free Downloads".

## Required Software

The class examples and the textbook are based on using the Windows operating system for development, but you may alternatively use Mac OS or Linux. 

### IDE and .NET Framework

We will be using [Visual Studio 2022, Community Edition](https://visualstudio.microsoft.com/vs/community/), which is available as a free download. This is the most popular IDE for .NET development on Windows.

For Mac OS and Linux, the best IDE is [JetBrains Rider](https://www.jetbrains.com/rider/), which also runs on Windows and is available free to Students.

The version of the .NET framework we will be using is [.NET Core 6.0](https://dotnet.microsoft.com/download/dotnet-core/6.0). You will need to download the latest release of this version of the .NET framework SDK for your OS (Windows, Mac, or Linux).

### Git

You will need to use Git for version control. Git itself is a command line program which you can [download from the Git Community web site](https://git-scm.com/downloads). You can use Git from the command line , or use a Git GUI client. There is a very good [Git client built into Visual Studio](https://learn.microsoft.com/en-us/visualstudio/version-control/git-with-visual-studio?view=vs-2022) and you can also downoad the free [GitHub Desktop](https://desktop.github.com/) app for working with Git.

##  Free and Discounted Software for Students

- [Azure Dev Tools for Teaching](https://signup.azure.com/studentverification?offerType=3) (previously known as Microsoft Imagine Premium) is a subscription-based offering, paid for by the LCC CIT department, providing access to professional development and design tools, software, and services from Microsoft. 

  **Note:** You need to have a [Microsoft account](https://account.microsoft.com/?refd=login.live.com) to access this page and sign up for this program. Microsoft has two kinds of accounts: *personal* and *work/school*. To sign up for this, use a <u>personal</u> account.
- [Microsoft Office 365](https://lanecc.helpjuice.com/student-faqs/microsoft-office-365-for-lcc-students-staff) LCC students and staff can get a free subscription to Office 365, which includes Microsoft Word, Excel, PowerPoint, Access, and more.
- [On The Hub](https://lanecc.onthehub.com/WebStore/ProductsByMajorVersionList.aspx?cmi_mnuMain=f189368a-f0a6-e811-8109-000d3af41938) has partnered with Microsoft, Adobe, IBM, Symantec, VMware and other software publishers to offer discounted and free software for students and faculty.
- <u>Markdown Viewers and Editors</u>: Most software development documentation is written using [Markdown](https://daringfireball.net/projects/markdown/). GitHub uses Markdown for almost all it's docs including readme files and PR comments. You can write and edit Markdown directly on GitHub's web pages, but you might also want a Markdown viewer and/or editor to work with Markdown offline. Here are some options:

  - [Visual Studio Markdown extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor): This is a full featured Markdown editor and viewer.
  - [Visual Studio Code](https://code.visualstudio.com/): VS Code has [built in Markdown editing features](https://code.visualstudio.com/Docs/languages/markdown) and there are a number of Markdown add-ons available as well.
  - [Typora](https://typora.io/): Not free ($14.99), but probably the best Markdown editor I've ever used. Available for Windows, MacOS, and LInux.
  - [PanWriter](https://panwriter.com/): A free, bare-bones editor and viewer for Windows, MacOS, and Linux.
  - [Markdown Viewer for Firefox](https://addons.mozilla.org/en-US/firefox/addon/markdown-viewer-chrome/): In addition to this, there are other markdown viewer add-ons available for Firefox as well as all other browsers.


None of the software provided in these offers is required for this class, but you may want to take advantage of the free software.

## CIT Computer Lab and in-Person Tutoring

The CIT computerlab (Building 19, room 135) is equipped with computers and software for students taking classes in the CIT department. There are tutors available in the lab to help you with your lab work. There is a schedule posted on the large white board inside the lab which lists the tutors and the times they will be available.

## Online Tutoring

The in-person computer lab and tutoring center is temporarily closed due to COVID-19, but tutoring is still available online. You can drop into the [Lane Support Hub Zoom Room](https://lanecc.zoom.us/j/98549544816) and request a CIT tutor, or make an appointment with a CIT tutor via the scheduling page at [lanecc.mywconline.com](https://lanecc.mywconline.com/). More information is available on the [LCC Tutoring Services](https://www.lanecc.edu/tutor) web page.

## Web Resources

- [Moodle](http://classes.lanecc.edu) is the Learning Management System for this course.

- You will be deploying your web apps to the Microsoft Azure cloud. You can register for a free Azure subscription through [Azure for Students](https://azure.microsoft.com/en-us/free/students/).

  

# Assessment and Grading

Specific grading criteria will be applied to each of the labs, quizzes, and exams you will be working on in this class. Part of the lab involves a code review. Attendance is not graded.

| Assessment Activities   | % each | % total |
| ----------------------- | ------ | ------- |
| Quizzes 1&ndash;8       | 1      | 8       |
| Labs 1&ndash;8          | 4      | 32      |
| Code Reviews 1&ndash;8  | 1      | 8       |
| Midterm and Final Exams | 10     | 20      |
| Term Project            | 32     | 32      |


Letter grades for the course will be determined by the following percentages:              

|      | -           |         | +       |
| ---- | ----------- | ------- | ------- |
| A    | 90&ndash;91 | 92 - 97 | 98-100  |
| B    | 80&ndash;81 | 82 - 87 | 88 - 89 |
| C    | 70&ndash;71 | 72 - 77 | 78 - 79 |
| D    | 60&ndash;61 | 62 - 67 | 68 - 69 |
| F    | Below 60    |         |         |

## Late Work

- The grade for assignments submitted after the due date will be reduced by 10%.
  - No late lab work will be accepted after the Wednesday of finals week (week 11).
  
- Quizzes and exams cannot be taken after the due date. Contact your instructor in advance if you know you will have a schedule conflict so you can reschedul the quiz.

- Exceptions will be made for illness or emergency situations.

## Weekly Learning Activities

You should complete each step in the learning activities by the day of the week shown below. Of course, it's always great to do these things even sooner!

| Sunday                                                       | Monday                | Tuesday                                    | Wednesday                                                    | Thursday                                                     |
| ------------------------------------------------------------ | --------------------- | ------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| -Start the assigned reading.<br />- Send a PR to your lab partner. | Participate in class. | Submit a code review for your lab partner. | - Take the reading quiz <u>before class</u><br />- Participate in class. | Submit the production version of last week's lab assignment. |

*This cycle will start on the secoond week of the term.*

## Academic Honesty

While students are encouraged to discuss labs and to use each other as resources, each student is responsible for his/her own work. In other words, you can help each other, but you can't copy any part of someone else's work. The end product must be each student's own individual work.

## Attendance

Attendance is not graded but will be essential for successful completion of the class. Students who miss a class are responsible for obtaining the course content provided in class and mastering it. For students in an online class, watching the video recordings is equivalent to attending the class sessions.

### No-Show Drop

LCC has a [no-show drop](https://www.lanecc.edu/esfs/noshow-drops) policy. You must come to class at least once during the first week or be automatically dropped.



# Accessibility and Campus Navigation

## Center for Accessible Resources

Lane Community College (LCC) is dedicated to providing inclusive learning environments. The Center for Accessible Resources (CAR) coordinates all academic accommodations for students at LCC. If you anticipate or experience academic barriers due to a disability, to request assistance or accommodations, contact the Center for Accessible Resources.

**In-Person Services:** Monday and Thursday, 9:00am - 12:30 and 1:30pm - 3:00pm.
**Location:** Main Campus, Building 19, Room 263A

**Remote Support through Support Hub:** Monday - Thursday 9:00am&ndash;12:30 and 1:30pm&ndash;3:00pm. 
Enter the Support Hub by going to [lanecc.edu/hub](https://www.lanecc.edu/hub). Wait for a Lane staff to let you into the Zoom.

**Phone:** Voice, (541) 463-5150 TTY: 711, Monday&mdash;Friday 9:00am&ndash;12:30pm and 1:30pm&ndash;3:00pm.
**Email:** AccessibleResources@lanecc.edu

For upcoming closures, please visit the [Center for Accessible Resources webpage ](https://www.lanecc.edu/disability)

 # Campus Location and Maps

- [Bus service and free student bus pass](https://www.lanecc.edu/experience-lane/transportation-getting-around/lcc-bus-pass)

- [Interactive Map of the LCC Main Campus](https://map.concept3d.com/?id=780#!ct/80243,11008,10696,80244,80245?s/)

- [Map (floor plan) of Building 19](Images/Building19FloorPlan.pdf)

  

## Academic Calendar for Fall Term 2024

| Event                                                        | Date             |
| ------------------------------------------------------------ | ---------------- |
| Fall term classes begin                                      | 9/30 Monday      |
| Last day to receive refund                                   | 10/7 Monday      |
| Veteran’s Day&mdash;college closed                           | 11/11 Monday     |
| Last day for schedule changes                                | 11/22 Friday     |
| Thanksgiving Vacation – college closed on Thursday and Friday | 11/28&ndash;12/1 |
| Final exam                                                   | 12/9&ndash;12/11 |

View [academic calendars](https://www.lanecc.edu/calendars/academic-calendar) on the LCC web site.



# Tentative Course Schedule

(May be subject to change)

| Week             | Topics                                                       | Reading                                                      | Lab Assignment                                               |
| ---------------- | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| **1**<br />9/30  | Intro to Web Dev<br />*Class starts Wednesday*               |                                                              | Lab 1<br />Create an empty MVC site                          |
| **2**<br />10/7  | Intro to MVC                                                 | Murach Ch. 1                                                 | Lab 2<br />- Murach Ex 1-1<br />- Add pages and links to a site |
| **3**<br />10/14 | Working with Data                                            | Murach Ch. 2                                                 | Lab 3<br />- Murach Ex 2-1<br />- Add models and data entry<br />- Publish to Azure |
| **4**<br />10/21 | Bootstrap                                                    | Murach Ch. 3                                                 | Lab 4<br />- Murach Ex 3-1, 3-2<br />- Add Bootstrap to your site |
| **5**<br />10/28 | Midterm quiz                                                 |                                                              | Term project proposal<br>Midterm quiz:<br />- In the classroom on 10/30<br />- In the testing center 10/30 through 11/1 |
| **6**<br />11/4  | Unit testing with xUnit                                      | Murach Ch. 14<br />Pg. 570-577                               | Lab 5<br />Add a quiz and <br />unit tests to your site.     |
| 7<br />11/11     | Entity Framework<br />Database Migrations<br />Deploying a DB to Azure<br /><br /> | Murach Ch. 4<br />Online tutorial<br />                      | Lab 6<br />- Murach Ex 4-1<br />- Add a DB to your site<br /> |
| **8**<br />11/18 | Repository Pattern<br />More Unit Testing                    | Murach Ch. 14                                                | Lab 7                                                        |
| **9**<br />11/25 | Linq and Seed Data                                           | Ch. 4: A Data driven web app<br/> 138–139: Seeding initial data<br/> 144–145: Working with data<br />Ch. 12: How to Use EF Core<br/>  472–475: How to query data | Lab 8                                                        |
| **10**<br />12/2 | Debugging<br />Final quiz                                    | Murach Ch. 5                                                 | Lab 9 (Extra Credit)<br />- Murach Ex 5-1<br />- Debugging practice<br />Final in classroom 12/4<br />Final in testing center 12/4&ndash;12/6 |
| **11**<br />12/9 | Project presentations                                        |                                                              | Term project                                                 |



[Go back to the top](#course-description)