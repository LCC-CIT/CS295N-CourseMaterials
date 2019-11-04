# Razor Views

| **Where we are**                      |                                         |
| ------------------------------------- | --------------------------------------- |
| 1. Intro to MVC                       | 6. Unit Testing                         |
| 2. More on MVC / Satelessness of HTTP | 7. Model Design / Entity Framework (EF) |
| 3. C# Review / Advanced C# for MVC    | 8. More on EF / LINQ                    |
| 4. <u>Razor Views</u>                 | 9. Model Binding / Validation           |
| 5. Web Dev Tools / Deploy to a server | 10. Configuration / URL routing         |

Introduction We've already been using Razor views, so you are already familiar with the basics. Now we will look deeper and how views work and how to use additional features of views.



##Contents

- Razor Review
- Layouts
- Alternate means of passing data
- ViewData
- ViewBag 
- Reference



##Razor Review

- Razor files are named with the .cshtml extension 

- Razor syntax is essentially HTML with C# mixed in.

  - Use @ to switch from HTML to C#

    - Example:

      ```html
      <h2> @book.Title </h2>
      ```
      
    - Note that what follows the @ is a Razor expression that will be rendered along with the surrounding HTML.

    - If a Razor expression contains spaces, it should be enclosed in parenthesis:
      
    ```html
      <p>Yesterday: @(DateTime.Now - TimeSpan.FromDays(1))</p>
      ```
      
    - Razor expressions containing generics also need to be enclosed in parenthesis:
      
      ```html
      <p>@(GenericMethod<int>())</p>
      ```

  - Use @{ } to mark a block of C#

    - Example:
      
    ```html
      @{
         string greeting = "Hello ";
         greeting += Model.Name;
      }
      ```
      
    - Note that the code inside a [Razor code block](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-2.1#razor-code-blocks) is not rendered along with the surrounding HTML.

  - Use @: to switch from C# to HTML

    - Example:
      
      ```c#
      @switch (@Model.Name) {
          case "Admin":
             @:You have all the power!
             break;
      ```

- A model can be declared in a view to create a strongly typed view

  - In your view, declare the model like this:
  
    ```html
  @model List<Book>
    ```
  
    

##Layouts
You can create a special type of view, called a *layout*, that can be included in other views and allows you to re-use Razor code.

- Naming and declaring layouts
  - There can be more than one layout.

  -  Conventionally, the file names start with an underscore

  - The *Views/Shared*/ folder is one place where layouts are stored, but each view folder can also contain layouts.

  - The default layout name is defined in *_ViewStart.cshtml*

    - Example:

      ```html
      @Layout = _layout.cshtml
      ```

- Defining a layout

  - Layout are written just like a regular Razor view.
  
  - The layout will actually contain the view in which it is declared. The view that uses the layout will be rendered in the layout by the *RenderBody()* method.
  
  - Example:
  
    ```html
    <!DOCTYPE html>
    <html>
    <head>
        <title>Layout Example</title>
    </head>
    <body>
      <h1>This heading is in the layout</h1>
      Any view that uses this layout will be rendered here:
        @RenderBody()
      </body>
    </html>
    ```
  
- Default layouts and *_ViewStart.cshtml*

  - A default layout can be placed in *Views/Shared/* or in other view folders to create a default for that particular view folder. 

  - A view can use a layout other than the default by assigning that layout to the Layout property in that view.

    - Example:

      ```C#
      @{
          Layout = "_MyLayout";
      }
      ```

  - To use the default layout, _Layout, you do not need to declare a layout in the view

  - If there is a default layout in the Views/Shared/ folder, but you don't want to use it in a particular view, set the Layout property in the view to null.

    - Example:

      ```C#
      @{
          Layout = null;
      }
      ```

      Note: The layout assignments above must be done inside a code block (inside curly braces) since this code is not to be rendered as HTML.

##Alternate Means of Passing Data

ViewData provides an alternative way to send data from a controller to a view and can also be used to send data from a view to a layout or partial view.

- **ViewData**

  - A Dictionary object which is a property of the Controller class and of views.

  - Data is stored as key-value pairs. The keys are strings.

  - It is weakly typed-- everything is stored in ViewData as an object and any value other than a string value must be cast to it's original type when it is retrieved.

  - Examples

    - Putting data in ViewData in a controller method:

    ```c#
    ViewData["newestBook"]= books[books.Count - 1].Title;
    ```
  
- Retrieving data in a view:
  
```C#
    Newest Book: @ViewData["newestBook"]
```

  

- **ViewBag**

  - A wrapper around ViewData which simplifies retrieval of data by casting the value to the correct type for you automatically
  - Uses the same underlying ViewData object, so you can store a key-value pair using ViewData and retrieve it using ViewBag (or vice-versa).
  - Examples:
    -  Putting data in the ViewBag in a controller method:
      ```C#
      ViewBag.bookCount = books.Count;
      ```

  - - Retrieving data in a view:
      
      ```c#
      number of Books: @ViewBag.bookCount
      ```
      
      
      
      

##Reference

- [Microsoft: Razor Syntax Reference for ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-2.1)
- [Microsoft: Layout in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout?view=aspnetcore-2.1)
- [Microsoft: Weakly typed data (ViewData, ViewDataAttribute, and ViewBag)](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-2.1#weakly-typed-data-viewdata-viewdata-attribute-and-viewbag)



------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/88x31.png)](http://creativecommons.org/licenses/by/4.0/)
These ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog)  are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

------

