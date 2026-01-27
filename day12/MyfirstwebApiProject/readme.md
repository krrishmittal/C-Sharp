# Day 12 - Building Your First Web API with ASP.NET Core

## Topics Covered

### 1. **What is a Web API?**
   - Web API (Application Programming Interface) allows different software applications to communicate over HTTP
   - ASP.NET Core Web API is a framework for building RESTful services
   - Uses HTTP methods (GET, POST, PUT, DELETE) to perform CRUD operations
   - Returns data in JSON or XML format

### 2. **Creating a New Web API Project**
   - Use the .NET CLI to create a new Web API project:
     ```bash
     dotnet new webapi -n MyfirstwebApiProject
     ```
   - This creates a minimal API project with a sample WeatherForecast endpoint
   - Navigate to the project folder:
     ```bash
     cd MyfirstwebApiProject
     ```

### 3. **Project Structure**
   ```
   MyfirstwebApiProject/
   ├── Program.cs                 # Main entry point and API configuration
   ├── MyfirstwebApiProject.csproj # Project file with dependencies
   ├── MyfirstwebApiProject.http   # HTTP request testing file
   ├── appsettings.json           # Application configuration
   ├── appsettings.Development.json # Development-specific settings
   └── Properties/
       └── launchSettings.json    # Launch profiles and URLs
   ```

### 4. **Installing Required Packages**
   - **For Swagger/OpenAPI support**:
     ```bash
     dotnet add package Swashbuckle.AspNetCore
     ```
   - **For OpenAPI documentation**:
     ```bash
     dotnet add package Microsoft.AspNetCore.OpenApi
     ```

### 5. **Program.cs - Complete Code Explanation**
   ```csharp
   var builder = WebApplication.CreateBuilder(args);

   // Add services to the container
   builder.Services.AddOpenApi();
   builder.Services.AddEndpointsApiExplorer();
   builder.Services.AddSwaggerGen();

   var app = builder.Build();

   // Configure the HTTP request pipeline
   if (app.Environment.IsDevelopment())
   {
       app.UseSwagger();
       app.UseSwaggerUI();
   }
   ```

### 6. **Code Breakdown**

   #### a) **WebApplication Builder**
   ```csharp
   var builder = WebApplication.CreateBuilder(args);
   ```
   - Creates a new instance of the web application builder
   - Configures default services and settings

   #### b) **Adding Services**
   ```csharp
   builder.Services.AddOpenApi();           // OpenAPI documentation
   builder.Services.AddEndpointsApiExplorer(); // Endpoint discovery for Swagger
   builder.Services.AddSwaggerGen();        // Swagger generation
   ```
   - **AddOpenApi()** - Adds OpenAPI support for API documentation
   - **AddEndpointsApiExplorer()** - Enables endpoint metadata for Swagger
   - **AddSwaggerGen()** - Generates Swagger/OpenAPI specification

   #### c) **Middleware Configuration**
   ```csharp
   if (app.Environment.IsDevelopment())
   {
       app.UseSwagger();      // Enable Swagger middleware
       app.UseSwaggerUI();    // Enable Swagger UI
   }
   app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
   ```

   #### d) **Minimal API Endpoint**
   ```csharp
   app.MapGet("/weatherforecast", () => { ... })
      .WithName("GetWeatherForecast");
   ```
   - **MapGet** - Maps an HTTP GET request to the specified route
   - **WithName** - Assigns a name to the endpoint for documentation

   #### e) **Record Type**
   ```csharp
   record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
   {
       public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
   }
   ```
   - **record** - Immutable reference type with built-in equality
   - Uses primary constructor for properties
   - Includes a computed property `TemperatureF`

### 7. **Running the Application**
   - **Run the application**:
     ```bash
     dotnet run
     ```
   - **Run with hot reload (watch mode)**:
     ```bash
     dotnet watch run
     ```
   - **Build the application**:
     ```bash
     dotnet build
     ```

