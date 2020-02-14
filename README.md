## Simple Restaurant App with ASP.Net MVC

Simple REST API with ASP.Net Core MVC to display a list of restaurants available with their details (locations acquired from MapQuest API[ later ]) and menus.

### Getting Started

Creating a new mvc project with `dotnet` type `dotnet new mvc -o {projectname}`

Installing important packages

```bash

  dotnet tool install --global dotnet-ef
  dotnet tool install --global dotnet-aspnet-codegenerator
  dotnet add package Microsoft.EntityFrameworkCore.SQLite
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
  dotnet add package Microsoft.EntityFrameworkCore.Design
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer

```

The commands above installs packages:

- dotnet-ef package for entity framework core
- dotnet-aspnet-codegenerator for generating controller, views etc.
- The remaining packages installations required to work with SQLite and SQLServer

Adding https certificate to project `dotnet dev-certs https --trust`

Installing package `dotnet add package {packagename}`

Inside Startup.cs file initialize dbset (must have a db class)

```C#

  // config for sqlite
  services.AddDbContext<MvcMovieContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("ContextName")));

```

Then configure the connection string in `appsettings.json` file

```json

  "ConnectionStrings":{
    "ContextName": "DbName.db"
  }

```

Creating migrations

```bash

    dotnet ef migrations add {MigrationName}
    dotnet ef database update

```
