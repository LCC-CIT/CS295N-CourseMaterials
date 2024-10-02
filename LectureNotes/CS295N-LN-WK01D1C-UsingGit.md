<h1>Creating a Git Repo for a VS Solution</h1>

<h2>CS295N, ASP.NET Core Web Development</h2>




| Weekly Topics                             |                                               |
| ----------------------------------------- | --------------------------------------------- |
| <mark>1. Intro to Web Dev</mark>          | 6. Entity Framework / Deploying a DB to Azure |
| 2. Intro to MVC / Deploying to Azure      | 7. Debugging / *Veteran's Day holiday*        |
| 3. MVC Architectural patterns             | 8. Controllers                                |
| 4. Bootstrap                              | 9. Razor Views / *Thanksgiving holiday*       |
| 5. Midterm Quiz / Unit testing with xUnit | 10. Razor Views (continued)                   |

<h3>Contents</h3>

[TOC]

## Announcements

### No-show Drop Policy

LCC requires students to either come to class in person, or complete one assignment during the first week or they will be automaitcally dropped. The reason for this is to reduce the amount of financial aid fraud.

### Todo this Week

- Do the assigned reading
- Take the reading quiz by the end of the day Friday, 10/4/24
- Start the lab assignment which is due next Thursday, 10/10/24

### Discord

I'm changing our class communication from Moodle forums to Discord channels. Join our class Discord server to get announcements and communicate with the class.

## Git Repository Overview

There are two ways you can create a repository:

1. Create a repo on your local machine and then push it up to GitHub.
2. Create a repo on GitHub and clone it to your local machine. 

*We will do it the second way.*

### Git Clients

There are also multiple ways you can work with Git on your local machine. You can use:

- **GitHub desktop**, or any of a number of other Git GUI client apps.
- **Visual Studio** or **Visual Studio Code**. Both of these have Git clients built in or that you can add as extensions.
- **GitHub CLI** which is a special purpose Command Line Interface designed just for working with GitHub.
- The **command line**. This is a general purpose way to work with git using a terminal app, the Windows console, GitBash or any other way of directly using the command line of the OS on your local machine.

We will use the *command line* since that's what most of you are familiar with.

#### Create a personal access token

If you haven't already created a GitHub Personal Access Token, then create one following these instructions: [Creating a personal access token](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).

When you execute a git command that requires you to enter your user name and password, use the personal access token instead of your password.

### A note about labs

For your lab assignments in CS295N, you will be creating a single web app. Each week you will add new features to it. You will not make separate folders for each lab assignment, you will just put the code for each lab assignment on a different branch in Git.

## Creating a Repo

- Open the GitHub web page and log in.
- Create a new repository. Name it in a way that identifies it as a repo for your CS295N lab assignments for this term. For example: *CS295N-F22-BrianBird*.
  
  Note: you will use one repository for all your lab assignments.

- Add a *gitignore* file for Visual Studio.

  Note that the gitignore file must be committed to the repository <u>before any other commits</u> in order for it to be effective!

## Cloning a Repo

- On the GitHub Repository web page, click on the green "Code" button. You will see options for cloning the repository using any of these:

  - GitHub desktop app.
  - Visual Studio.
  - Git command line.

     Select HTTPS and copy the URL for the repository.

- On your development machine, use a terminal app or console window or GitBash to:

  - Navigate to the directory (folder) where you want to put the repository using the command: `cd ` followed by the path to the directory you want.
  - `git clone ` followed by the URL of the repository.

That's it. You've cloned the repository

## Adding a Branch with a VS Solution

### Create a branch

On your local machine, use the command line for each step below.

1. Change directories to the new repo you created by typing: `cd ` followed by the directory name.

2. Create a new branch by typing: `git checkout -b` *followed by the new branch name*.
   This will create a new branch and copy the files, including the .gitignore file, from the main branch into the new branch.

   For example: `git checkout -b lab1` .

Here are some useful commands for working with branches:

- `git branch` shows all branches in the local clone of the repository.
- `git branch -r` shows all remote branches at the origin  (on GitHub).
- `git branch` *followed by a branch name* creates a new local branch.
- `git checkout` *followed by an existing branch name* switches the local branch. 
  If you enter the name of a remote branch, that branch will be pulled from the origin.
- `git checkout -b` *followed by a new branch name* created a new branch <u>and</u> copies the files from the current branch into it.

### Add a Visual Studio Solution

1. Confirm that you are using the branch you want in the local repository.

2. Create or add a solution folder to the repo.
   - If you already have a VS Solution folder, just copy it into the local repository folder.
   - If you are creating a new solution, then in Visual Studio, create a *New Project* and specify the repository as the directory to use.
     Note: Name the project (aka solution) with a name descriptive of your web site. For example: *BookReviewSite*.

3. Add the new files to the repo index by typing; `git add .`

4. Commit the files to the repo by typing `git commit -m` followed by a commit message in quotes.

5. Push the new files you just committed to the origin (GitHub) by typing: `git push`

   

That's it. You can now see your new Visual Studio solution in your repo on GitHub!



## Reference

[W3 Schools Git Tutorial](https://www.w3schools.com/git/default.asp?remote=github)

Chacon, Scott and Straub, Ben. *[Pro Git book](https://git-scm.com/book/en/v2)*. 2nd Edition. Apress, 2014.



------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Lecture Notes by [Brian Bird](https://profbird.dev), 2022, is licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

