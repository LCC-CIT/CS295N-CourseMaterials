<h1>Using SQLite in an ASP.NET MVC Visual Studio Project on Windows</h1>

## Install SQLite and SQLite DB Browser

First you need to install [SQLite](https://www.sqlite.org/index.html) on the Windows development machine. You can do that by downloading and installing [DB Browser for SQLite](https://sqlitebrowser.org/), which you will use to manage your SQLite database. The DB Browser for SQLite setup program will also install SQLite. You can read more about this in appendix B of the Murach textbook.

## Modify your Visual Studio ASP.NET MVC Project

### For Both Versions of .NET

1. Add the `Microsoft.EntityFrameworkCore.Sqlite.Core` NuGet package to your project. Match the version number of the package to your .NET version number.
2. Add a connection string to `appsettings.json` for your SQLite database:

```json
  "ConnectionStrings": {
    "SqliteConnection": "Data Source=Data/BookReviews.db"
  },
```

2. Add a folder named "Data" to your project if you don't already have one. This is where your database file will be.

### For .NET 3.1

If you are using .NET 3.1, then in `Startup`, `Configuration`, change the line that adds the DbContext service to this:

```C#
services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlite(Configuration["ConnectionStrings:SQLiteConnection"]));
```

You can use whatever name you like for the connection string, just make sure the name here matches the one you use in `appsettings.json`.

### For .NET 6.0

If you are using .NET 6.0, then in Program, modify the line of code that gets the connection string and the one that adds the DbContext service to this:

```c#
var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
```

Use any name you like for the connection string as long as it matches the name you use in `appsettings.json`.

## Test on Your Development Machine

1. Add new migrations (after removing all old ones)
   `dotnet ef migrations add SqliteInitial`
2. Create the database and apply the migrations:
   `dotnet ef database update`

Now you should be able to run your app and it should work with your new SQLite database.

## Deploy the Database to an Azure App Service

1. In Visual Studio, in the Solution Explorer, open the Data folder and click on the database file. Right-click and select properties. In the properties dialog, change the value for Copy to output directory to "Always copy". We will do this temporarily so that the database file will be copied to the output before we publish to Azure.

2. Publish the app to Azure without making any connection string changes. Your app should run on Azure now using the SQLite database that you published.

3. You wouldn't want to push another SQLite database to your app the next time you publish--unless you wanted to blow away the data there. So, change the *Copy to output directory* property of your database file back to *Do not copy.*

   

   