### 8. **Accessing the API**
   - **HTTP URL**: `http://localhost:5213`
   - **HTTPS URL**: `https://localhost:7094`
   - **Weather Forecast Endpoint**: `http://localhost:5213/weatherforecast`
   - **Swagger UI**: `http://localhost:5213/swagger` or `http://localhost:5213/swagger/index.html`

### 9. **What is Swagger?**
   - Swagger is a tool for API documentation and testing
   - **Swagger UI** provides an interactive interface to:
     - View all available API endpoints
     - Test endpoints directly from the browser
     - See request/response formats
     - Understand API parameters and return types
   - **OpenAPI Specification** - Standard format for describing REST APIs

### 10. **Testing the API**

   #### a) **Using Swagger UI**
   1. Run the application: `dotnet run`
   2. Open browser and navigate to `http://localhost:5213/swagger`
   3. Click on the endpoint to expand it
   4. Click "Try it out" button
   5. Click "Execute" to send the request
   6. View the response

   #### b) **Using .http File (VS Code REST Client)**
   ```http
   @MyfirstwebApiProject_HostAddress = http://localhost:5213

   GET {{MyfirstwebApiProject_HostAddress}}/weatherforecast/
   Accept: application/json

   ###
   ```

   #### c) **Using curl**
   ```bash
   curl http://localhost:5213/weatherforecast
   ```

### 11. **Sample API Response**
   ```json
   [
     {
       "date": "2026-01-28",
       "temperatureC": 25,
       "summary": "Warm",
       "temperatureF": 76
     },
     {
       "date": "2026-01-29",
       "temperatureC": -5,
       "summary": "Freezing",
       "temperatureF": 22
     }
   ]
   ```

### 12. **HTTP Methods Overview**
   | Method | Purpose | Example |
   |--------|---------|---------|
   | GET | Retrieve data | `app.MapGet("/items", ...)` |
   | POST | Create new data | `app.MapPost("/items", ...)` |
   | PUT | Update existing data | `app.MapPut("/items/{id}", ...)` |
   | DELETE | Delete data | `app.MapDelete("/items/{id}", ...)` |

### 13. **launchSettings.json Explained**
   ```json
   {
     "profiles": {
       "http": {
         "commandName": "Project",
         "applicationUrl": "http://localhost:5213",
         "environmentVariables": {
           "ASPNETCORE_ENVIRONMENT": "Development"
         }
       },
       "https": {
         "commandName": "Project",
         "applicationUrl": "https://localhost:7094;http://localhost:5213",
         "environmentVariables": {
           "ASPNETCORE_ENVIRONMENT": "Development"
         }
       }
     }
   }
   ```
   - Defines different launch profiles (http, https)
   - Sets application URLs and ports
   - Configures environment variables

### 14. **Key Points to Remember**
   - Web API uses HTTP protocols to communicate
   - Minimal APIs provide a simplified way to create endpoints
   - Swagger provides interactive API documentation and testing
   - Use `dotnet new webapi` to create a new Web API project
   - Services are registered in the DI container using `builder.Services`
   - Middleware is configured after `builder.Build()`
   - `app.MapGet`, `app.MapPost`, etc., define API routes
   - Records are ideal for DTOs (Data Transfer Objects)
   - Always test APIs in Development environment first
   - HTTPS redirection ensures secure communication

### 15. **Common CLI Commands Reference**
   | Command | Description |
   |---------|-------------|
   | `dotnet new webapi -n ProjectName` | Create new Web API project |
   | `dotnet add package PackageName` | Add NuGet package |
   | `dotnet restore` | Restore dependencies |
   | `dotnet build` | Build the project |
   | `dotnet run` | Run the application |
   | `dotnet watch run` | Run with hot reload |
   | `dotnet clean` | Clean build outputs |

### 16. **Next Steps**
   - Add more endpoints (POST, PUT, DELETE)
   - Connect to a database (Entity Framework Core)
   - Add authentication and authorization
   - Implement input validation
   - Create Controllers for larger APIs
   - Add logging and error handling
