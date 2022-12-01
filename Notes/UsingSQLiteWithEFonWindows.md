<h1>Using SQLite with EF on Windows</h1>

## Install SQLite and SQLite DB Browser

First you need to install SQLite on the Windows development machine. You can do that by downloading and installing [DB Browser for SQLite](https://sqlitebrowser.org/), which you will use to manage your SQLite database. The DB Browser for SQLite setup program will also install SQLite. You can read more about this in appendix B of the Murach textbook.

## Modify your ASP.NET MVC Project to use SQLite

### For .NET 3.1

If you are using .NET 3.1, then in Startup, Configuration, change the line that adds the DbContext service to this:

```C#
services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlite(Configuration["ConnectionStrings:SQLiteConnection"]));
```

You can use whatever name you like for the connection string, just make sure the name here matches the one you use in appsettings.json.

### For .NET 6.0

If you are using .NET 6.0, then in Program, modify the line of code that gets the connection string and the one that adds the DbContext service to this:

```c#
var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
```

Use any name you like for the connection string as long as it matches the name you use in appsettings.json.

### For Both Versions of .NET

1. Add a connection string to appsettings.json for your SQLite database:

```json
  "ConnectionStrings": {
    "SqliteConnection": "Data Source=Data/BookReviews.db"
  },
```

2. Add a folder named "Data" to your project if you don't already have one.



