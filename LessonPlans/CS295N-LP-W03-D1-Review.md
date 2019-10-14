#Review of MVC Concepts

| Weekly topics                          |                                         |
| -------------------------------------- | --------------------------------------- |
| 1. Intro to MVC                        | 6. Unit Testing                         |
| 2. Models and domain modeling          | 7. Model Design / Entity Framework (EF) |
| 3. <u>Review / Advanced C# for MVC</u> | 8. More on EF / LINQ                    |
| 4. Razor Views                         | 9. Model Binding / Validation           |
| 5. Web Dev Tools / Midterm             | 10. Configuration / URL routing         |



## Introduction for this week

### Overview

Today we will review the basics of Views and Controllers, in the next session we'll look at some C# features that are commonly used in MVC web apps. There won't be any new MVC concepts introduced this week.

### Textbook

This week we're reading Ch. 4, Essential C# Features, in our textbook. I found this chapter a little hard to follow. You can just skim it. In reality not all these features are essential. In the next session, I'll go over the c# features that you will need to know for the next few lab assignments. The two most important C# features for MVC are *lambda expressions* and *Async/Await*. We will cover lambda expessions this week and Async/Await later in the term.

### Example Code

- In class today, we will make a new simple MVC project so we can walk through the basics of an MVC app as a way to reveiw what we've covered so far.

- In the next session, there will be links in the lecture notes to example code snippets on [DotNetFiddle](https://dotnetfiddle.net/GettingStarted/).

- This week's version of the [Good Book Nook (aka BookInfo)](https://github.com/LCC-CIT/CS295N-Bookinfo-Core-21/tree/Lambda+ComplexModel "Lambda+ComplexModel branch") uses lambda expressions and has new code in the BookController and views for adding reviews.

### Lab

- Add to your model as well as write controller and view code to use a slightly more complex model.
-  Use lambda expressions. 

****

##Review Topics

### MVC Project

In Visual Studio 2017, create a new project.

- Use the *ASP.NET Core Web Application* project template.

- Choose the *Empty* project template on the second project dialog.

- Modify startup.cs to add MVC framework support to our app.  

  ```C#
  public class Startup {
    public void ConfigureServices(IServiceCollection services) 
    {
      /* Add this */
      services.AddMvc();
    }
    
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment()) 
      {
        app.UseDeveloperExceptionPage();
      }
      
      /* Comment this out */
      //app.Run(async (context) => {
      // await context.Response.WriteAsync("Hello World!");
      //});
      
      /* Add this */
      app.UseMvcWithDefaultRoute();
    }
  }
  ```

  

### Controllers

HTTP requests are automatically mapped to controller methods. There are a variety of HTTP request types, but the two we will be interested in for now are GET and POST. 

> What kind of requests should GET be used for?
>
> What kid of request should POST be used for?







### Views



