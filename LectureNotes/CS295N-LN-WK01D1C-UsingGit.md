<h1>Creating a Git Repo for a VS Solution</h1>

[TOC]

## Overview

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
2. Create a new branch by typing: `git branch` followed by the new branch name.
   For example: `git branch lab1`

Here are some useful commands for working with branches:

- `git branch` shows all branches in the local clone of the repository.
- `git branch -r` shows all remote branches at the origin  (on GitHub).
- `git checkout` followed by a branch name switches the local branch. 
  If you enter the name of a remote branch, it will be pulled from the origin.

### Add a Visual Studio Solution

1. Confirm that you are using the branch you want in the local repository.
2. Create or add a solution folder to the repo.
   - If you already have a VS Solution folder, just copy it into the local repository folder.
   - If you are creating a new solution, then in Visual Studio, create a *New Project* and specify the repository as the directory to use.
     Note: Name the project (aka solution) with a name descriptive of your web site. For example: *BookReviewSite*.
3. Add the new files to the repo index by typing; `git add .`
4. Commit the files to the repo by typing `git commit -m` folllowed by a commit message in quotes.
5. Push the new files you just committed to the origin (GitHub) by typing: `git push`

That's it. You can now see your new Visual Studio solution in your repo on GitHub.

