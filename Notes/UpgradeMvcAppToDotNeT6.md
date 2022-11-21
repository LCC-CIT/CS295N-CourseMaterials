<h1>Upgrade an ASP.NET MVC App to .NET 6.0</h1>

These are the steps to upgrade an ASP.NET Core MVC 3.1 web app to use .NET 6.0.

1. Make a new ASP.NET MVC solution
   - Set the default project name to be the same as your existing project's name
     This makes it so the namespace will be the same.
   - Choose .NET 6.0
   - Make sure the Project name matches your existing project name. That means you won't have to change the namespaces.

2. Copy files from your old VS solution to the new one.
   - In File Explorer, copy and paste your view folders, controllers, models, repositories, and any other classes that you created, including your DbContext class, into the new project.
   
3. Add dependencies/NuGet packages.
   In VS, in the NuGet package manager, install all the same NuGet packages you had in your old project. Make sure the version number are all 6.0.x.

4. Move code from Startup.cs to Program.cs  
   (There isn't a startup class - everything happens in the Program class.)
   
   Add the following code right after the *builder* object gets instantiated - and before *builder.Service.AddControllersWithViews* gets called:
   
   - Set up the connection by adding this code:  
     ```c#
     var connectionString = builder.Configuration.GetConnectionString("MyConnection");
     ```
     Where "MyConnection" is the name of your connection string.
   
   - Add the DbContext service. This example is for MySQL:

     ```C#
     builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(connectionString,
     Microsoft.EntityFrameworkCore.ServerVersion.AutoDetect(connectionString)));
     ```

   - Add code to set up dependency injection into any repositories:

     ```C#
     builder.Services.AddTransient<IReviewRepository, ReviewRepository>();
     ```

5.  Copy your test project over and add it to the solution. 
   - In File Explorer, copy the entire test project folder to the new solution folder.
   - In VS, add the test project as an "Existing Project".
   - Upgrade the test project .NET version to 6.0
   -  Add a reference to the web project.

*That's it! Test your projects and debug anything that isn't working.*
