# More on Controllers

| **Where we are**                       |                                           |
| -------------------------------------- | ----------------------------------------- |
| 1. Intro to MVC                        | 6. Debugging / <u>More on Controllers</u> |
| 2. More on MVC / Statelessness of HTTP | 7. Unit Testing                           |
| 3. C# Review / Advanced C# for MVC     | 8. Databases EF and LINQ                  |
| 4. <u>Razor Views</u>                  | 9. Model Binding / Validation             |
| 5. Deploy to a server                  | 10. Configuration / URL routing           |

Introduction We've already been using Controllers, so you are already familiar with the basics. Now we will look deeper at how controllers work and how to use additional features.



##Contents

- Controller Review
- HTTP Basics
- ​



##Controller Review

- Create controller classes by inheriting from the AspNetCore.Mvc.Controller class. 
  Note: you can create a controller from scratch rather than inheriting from the framework Controller class, but it takes more effort.
- By convention, the class name ends in Controller.
- Controllers process HTTP requests. Each expected request will be mapped to a controller method (aka *controller action*)

### HTTP Basics

- Requests

  - Methods: GET, POST, PUT, HEAD (like GET, but without a response body), DELETE, OPTIONS
  - Message ([Wikipedia](https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol#Request_message))
    - A request line (e.g., *GET /images/logo.png HTTP/1.1*, which requests a resource called `/images/logo.png` from the server.)
    - One or more [request header fields](https://en.wikipedia.org/wiki/HTTP_request_header_field) (e.g., *Accept-Language: en*).
    - An empty line
    - An optional [message body](https://en.wikipedia.org/wiki/HTTP_message_body)

- Response messages

  - A status line which includes the [status code](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes) and reason message (e.g., *HTTP/1.1 200 OK*, which indicates that the client's request succeeded.)
  - One or more [response header fields](https://en.wikipedia.org/wiki/HTTP_response_header_field) (e.g., *Content-Type: text/html*)
  - An empty line
  - An optional [message body](https://en.wikipedia.org/wiki/HTTP_message_body)

### Controller Response Types



## Reference

- [Hypertext Transfer Protocol](https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol) (Wikipedia)
- [Handle requests with controllers in ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/actions?view=aspnetcore-2.2) (Microsoft)
- [ASP.NET Core API Reference](https://docs.microsoft.com/en-us/dotnet/api/?view=aspnetcore-2.2) (Microsoft)


------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC Lecture Notes, written by [Brian Bird](https://birdsbits.blog), fall 019, are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

