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
- Action Method Return Types
- Context Data
- References



##Controller Review

- Create controller classes by inheriting from the AspNetCore.Mvc.Controller class. 
  Note: you can create a controller from scratch (a POCO class) rather than inheriting from the framework Controller class, but it takes more effort.
  
- By convention, the class name ends in *Controller*.

- Controllers process HTTP requests. Each expected request will be mapped to a controller method (aka *controller action*)

- - Requests are received by the routing module wich instantiates the appropriate controller object.
    - The controller name corresponds to the first segment of the path portion of the URL.
    - The controller action method corresponds to the second segment of the path portion of the URL.
    - A new controller object is created for each request!
    
  - A C# attribute determines whether an action method responds to a GET or POST request.
  
    ```c#
    [HttpPost]
    public RedirectToActionResult AddBook(string title, string author, string pubDate)
    {
    	// TODO: Complete the method body
    	return RedirectToAction("Index");
    }
    ```
  
    



### HTTP Basics

- Requests

  - Methods: GET, POST, PUT, HEAD (like GET, but without a response body), DELETE, OPTIONS
  - Message ([Wikipedia](https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol#Request_message))
    - A request line (e.g., *GET /images/logo.png HTTP/1.1*, which requests a resource called `/images/logo.png` from the server.)
    - One or more [request header fields](https://en.wikipedia.org/wiki/HTTP_request_header_field) (e.g., *Accept-Language: en*).
    - An empty line
    - An optional [message body](https://en.wikipedia.org/wiki/HTTP_message_body)
    
    > Example: look at an HTTP request in the Firefox Network viewer.

- Response messages

  - A status line which includes the [status code](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes) and reason message (e.g., *HTTP/1.1 200 OK*, which indicates that the client's request succeeded.)
  
  - One or more [response header fields](https://en.wikipedia.org/wiki/HTTP_response_header_field) (e.g., *Content-Type: text/html*)
  
  - An empty line
  
  - An optional [message body](https://en.wikipedia.org/wiki/HTTP_message_body)
  
    > Example: look at an HTTP request in the Firefox Network viewer.

## Action Method Return Types 

These are some of the types that can be returned by a controller method:

- String 
  - No view is associated with a method of this type. The string is just sent directly to the browser.
  - Not used very often
- ViewResult
  - A Razor view is associated with this method. Data is sent to view which is then rendered and sent to the browser.
  - The View method of the Controller class can be used to generate a view. 

    - The view can be specified as an argument or by the naming convention
    - Model data can be passed as an argument
- Redirection Action Results
  - RedirectResult
  - LocalRedirectResult
  - RedirectToActionResult
  - RedirectToRouteResult
- Content Action Results
  - JsonResult
  - ContentResult
  - ObjectResult
  - OkObjectResult
  - NotFoundObjectResult
- File Action Reslts
  - FileContentResult
  - FileStreamResult
  - VirtualFileResult
  - PhysicalFileResult
- Status Codes



## Context Data 

Context data is any data that comes from the incoming HTTP request and provided to the controller by the ASP.NET routing system. Context data can be accessed through:

- Context objects that are members of the Controller class and accessed through the following properties:

  - *Request* - This property returns an HttpRequest object
  - *Path* - This property returns the path section of the request URL.
    - *QueryString* - This property returns the query string section of the request URL.
    - *Headers* - This property returns a dictionary of the request headers, indexed by name.
    - *Body* - This property returns a stream that can be used to read the request body.
    - *Form* - This property returns a dictionary of the form data in the request, indexed by name.
    - *Cookies* - This property returns a dictionary of the request cookies, indexed by name.
    
  - *Response* - This property returns an HttpResponse object 

  - *HttpContext* - This property returns an HttpContext object, which is the source of many of the
    objects returned by other properties, such as Request and Response. It also provides
    information about the HTTP features available and access to lower-level features like
    web sockets.

  - *RouteData* - This property returns the RouteData object produced by the routing system

  - *ModelState* - This property returns a ModelStateDictionary object, which is used to validate data
    sent by the client

  - *User* - This property returns a ClaimsPrincipal object that describes the user who has made the request.

- Arguments passed to an action method in the controller

  - From form input element values

  - Action method parameter names must match the form field names

  - Example:

     - In the Razor view:

       ```html
       form method="post" asp-action="ReceiveForm"> 
         <label for="name">Name:</label>
         <input name="name"> 
         <label for="name">City:</label>
         <input name="city"> 
          <button type="submit">Submit</button>
       </form>
       ```

       - In the corresponding controller method:

       ```c#
       [HttpPost]
       public ViewResult ReceiveForm(string name, string city) {
          return View("Result", $"{name} lives in {city}"); 
       }
       ```

       

- The ASP.NET Core MVC model binding feature

- - Example:

  - - Given this model:

      ```c#
      public class Person {
         public String Name {get; set;}
         public String City {get; set;}
      }
      ```

    - In the Razor view:
      Note that instead of the HTML *for* attribute the *asp-for* Tag Helper is used.

      ```html
      @model Person
      
      <form method="post" asp-action="ReceiveForm"> 
        <label asp-for="name">Name:</label>
        <input name="name"> 
        <label asp-for="name">City:</label>
        <input name="city"> 
         <button type="submit">Submit</button>
      </form>
      ```

    - In the corresponding controller method:

      ```c#
      [HttpPost]
      public ViewResult ReceiveForm(Person person) {
         return View("Result", $"{person.Name} lives in {Person.city}"); 
      }
      ```

      

## Reference

- [Hypertext Transfer Protocol](https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol) (Wikipedia)
- [Handle requests with controllers in ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/actions?view=aspnetcore-2.2) (Microsoft)
- [ASP.NET Core API Reference](https://docs.microsoft.com/en-us/dotnet/api/?view=aspnetcore-2.2) (Microsoft)

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC Lecture Notes, written by [Brian Bird](https://birdsbits.blog), fall 019, are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

