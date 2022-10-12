# More on Controllers

| **Where we are**                      |                                         |
| ------------------------------------- | --------------------------------------- |
| 1. Intro to MVC<u></u>                | <u>6. More on Controllers</u>           |
| 2. More on MVC / Satelessness of HTTP | 7. Unit Testing                         |
| 3. C# Review / Advanced C# for MVC    | 8. Model Design / Entity Framework (EF) |
| 4. Razor Views                        | 9. Model Binding / Validation           |
| 5. Deploy to a server                 | 10. Configuration / URL routing         |

Introduction We've already been using controllers, so you are already familiar with the basics. Now we will look more deeply and how controllers work.



##Contents

- HTTP Sessions
- Controllers
- Reference


### HTTP Sessions

The textbook refers to HTTP sessions. An [HTTP session](https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol#HTTP_session) is something a server uses to keep track of the clients that are using it at any given time. The most common way of doing this is by causing the browser to create a cookie with a unique identifier.

### Controller

- An ASP.NET Core class that contains methods known as actions, or action methods which handle HTTP requests. A new instance of the controller class is created for each HTTP request.
- The controller object is provided with *context data* for each request.
- The type of HTTP response is designated by the return type of the action method. The most common type of response returns a Razor view.

##Reference

- [Microsoft: Handle requests with controllers in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/actions?view=aspnetcore-2.2)
- ​


------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog)  are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

