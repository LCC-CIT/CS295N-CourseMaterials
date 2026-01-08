# Lab 1: The Visual Studio Default Site

CS295N, Web Development 1: ASP.NET

In this lab, you will be creating a web site that you will continue to build on in subsequent lab assignments. The type of site you make will depend on the Moodle lab assignment group to which you have been assigned. These are the types of sites you will create:

- Group A: Community site&mdash;this can be a site for a neighborhood, a club, or any other type of group.
- Group B: Fan site&mdash;a site dedicated to a person, book, music group or anything else you might be a fan of.
- Group C: Informational site&mdash;this site can contain information on any topic like food, politics, cats, or anything else you are interested in.

### Instructions

1. Create a private repository on [GitHub](https://github.com/). Use your real name in the name of the repository. For example: "BrianBird_CS295N_Labs". You will put each lab assignment in a different [branch](https://www.atlassian.com/git/tutorials/using-branches) in this repository.

   - Add a [.gitignore file](https://www.toptal.com/developers/gitignore/api/aspnetcore) for ASP.NET Core projects and commit it to the main branch.
     <u>Important</u>: commit the gitignore file before you commit any other code!
   - Make a branch named lab1, which is derived form the main and put your web project into it.

   - Invite your lab partners and your instructor to be collaborators on the repository. You can send a message to each of your lab partners to let them know your GitHub user name and/or email address so they can use it to add you as a collaborator.
2. Follow the instructions in, [Getting Started with ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-10.0&tabs=visual-studio) to create a web site in the working directory of your local Git repository.

   -  Instead of choosing .NET 9.0 as the framework, choose .NET 10.0
   -  Instead of naming the project "MVCMovie", name it something that reflects the purpose of your site, like "AllAboutPigeons".
   - Change the home page so that it has a title and one or two sentences appropriate to the type of site corresponding to the lab assignment group you are in.

**Note:** Visual Studio creates an SSL certificate for the project so that when you run the web app on your development machine you can use an *https* connection. You may need to perform some additional steps to get your browser (particularly Firefox) to accept the certificate. 

### Grading Rubric

[Lab 1 Grading Rubric](Lab1Rubric_CS295N.htm)

### Submission

This week you will not submit a beta version of your web site or do code reviews.

1. Take a screen-shot of the home page of your app. 

   Include the address bar of the browser in the screen-shot.

2. Upload the screen-shot to Moodle.

3. Enter the URL of the lab1 branch of your Git repository in the Moodle online text.



### References

[.gitignore](https://www.atlassian.com/git/tutorials/saving-changes/gitignore) - Atlassian BitBucket tutorial

[Git Branch](https://www.atlassian.com/git/tutorials/using-branches) - Atlassian BitBucket tutorial



[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
ASP.NET Core MVC Course Materials by [Brian Bird](https://profbird.dev), 2018, revised in <time>2026</time>, are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

