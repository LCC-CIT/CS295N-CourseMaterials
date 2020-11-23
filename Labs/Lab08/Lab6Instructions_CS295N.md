# Lab 6

## Controllers and HTTP

**Part 1: Monitoring HTTP Traffic and Debugging**

- Either Install [Fiddler](https://www.telerik.com/fiddler) or use your browser’s Web Console to monitor network traffic between your development server and the browser. Here are instructions for using the [Firefox Web Console](https://developer.mozilla.org/en-US/docs/Tools/Web_Console).
- Make a copy of a my web app, [DebuggingPracticeGroupA](https://github.com/LCC-CIT/CS295N-CourseMaterials/tree/master/Labs/Lab05/DebuggingPractice-GroupA), or , [DebuggingPracticeGroupB](https://github.com/LCC-CIT/CS295N-CourseMaterials/tree/master/Labs/Lab05/DebuggingPractice-GroupB), depending on which lab group you are in.  

  Note: this app is in my Course Materials repository. You will need to download or lone the whole repository to get this app, then make your own copy of the solution folder in a new location.
- Debug the app using all the debugging techniques you know:
  - Setting breakpoints in Visual Studio
  - Looking at the URL in the browser address bar
  - Monitoring HTTP traffic
  - Using “View Source” in the browser to see how your view was rendered into HTML
- Fix the app so that all the links and pages work as described on the main page of the app


### Part 2: Controller Exercise

Modify the web site you have been doing for your lab projects (the community site, or the fan site) by changing it to use the following:
- Three new controller methods--these would be methods that are part of the Controller class and that are called when an action method returns. 
- Four new return types. These are types that can be returned by the methods above and would hence be the return type for your actioin method.

**Notes**
What I mean by "new" is that these should be methods and types that you do not currently use in your web site.
You may add a new controller and/or views in order to implement these new methods and return types.

###Submission to Moodle

####Beta Version 

Upload the following to the Code Review Forum: 

2. The Visual Studio solution for your debugging project. 
2. The Visual Studio solution for your community or fan web site.
3. A document describing the places where you made the modifications for part 2.
You can zip each solution folder or put it in a Git repostiory and share a link.

####Production Version 

1. Items 1--3 above, but revised as needed. 

   Please use the online text option on Moodle to enter your web site's URL.
2. The code review of your work (the one done by your lab partner) with the second column (“Production”) completed by you. 

****

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC lab instructions, written by [Brian Bird](https://birdsbits.blog), fall 019, are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

