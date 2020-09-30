 CS295N, Web Development 1: ASP.NET

# Lab 2A, Skeletal Community Info Site

### Part 1: Exercise 1-1, Use Visual Studio to run the Guitar Shop app

Do the exercise at the end of chapter 1 in Delamater and Murach.

Take a screen-shot of the web app running in a browser on your machine.

### Part 2: Skeletal Web Site &mdash; Group A, Community Info Site

Create the skeleton for a community information site. You get to decide which community this site is for. It could be a neighborhood, a club, a fictional community, etc.

#### Site Map

Main bullet points are top-level web pages, and indented bullets are pages linked from those top-level pages.

-   Home -- General information about the community and the purpose of the site

    -   History -- A brief history of the community

    -   Contact -- a page with a form where users can send messages to the other users

-   Info -- Highlights of the community

    -   Important locations and links

    -   Significant people and links if available

#### Controllers

Write a new controller class for Info so that each top-level page of the site has a controller. Write a method in the controller for each sub-page. Note that the Home controller should have an index method, index methods are optional in other controllers.

#### Views

Write a view for each page. Each view can be empty. It will just be a place-holder for the information described above.

#### Models

No models are needed yet. You will add those in a future lab.



## Submission

### Part 1: Exercise

Upload the screen-shot to Moodle.

###Part 2: Web Site

#### Beta Version

1.  Your code should be in a branch of a Git repository named lab2.
2.  Publish your web site to Azure.
3.  Send a PR to your lab partner requesting a code review.
4.  Do a code review of your lab partner's code in the PR.
5.  Enter the URL of the PR with the code review you did in the Moodle online text.

#### Production Version

1.  Revise your code as needed.
2.  Merge the lab branch into the main branch.
3.  Republish to Azure if needed.
4.  Enter the URL of your main branch into the online text of the Moodle submission.
