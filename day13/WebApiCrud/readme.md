# Day 13 - Web API with Entity Framework Core & Database First Approach

## Topics Covered

### 1. **What is Entity Framework Core?**
   - Entity Framework Core (EF Core) is an Object-Relational Mapper (ORM) for .NET
   - Allows developers to work with databases using C# objects
   - Eliminates the need to write raw SQL queries
   - Supports multiple database providers (SQL Server, MySQL, PostgreSQL, SQLite, etc.)

### 2. **Database First vs Code First Approach**
   | Approach | Description |
   |----------|-------------|
   | **Database First** | Database already exists; EF Core generates models from it |
   | **Code First** | Write C# classes first; EF Core creates the database |

   - **Today's Focus**: Database First Approach using Scaffold-DbContext

### 3. **Creating a New Web API Project with Controllers**
   - Use the .NET CLI to create a new Web API project:
     ```bash
     dotnet new webapi -n WebApiCrud --use-controllers
     ```
   - The `--use-controllers` flag creates a controller-based Web API (not minimal API)
   - Navigate to the project folder:
     ```bash
     cd WebApiCrud
     ```

### 4. **Project Structure**
   ```
   WebApiCrud/
   ├── Controllers/
   │   └── StudentsAPIController.cs  # API Controller
   ├── Models/
   │   ├── StudentInfo.cs            # Entity Model (generated)
   │   └── StudentsContext.cs        # DbContext (generated)
   ├── Program.cs                    # Main entry point
   ├── WebApiCrud.csproj             # Project file
   ├── appsettings.json              # Configuration with connection string
   ├── appsettings.Development.json  # Development settings
   └── Properties/
       └── launchSettings.json       # Launch profiles
   ```

### 5. **Installing Required Packages**
   - **Entity Framework Core SQL Server Provider**:
     ```bash
     dotnet add package Microsoft.EntityFrameworkCore.SqlServer
     ```
   - **EF Core Design (for scaffolding)**:
     ```bash
     dotnet add package Microsoft.EntityFrameworkCore.Design
     ```
   - **Swagger/OpenAPI support**:
     ```bash
     dotnet add package Swashbuckle.AspNetCore
     ```
   - **OpenAPI documentation**:
     ```bash
     dotnet add package Microsoft.AspNetCore.OpenApi
     ```

### 6. **Scaffold-DbContext Command (Database First)**
   - Generate models and DbContext from an existing database:
     ```bash
     dotnet ef dbcontext scaffold "Server=pcname\SQLExpress;Database=mydb;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models
     ```
   - **Command Breakdown**:
     | Part | Description |
     |------|-------------|
     | `dotnet ef dbcontext scaffold` | EF Core scaffold command |
     | `"Connection String"` | Your SQL Server connection string |
     | `Microsoft.EntityFrameworkCore.SqlServer` | Database provider |
     | `-o Models` | Output folder for generated files |

   - **Additional Scaffold Options**:
     ```bash
     # Scaffold specific tables only
     dotnet ef dbcontext scaffold "..." Microsoft.EntityFrameworkCore.SqlServer -o Models -t student_info -t another_table

     # Force overwrite existing files
     dotnet ef dbcontext scaffold "..." Microsoft.EntityFrameworkCore.SqlServer -o Models --force

     # Specify context name
     dotnet ef dbcontext scaffold "..." Microsoft.EntityFrameworkCore.SqlServer -o Models --context MyDbContext
     ```


### 7. **Connection String Configuration (appsettings.json)**
   ```json
   {
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
       }
     },
     "AllowedHosts": "*",
     "ConnectionStrings": {
       "DefaultConnection": "Server=pcname\\SQLExpress;Database=mddb;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```
   - **Connection String Parts**:
     | Part | Description |
     |------|-------------|
     | `Server` | SQL Server instance name |
     | `Database` | Database name |
     | `Trusted_Connection=True` | Windows Authentication |
     | `TrustServerCertificate=True` | Trust the server certificate |

### 8. **Program.cs - Complete Configuration**
   ```csharp
   // Register DbContext with Dependency Injection
   builder.Services.AddDbContext<StudentsContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

   ```

### 9. **Key Program.cs Additions Explained**

   #### a) **Using Statements**
   ```csharp
   using WebApiCrud.Models;           // For StudentsContext
   using Microsoft.EntityFrameworkCore; // For UseSqlServer
   ```

   #### b) **AddControllers()**
   ```csharp
   builder.Services.AddControllers();
   ```
   - Registers MVC controllers in the DI container
   - Required for controller-based APIs

   #### c) **AddDbContext()**
   ```csharp
   builder.Services.AddDbContext<StudentsContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
   ```
   - Registers DbContext with Dependency Injection
   - Configures SQL Server as the database provider
   - Reads connection string from appsettings.json

   #### d) **MapControllers()**
   ```csharp
   app.MapControllers();
   ```
   - Maps attribute-routed controllers


### 10. **Running the Application**
   - **Run the application**:
     ```bash
     dotnet run
     ```
   - **Run with hot reload**:
     ```bash
     dotnet watch run
     ```

### 11. **Testing the API**
   - **Swagger UI**: `http://localhost:5xxx/swagger`
   - **API Endpoint**: `GET http://localhost:5xxx/api/StudentAPI`

   - **Sample Response**:
     ```json
     [
       {
         "studentId": 1,
         "fname": "John"
       },
       {
         "studentId": 2,
         "fname": "Jane"
       }
     ]
     ```

### 12. **Dependency Injection (DI) in ASP.NET Core**
   - DI is a design pattern for achieving loose coupling
   - ASP.NET Core has built-in DI container
   - **Service Lifetimes**:
     | Lifetime | Description |
     |----------|-------------|
     | `AddTransient` | New instance every time |
     | `AddScoped` | One instance per request |
     | `AddSingleton` | Single instance for app lifetime |
   - `AddDbContext` uses `Scoped` lifetime by default

### 13. **Common EF Core Commands Reference**
   | Command | Description |
   |---------|-------------|
   | `dotnet ef dbcontext scaffold "..." Provider -o Models` | Generate models from database |
   | `dotnet ef migrations add MigrationName` | Create a migration |
   | `dotnet ef database update` | Apply migrations to database |
   | `dotnet ef migrations list` | List all migrations |
   | `dotnet ef database drop` | Drop the database |

### 14. **Key Points to Remember**
   - **Database First** approach generates models from existing database
   - Use `Scaffold-DbContext` command to generate models and context
   - Register DbContext in Program.cs using `AddDbContext<T>()`
   - Store connection strings in `appsettings.json`
   - Use Constructor Injection to get DbContext in controllers
   - `[ApiController]` attribute enables API behaviors
   - `[Route("api/[controller]")]` defines the base route
   - `ControllerBase` is the base class for API controllers
   - `DbSet<T>` represents a table; use LINQ to query data
   - Always use `TrustServerCertificate=True` for local development

### 15. **Packages Used Summary**
   | Package | Purpose |
   |---------|---------|
   | `Microsoft.EntityFrameworkCore.SqlServer` | SQL Server database provider |
   | `Microsoft.EntityFrameworkCore.Design` | Design-time tools (scaffolding) |
   | `Microsoft.AspNetCore.OpenApi` | OpenAPI/Swagger support |
   | `Swashbuckle.AspNetCore` | Swagger UI generation |

### 16. **Next Steps**
   - Implement POST, PUT, DELETE endpoints
   - Add input validation with Data Annotations
   - Implement async/await for database operations
   - Add error handling and logging
   - Learn about DTOs (Data Transfer Objects)
   - Implement Repository Pattern
   - Add authentication and authorization
