#Razor Views and Layouts




## Introduction

We've already been using Razor views, so you are already familiar with the basics. Now we will look deeper and how views work and how to use additional features of views

**Razor Review**

- Razor files are named with the .cshtml extension 

- Razor syntax is essentially HTML with C# mixed in.

  - Use @ to switch from HTML to C#

    - Example:
      ` @book.Title `

    - Note that what follows the @ is a C# expression that will be rendered along with the surrounding HTML.

    - If a Razor expression contains spaces, it should be enclosed in parenthesis:

      ```C#
      Yesterday: @(DateTime.Now - TimeSpan.FromDays(1))
      ```

    - Razor expressions containing generics also need to be enclosed in parenthesis:
      `@(GenericMethod())`

  - Use @{ } to mark a block of C#

    - Example:
      `@{  string greeting = "Hello ";  greeting += Model.Name;}`

    - Note that the code inside a [Razor code block](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-2.1#razor-code-blocks) is not rendered along with the surrounding HTML.

  - Use @: to switch from C# to HTML

    - Example:
      `@switch (@Model.Name) {  case "Admin":    @:You have all the power!    break;`

- A

   

  model 

  can be declared in a view to create a

   strongly typed view

  - In your view, declare the model like this:
    `@model List`


**Layouts** 
 , that can be included in other views and allows you to re-use Razor code.

**Alternate Means of Passing Data**

- ViewBag

  - A wrapper around ViewData which simplifies retrieval of data by casting the value to the correct type for you automatically
  - Uses the same underlying ViewData object, so you can store a key-value pair using ViewData and retrieve it using ViewBag (or vice-versa).
  - Examples:
    -  Putting data in the ViewBag in a controller method:
      `ViewBag.bookCount = books.Count;`

  - - Retrieving data in a view:
      `number of Books: @ViewBag.bookCount`

**Reference** 

- [Microsoft: Razor Syntax Reference for ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-2.1)
- [Microsoft: Layout in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout?view=aspnetcore-2.1)
- [Microsoft: Weakly typed data (ViewData, ViewDataAttribute, and ViewBag)](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-2.1#weakly-typed-data-viewdata-viewdata-attribute-and-viewbag)

------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog) are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------