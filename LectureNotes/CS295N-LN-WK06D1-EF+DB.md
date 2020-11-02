**CS295N Web Development 1: ASP.NET
**

Brian Bird

# Entity Framework

Weekly Topics:



| Weekly Topics                             |                                                     |
| ----------------------------------------- | --------------------------------------------------- |
| 1. Intro to Web Dev                       | 6. **Database & Entity Framework**                  |
| 2. Intro to MVC & Deploying to Azure      | 7. Unit Testing with a DB / *Veteran's Day holiday* |
| 3. MVC Architectural patterns             | 8. Controllers & Debugging                          |
| 4. Bootstrap                              | 9. Razor Views / *Thanksgiving holiday*             |
| 5. Midterm Quiz & Unit testing with xUnit | 10. Razor Views (continued)                         |



## **Contents**

[TOC]

## Introduction

- Discuss the quiz.
- Answer questions about lab 5.
- Describe where we're going: databases, unit testing with databases.



## Object Relational Mapping and Entity Framework Core 

One of the main functions of Entity Framework is to do [Object Relational Mapping](https://en.wikipedia.org/wiki/Object-relational_mapping). The purpose of an Object Relational Mapper (ORM) is to serve as a bridge between the world of our object oriented code and the world of the relational database. An ORM maps a domain model to a database schema and allows developers to just focus on writing OO code while the ORM takes care of database operations.

EF is not the only ORM option for .NET Core developers. Other options include:

- [NHibernate](https://github.com/nhibernate/nhibernate-core) -- the most mature and popular alternative to EF for .NET developers
- [Dapper](https://github.com/StackExchange/Dapper)
- [NPoco](https://github.com/schotime/NPoco/wiki)
- [LINQ to Db](https://linq2db.github.io)


Entity Framework Core has [database providers](https://docs.microsoft.com/en-us/ef/core/providers/) that support the following database types:

- SQL Server (including LocalDB)
- Microsoft Access
- Oracle
- SQLite
- PostgreSQL
- MySQL and MariaDb
- Db2
- And more

------



## Adding Entity Framework to a Web App

- There are two major approaches to software development with EF:

- - Code first (Model first) -- we are using this approach

- - Database first 

- In order to use Entity Framework in your web app, you need to add to, or modify, your code in the ways shown below.

### Models


Ideally, we would like our models to be designed solely with object oriented design in mind-- without thinking about databases. But in reality we do need to consider how Entity Framework will generate a database schema based on our models. There are two main things to consider:

- Defining primary keys

  We need to identify a field in the model that EF can map to a primary key. 

  We have two alternatives:

  - Add the [&lsqb;key&rsqb;](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.keyattribute?view=netcore-2.1) data annotation attribute to a property.

    Ask yourself, would this provide a unique key?

    ````c#
    public class Book{  [key]  public string Title { get; set; }
    ````

  - Add an ID property:
    By convention, any property name ending in ID will be mapped to a primary key
    This is guaranteed to be a unique key

    ```c#
    public class Book{  public int BookID { get; set; }  public string Title { get; set; }
    ```

    

- Avoid many-to-many relationships

  The current LTS version of EF, version 3.1, [doesn't support many-to-many relationships](https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many)

### DbContext Class

- This class provides an entry point for your application to access Entity Framework Core which provides access to the database. 

- You need to define your own database context class that inherits from DbContext

  ```C#
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(
       DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<User> Users { get; set; }
  }
  ```



  

### Connection String in appsettings.json 

- A connection string specifies the location and name of the database and provides configuration settings.

- Connection strings are stored in appsettings.json. 

  ```json
  "Data": {
    "GoodBookNook": {
      "ConnectionString": "Server=(localdb)\\MSSQLLocalDB;Database=GoodBookNook; Trusted_Connection=True;MultipleActiveResultSets=true"
     }
  }
  ```

  

### Startup Class


In the *ConfigureServices* method, add a service for DbContext. 

- [AddDbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.entityframeworkservicecollectionextensions.adddbcontext?view=efcore-2.1) will read the connection string and configure your DbContext to connect to your database. 

- This service also performs *dependency injection* to inject your DbContext object into any of your classes that the framework instantiates that have your DbContext class as a parameter in the constructor.

- The options argument specifies that this is a Microsoft SQL Server database, but you could also use another database, like SQLite.

- Example:

  ```C#
  services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:GoodBookNook:ConnectionString"]));
  ```

  

#### Loading related data

Related data is  data that comes from objects that are related to the object that you are getting from  DbContext by aggregation or composition. 

For example, in the Book model below, the two lists are related data (also called *navigational properties*) because they are lists of domain model objects that are related to Book objects both conceptually and by object composition.

```c#
public class Book 
{
// Backing fields for the navigational properties
  private List<Author> authors = new List();
  private List<Review> reviews = new List();
  // Ordinary properties
  public int BookID { get; set; }
  public string Title { get; set; }
  public DateTime PubDate { get; set; }
  // Navigational properties
  public List<Author> Authors { get { return authors; } }
  public List<Review> Reviews** { get { return reviews; } }
}
```



Note that the *navigational properties* will cause EF to create foreign key fields for BookID in the Author and Review tables in the database.



#### Ways to load related data

- **Eager loading**
  Related data is loaded from the database as part of the initial query.

- - Use the *Include* method to include dependent objects. You only need this when you include your own model classes (not for *DateTime* or other classes that are not part of your domain model.)

  - Use *ThenInclude* for second-level dependencies.
    Example code from a repository class:

    ```C#
    public List Books { get {
      return context.Books.Include(book => book.Authors)
      .Include(book => book.Reviews)
      .ThenInclude(review => review.Reviewer)
      .ToList();
      }
    }
    ```

    

- **Explicit loading**
  Related data is explicitly loaded from the database at a later time.
  (See the article below for more details.)
- **Lazy loading**
  Related data is transparently loaded from the database when a navigation property is accessed.
  (See the article below for more details.)

> **Reference**
> MS EF Core Tutorial: [Loading Related Data](https://docs.microsoft.com/en-us/ef/core/querying/related-data)

------



## Creating a Database

Before you can run your app, you need to create a database on the host system. This might be your development machine, or a production server. On your development machine. But, before you can create a database, you need to add a database migration. You can read about that in the Migrations section below. 

In order to do operations on our database, we will be using CLI (Command Line Interface) commands. You can check to see if you have the CLI tools for Entity Framework installed by entering the command below:

dotnet ef

You should get this response:

```bash
                     _/\__
               ---==/    \\
         ___  ___   |.    \|\
        | __|| __|  |  )   \\\
        | _| | _|   \_/ |  //|\\
        |___||_|       /   \\\/\\

Entity Framework Core .NET Command-line Tools 2.2.1-servicing-10028
Usage: dotnet ef [options] [command]
Options:
  --version        Show version information
  -h|--help        Show help information
  -v|--verbose     Show verbose output.
  --no-color       Don't colorize output.
  --prefix-output  Prefix output with level.
Commands:
  database    Commands to manage the database.
  dbcontext   Commands to manage DbContext types.
  migrations  Commands to manage migrations.
Use "dotnet ef [command] --help" for more information about a command.
```

If are using .NET Core 1.X and you get a message like this:
Could not execute because the specified command or file was not found, it is probably because the CLI tools for EF didn't get installed when you installed Visual Studio. You can install them by executing this command:

`dotnet tool install --global dotnet-ef --version 3.1`

Note that this will install the tools globally, if you only want to install them for the current project, then leave off the --global switch. And, if you are using a version of ASP.NET Core other than 3.1 (which we are using this term in class), then change the version number. If you omit the --version switch, it will install the latest version.



### Migrations


*Migrations* are a means of solving the problem of how to update the database when the models change. After changing any model, you will need to "add a migration" which puts code in the Migrations folder of the project that will be used by EF to update the Db schema as well as migrate the data from the old schema to the new schema.



#### Creating a Migration

Use the CLI command:

dotnet ef migrations add *Initial*

- No database will be created
- A file will be added to the Migrations folder
- The DbContextModelSnapshot file will be created or updated

Running this command will cause the following to take place:

1. Build the .NET Core assembly for the project in the folder where you ran the command
2. Find DbContext classes
3. Find IDesignTimeDbContextFactory implementations
4. Find application database service provider
5. Find BuildWebHost method
6. Use environment 'Development'.
7. Use application service provider from BuildWebHost method on 'Program'
8. Connect to LocalDB using the user's Windows credentials
   *---------* *the first 8 operations are the same for adding a migration and appling a migration ---------*
9. Create new migration file in the Migrations folder
10. Update the sanpshot file in the Migrations folder 

#### 

#### Applying a Migration and creating (or updating) the database 


Use the CLI command:

dotnet ef database update



- If the database hasn't previously been created, this command will also create the database.
- Running this command will cause the same operations as the first eight above to take place, plus: 

- - Create a database if one does not exist 

- - Execute SQL statements to apply the migrations if they are not already applied

- Reference: [EF Core .NET Command-line Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)

Note: if you want to drop the database so you can run update again, use this CLI command:

dotnet ef database drop 





------



## Viewing Your Database


After EF has created a database, you can use SQL Server Object Explorer in Visual Studio to view it.

- The server name will be: *(localdb)\MSSQLLocalDB*
- Connection should be through Windows Authentication with a user name that looks like: *DESKTOP-SGC2610\Brian*

*Main things of interest:* 

- Tables
- Columns
- Data 



------



## Running Unit Tests 


Adding EF should not have broken any of your unit tests. But it's good practice to run the tests before pushing our code to the central repository (on GitHub). 



------



## Example


[BookInfo, branch EF](https://github.com/LCC-CIT/CS295N-Bookinfo-Core-21/tree/EF)



------

## References

- *Pro ASP.NET Core MVC 2.0*, Adam Freeman, Apress, 2017.

  Ch. 8 "Sports Store, a Real Application", section titled,

  "Preparing a Database" (page 208), with sub-sections:

  - Installing the Entity Framework Core Tools Package 
  - Creating the Database Classes 
  - Creating the Repository Class 
  - Defining the Connection String 
  - Configuring the Application
    -  "Disabling Scope Verification"
  - Creating the Database Migration 
  - Creating the Seed Data 

- Microsoft Docs: [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

- Microsoft Tutorial: [Get started with ASP.NET Core MVC and Entity Framework Core using Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/)

- .NET Core API Reference: [System.ComponentModel.DataAnnotations Namespace](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netcore-3.1)

- Microsoft Reference: [Entity Framework Core tools reference - .NET CLI](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)



------

[![Creative Commons License](https://i.creativecommons.org/l/by/4.0/80x15.png)](http://creativecommons.org/licenses/by/4.0/) ASP.NET Core MVC Lecture Notes by [Brian Bird](https://birdsbits.blog) are licensed under a [Creative Commons Attribution 4.0 International License](http://creativecommons.org/licenses/by/4.0/). 

